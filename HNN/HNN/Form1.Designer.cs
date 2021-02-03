namespace HNN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateNNBut = new System.Windows.Forms.Button();
            this.butAddPattern = new System.Windows.Forms.Button();
            this.butRunDynamics = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblNumberOfPatterns = new System.Windows.Forms.Label();
            this.lblNNSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelStoredImages = new System.Windows.Forms.Panel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNNBut
            // 
            this.CreateNNBut.Location = new System.Drawing.Point(12, 23);
            this.CreateNNBut.Name = "CreateNNBut";
            this.CreateNNBut.Size = new System.Drawing.Size(312, 23);
            this.CreateNNBut.TabIndex = 0;
            this.CreateNNBut.Text = "button1";
            this.CreateNNBut.UseVisualStyleBackColor = true;
            this.CreateNNBut.Click += new System.EventHandler(this.CreateNNBut_Click);
            // 
            // butAddPattern
            // 
            this.butAddPattern.Location = new System.Drawing.Point(12, 52);
            this.butAddPattern.Name = "butAddPattern";
            this.butAddPattern.Size = new System.Drawing.Size(312, 23);
            this.butAddPattern.TabIndex = 1;
            this.butAddPattern.Text = "button2";
            this.butAddPattern.UseVisualStyleBackColor = true;
            // 
            // butRunDynamics
            // 
            this.butRunDynamics.Location = new System.Drawing.Point(12, 81);
            this.butRunDynamics.Name = "butRunDynamics";
            this.butRunDynamics.Size = new System.Drawing.Size(312, 23);
            this.butRunDynamics.TabIndex = 2;
            this.butRunDynamics.Text = "button3";
            this.butRunDynamics.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnergy);
            this.groupBox1.Controls.Add(this.lblNumberOfPatterns);
            this.groupBox1.Controls.Add(this.lblNNSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties of Neural Network";
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(135, 105);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(16, 13);
            this.lblEnergy.TabIndex = 5;
            this.lblEnergy.Text = "0:";
            // 
            // lblNumberOfPatterns
            // 
            this.lblNumberOfPatterns.AutoSize = true;
            this.lblNumberOfPatterns.Location = new System.Drawing.Point(114, 67);
            this.lblNumberOfPatterns.Name = "lblNumberOfPatterns";
            this.lblNumberOfPatterns.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfPatterns.TabIndex = 4;
            this.lblNumberOfPatterns.Text = "0";
            // 
            // lblNNSize
            // 
            this.lblNNSize.AutoSize = true;
            this.lblNNSize.Location = new System.Drawing.Point(132, 31);
            this.lblNNSize.Name = "lblNNSize";
            this.lblNNSize.Size = new System.Drawing.Size(13, 13);
            this.lblNNSize.TabIndex = 3;
            this.lblNNSize.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Value of Energy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Patterns:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size of Neural Network:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelStoredImages);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 185);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current State of NN";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(341, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 415);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patterns in NN";
            // 
            // panelStoredImages
            // 
            this.panelStoredImages.Location = new System.Drawing.Point(10, 30);
            this.panelStoredImages.Name = "panelStoredImages";
            this.panelStoredImages.Size = new System.Drawing.Size(282, 149);
            this.panelStoredImages.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butRunDynamics);
            this.Controls.Add(this.butAddPattern);
            this.Controls.Add(this.CreateNNBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNNBut;
        private System.Windows.Forms.Button butAddPattern;
        private System.Windows.Forms.Button butRunDynamics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblNumberOfPatterns;
        private System.Windows.Forms.Label lblNNSize;
        private System.Windows.Forms.Panel panelStoredImages;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

