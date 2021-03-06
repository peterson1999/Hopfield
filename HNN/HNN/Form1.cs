﻿using HopfieldNeuralNetwork;
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
        private List<List<Neuron>> patternList = new List<List<Neuron>>();
        private List<string> classifier = new List<string>();
        private int scanLineLoc = 0;
        private bool scanLineDir = true, startScanAnim = false;
        public Form1()
        {
            InitializeComponent();
        }
        /*private void UpdatePropertiesPB()
        {
            lblNNSize.Text = NN.N.ToString();
            lblNumberOfPatterns.Text = NN.M.ToString();
            lblEnergy.Text = NN.Energy.ToString();
        }*/
        private void CreateNNBtn_Click(object sender, EventArgs e)
        {
            NN = new NeuralNetwork(imageDim* imageDim);
            StoredImgPanel.Controls.Clear();
            NN.EnergyChanged += new EnergyChangedHandler(NN_EnergyChanged);
            current = new Bitmap(imageDim, imageDim);
            distImg = null;
            distortedImg.Image = currentState.BackgroundImage = currentState.Image = nearPat.Image = null;
            label4.Text = "";

            scanLineLoc = 0;
            scanLineDir = true;
            startScanAnim = false;

            AddChinese.Enabled = true;
            AddJapanese.Enabled = true;
            AddKorean.Enabled = true;
            SelectPictureBtn.Enabled = false;
            RunDynamicsBtn.Enabled = false;
            patternList.Clear();
            classifier.Clear();
          
            //UpdatePropertiesPB();
        }

        private void NN_EnergyChanged(object sender, EnergyEventArgs e)
        {
            //lblEnergy.Text = e.Energy.ToString();
            int i = (int)e.NeuronIndex / imageDim;
            int j = e.NeuronIndex % imageDim;
            if (current.GetPixel(i, j).ToArgb() == Color.White.ToArgb())
                current.SetPixel(i, j, Color.Black);
            else if (current.GetPixel(i, j).ToArgb() == Color.Black.ToArgb())
                current.SetPixel(i, j, Color.White);

            currentState.BackgroundImage = current;
            currentState.Invalidate();
            currentState.Refresh();
            Application.DoEvents();
            System.Threading.Thread.Sleep(100);
        }

        private void AddPattern()
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
                    for (int i = 0; i < imageDim; i++)
                        for (int j = 0; j < imageDim; j++)
                        {
                            Neuron n = new Neuron();
                            p = Math.Abs(b.GetPixel(i, j).ToArgb());
                            if (p < midColor)
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
                    patternList.Add(pattern);
                    NN.AddPattern(pattern);

                    PictureBox img = new PictureBox();
                    Padding myMargin = new Padding();
                    myMargin.All = 10;
                    img.Image = new Bitmap(imgPattern);
                    img.Width = 100;
                    img.Height = 80;
                    img.Margin = myMargin;
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    StoredImgPanel.Controls.Add(img);
                    SelectPictureBtn.Enabled = true;
                    //UpdatePropertiesPB();
                }
            }
        }

        private int NearestPattern(List<Neuron> inState)
        {
            int maxCount = 0, count = 0, pat = 0;
            for (int i = 0; i < patternList.Count; i++)
            {
                count = 0;
                for (int j = 0; j < (imageDim*imageDim); j++)
                {
                    if (inState[j].State == patternList[i][j].State)
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    pat = i;
                }
            }
            return pat;
        }
        
        private void RunDynamicsBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(distImg);
            List<Neuron> initialState = new List<Neuron>(NN.N);

            startScanAnim = true;
            scanLineLoc = 0;
            scanLineDir = true;

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
            //lblEnergy.Text = NN.Energy.ToString();
            startScanAnim = false;
            currentState.Image = current;

            int nearest = NearestPattern(initialState);
            Console.WriteLine(nearest);
            int k = 0;
            Bitmap nPattern = new Bitmap(imageDim, imageDim);
            for (int i = 0; i < imageDim; i++)
                for (int j = 0; j < imageDim; j++)
                {
                    if (patternList[nearest][k++].State == -1)
                        nPattern.SetPixel(i, j, Color.Black);
                    else
                        nPattern.SetPixel(i, j, Color.White);
                }

            k = 0;
            for (int i = 0; i < imageDim; i++)
                for (int j = 0; j < imageDim; j++)
                {
                    if (initialState[k++].State == -1)
                        current.SetPixel(i, j, Color.Black);
                    else
                        current.SetPixel(i, j, Color.White);
                }
            label4.Text = "This looks like the " + classifier[nearest] + " word:";
            nearPat.Image = nPattern;
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

        private void AddJapanese_Click(object sender, EventArgs e)
        {
            classifier.Add("Japanese");
            AddPattern();

        }

        private void AddChinese_Click(object sender, EventArgs e)
        {
            classifier.Add("Chinese");
            AddPattern();
        }

        private void AddKorean_Click(object sender, EventArgs e)
        {
            classifier.Add("Korean");
            AddPattern();
        }

        private void currentState_Paint(object sender, PaintEventArgs e)
        {
            if (startScanAnim)
            {
                int increment = 10;
                Graphics g = e.Graphics;
                g.DrawLine(new Pen(Color.Red, 2.5f), 0, scanLineLoc, 165, scanLineLoc);

                if (scanLineDir == true)
                {
                    scanLineLoc += increment;
                    if (scanLineLoc >= 166)
                    {
                        scanLineLoc -= increment;
                        scanLineDir = false;
                    }
                }
                else
                {
                    scanLineLoc -= increment;
                    if (scanLineLoc <= 0)
                    {
                        scanLineLoc += increment;
                        scanLineDir = true;
                    }
                }
                this.Invalidate(); 
            }
        }
    }
}
