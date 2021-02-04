using HopfieldNeuralNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNN
{
    public partial class Form1 : Form
    {
        private NeuralNetwork NN;
        private int imageDim = 10;
        private Image distImg;
        private Bitmap current;
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdatePropertiesPB()
        {
            lblNNSize.Text = NN.N.ToString();
            lblNumberOfPatterns.Text = NN.M.ToString();
            lblEnergy.Text = NN.Energy.ToString();
        }
        private void CreateNNBut_Click(object sender, EventArgs e)
        {
            NN = new NeuralNetwork(imageDim* imageDim);
            StoredImgPanel.Controls.Clear();
            NN.EnergyChanged += new EnergyChangedHandler(NN_EnergyChanged);
            current = new Bitmap(imageDim, imageDim);
            /*Random rnd = new Random();
            int r = 0;
            imNNState.pixels = new int[imageDim, imageDim];
            for (int i = 0; i<imageDim; i++)
                for (int j = 0; j<imageDim; j++)
                {
                    r = rnd.Next(2);
                    if (r == 0) imNNState.pixels[i, j] = Color.Black.ToArgb();
                    else if (r == 1) imNNState.pixels[i, j] = Color.White.ToArgb();                    
                }*/
            distImg = null;
            AddPatternBtn.Enabled = true;
            SelectPictureBtn.Enabled = false;
            RunDynamicsBtn.Enabled = false;
            /*imNNState.Visible = true;
            imNNState.Invalidate();*/
            UpdatePropertiesPB();
        }

        private void NN_EnergyChanged(object sender, EnergyEventArgs e)
        {
            lblEnergy.Text = e.Energy.ToString();
            int i = (int)e.NeuronIndex / imageDim;
            int j = e.NeuronIndex % imageDim;
            /*if (imNNState.pixels[i, j] == Color.White.ToArgb()) imNNState.pixels[i, j] = Color.Black.ToArgb();
            else if (imNNState.pixels[i, j] == Color.Black.ToArgb()) imNNState.pixels[i, j] = Color.White.ToArgb();
            imNNState.Invalidate();*/
            currentState.Image = current;
            Application.DoEvents();
            System.Threading.Thread.Sleep(100);
        }

        private void AddPatternBut_Click(object sender, EventArgs e)
        {
            Image imgPattern;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgPattern = Image.FromFile(openFileDialog1.FileName);
                if (imgPattern.Width != imageDim || imgPattern.Height != imageDim)
                {
                    MessageBox.Show("Image size must be " + imageDim.ToString() + "x" + imageDim.ToString() + " pixels", "Wrong image size", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                    
                    int[,] patternPixels;
                    int p = 0;
                    int midColor = Math.Abs((int)(Color.Black.ToArgb() / 2));
                    Bitmap b = new Bitmap(imgPattern);
                    patternPixels = new int[imageDim, imageDim];
                    List<Neuron> pattern = new List<Neuron>(imageDim * imageDim);
                    for (int i = 0; i<imageDim; i++)
                        for (int j = 0; j<imageDim; j++)
                        {
                            Neuron n = new Neuron();
                            p = Math.Abs(b.GetPixel(i, j).ToArgb());
                            if (p<midColor)
                            {
                                b.SetPixel(i, j, Color.White);
                                n.State = NeuronStates.AlongField;
                            }
                            else
                            {
                                b.SetPixel(i, j, Color.Black);
                                n.State = NeuronStates.AgainstField;
                            }
                            pattern.Add(n);
                        }
                    NN.AddPattern(pattern);
                    PictureBox img = new PictureBox();
                    img.Image = new Bitmap(imgPattern);
                    StoredImgPanel.Controls.Add(img);
                    SelectPictureBtn.Enabled = true;
                    UpdatePropertiesPB();
                }                
            }            
        }

        
        
        private void RunDynamicsBut_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(distImg);
            
            List<Neuron> initialState = new List<Neuron>(NN.N);
            for (int i = 0; i<imageDim; i++)
                for (int j=0;j<imageDim;j++)
                {
                    Neuron neuron = new Neuron();
                    int currentPixel = img.GetPixel(i, j).ToArgb();
                    if (currentPixel == Color.Black.ToArgb())
                    {
                        neuron.State = NeuronStates.AgainstField;
                        current.SetPixel(i, j, Color.Black);
                    }
                    else if (currentPixel == Color.White.ToArgb())
                    {
                        neuron.State = NeuronStates.AlongField;
                        current.SetPixel(i, j, Color.White);
                    }
                    initialState.Add(neuron);
                }
            NN.Run(initialState);
            lblEnergy.Text = NN.Energy.ToString();
            currentState.Image = current;
        }

        private void HopfieldRecognizerMainForm_Load(object sender, EventArgs e)
        {
            CreateNNBtn.Text = "Create Neural Network (" + (imageDim* imageDim) + " Neurons)";
        }

        private void SelectPictureBtn_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            if (distImg != null)
            {
                RunDynamicsBtn.Enabled = true;
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            distImg = Image.FromFile(openFileDialog2.FileName);
            distortedImg.Image = distImg;
        }
    }
}
