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
            this.CreateNNBtn = new System.Windows.Forms.Button();
            this.RunDynamicsBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblNumberOfPatterns = new System.Windows.Forms.Label();
            this.lblNNSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentState = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StoredImgPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectPictureBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.distortedImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.nearPat = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddKorean = new System.Windows.Forms.Button();
            this.AddJapanese = new System.Windows.Forms.Button();
            this.AddChinese = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentState)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distortedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearPat)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNNBtn
            // 
            this.CreateNNBtn.Location = new System.Drawing.Point(12, 23);
            this.CreateNNBtn.Name = "CreateNNBtn";
            this.CreateNNBtn.Size = new System.Drawing.Size(312, 23);
            this.CreateNNBtn.TabIndex = 0;
            this.CreateNNBtn.Text = "Create Neural Network";
            this.CreateNNBtn.UseVisualStyleBackColor = true;
            this.CreateNNBtn.Click += new System.EventHandler(this.CreateNNBut_Click);
            // 
            // RunDynamicsBtn
            // 
            this.RunDynamicsBtn.Enabled = false;
            this.RunDynamicsBtn.Location = new System.Drawing.Point(12, 110);
            this.RunDynamicsBtn.Name = "RunDynamicsBtn";
            this.RunDynamicsBtn.Size = new System.Drawing.Size(312, 23);
            this.RunDynamicsBtn.TabIndex = 2;
            this.RunDynamicsBtn.Text = "Run Dynamics";
            this.RunDynamicsBtn.UseVisualStyleBackColor = true;
            this.RunDynamicsBtn.Click += new System.EventHandler(this.RunDynamicsBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnergy);
            this.groupBox1.Controls.Add(this.lblNumberOfPatterns);
            this.groupBox1.Controls.Add(this.lblNNSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties of Neural Network";
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(139, 67);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(13, 13);
            this.lblEnergy.TabIndex = 5;
            this.lblEnergy.Text = "0";
            // 
            // lblNumberOfPatterns
            // 
            this.lblNumberOfPatterns.AutoSize = true;
            this.lblNumberOfPatterns.Location = new System.Drawing.Point(139, 44);
            this.lblNumberOfPatterns.Name = "lblNumberOfPatterns";
            this.lblNumberOfPatterns.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfPatterns.TabIndex = 4;
            this.lblNumberOfPatterns.Text = "0";
            // 
            // lblNNSize
            // 
            this.lblNNSize.AutoSize = true;
            this.lblNNSize.Location = new System.Drawing.Point(139, 22);
            this.lblNNSize.Name = "lblNNSize";
            this.lblNNSize.Size = new System.Drawing.Size(13, 13);
            this.lblNNSize.TabIndex = 3;
            this.lblNNSize.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Value of Energy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Patterns:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size of Neural Network:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.currentState);
            this.groupBox2.Location = new System.Drawing.Point(223, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 185);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current State";
            // 
            // currentState
            // 
            this.currentState.Location = new System.Drawing.Point(6, 17);
            this.currentState.Name = "currentState";
            this.currentState.Size = new System.Drawing.Size(150, 162);
            this.currentState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentState.TabIndex = 0;
            this.currentState.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StoredImgPanel);
            this.groupBox3.Location = new System.Drawing.Point(341, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 224);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patterns in the Neural Network";
            // 
            // StoredImgPanel
            // 
            this.StoredImgPanel.AutoScroll = true;
            this.StoredImgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoredImgPanel.Location = new System.Drawing.Point(3, 16);
            this.StoredImgPanel.Name = "StoredImgPanel";
            this.StoredImgPanel.Size = new System.Drawing.Size(191, 205);
            this.StoredImgPanel.TabIndex = 0;
            // 
            // SelectPictureBtn
            // 
            this.SelectPictureBtn.Enabled = false;
            this.SelectPictureBtn.Location = new System.Drawing.Point(12, 81);
            this.SelectPictureBtn.Name = "SelectPictureBtn";
            this.SelectPictureBtn.Size = new System.Drawing.Size(312, 23);
            this.SelectPictureBtn.TabIndex = 6;
            this.SelectPictureBtn.Text = "Select Picture to Identify";
            this.SelectPictureBtn.UseVisualStyleBackColor = true;
            this.SelectPictureBtn.Click += new System.EventHandler(this.SelectPictureBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.distortedImg);
            this.groupBox4.Location = new System.Drawing.Point(12, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 185);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Picture to Identify";
            // 
            // distortedImg
            // 
            this.distortedImg.Location = new System.Drawing.Point(6, 19);
            this.distortedImg.Name = "distortedImg";
            this.distortedImg.Size = new System.Drawing.Size(189, 159);
            this.distortedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.distortedImg.TabIndex = 0;
            this.distortedImg.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // nearPat
            // 
            this.nearPat.Location = new System.Drawing.Point(6, 41);
            this.nearPat.Name = "nearPat";
            this.nearPat.Size = new System.Drawing.Size(150, 163);
            this.nearPat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nearPat.TabIndex = 7;
            this.nearPat.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.nearPat);
            this.groupBox5.Location = new System.Drawing.Point(400, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 210);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nearest Pattern";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddKorean
            // 
            this.AddKorean.Enabled = false;
            this.AddKorean.Location = new System.Drawing.Point(229, 52);
            this.AddKorean.Name = "AddKorean";
            this.AddKorean.Size = new System.Drawing.Size(95, 23);
            this.AddKorean.TabIndex = 9;
            this.AddKorean.Text = "Add Korean";
            this.AddKorean.UseVisualStyleBackColor = true;
            this.AddKorean.Click += new System.EventHandler(this.AddKorean_Click);
            // 
            // AddJapanese
            // 
            this.AddJapanese.Enabled = false;
            this.AddJapanese.Location = new System.Drawing.Point(119, 52);
            this.AddJapanese.Name = "AddJapanese";
            this.AddJapanese.Size = new System.Drawing.Size(98, 23);
            this.AddJapanese.TabIndex = 10;
            this.AddJapanese.Text = "Add Japanese";
            this.AddJapanese.UseVisualStyleBackColor = true;
            this.AddJapanese.Click += new System.EventHandler(this.AddJapanese_Click);
            // 
            // AddChinese
            // 
            this.AddChinese.Enabled = false;
            this.AddChinese.Location = new System.Drawing.Point(12, 52);
            this.AddChinese.Name = "AddChinese";
            this.AddChinese.Size = new System.Drawing.Size(98, 23);
            this.AddChinese.TabIndex = 11;
            this.AddChinese.Text = "Add Chinese";
            this.AddChinese.UseVisualStyleBackColor = true;
            this.AddChinese.Click += new System.EventHandler(this.AddChinese_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 599);
            this.Controls.Add(this.AddChinese);
            this.Controls.Add(this.AddJapanese);
            this.Controls.Add(this.AddKorean);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SelectPictureBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RunDynamicsBtn);
            this.Controls.Add(this.CreateNNBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentState)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distortedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearPat)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNNBtn;
        private System.Windows.Forms.Button RunDynamicsBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblNumberOfPatterns;
        private System.Windows.Forms.Label lblNNSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox currentState;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel StoredImgPanel;
        private System.Windows.Forms.Button SelectPictureBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox distortedImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox nearPat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button AddKorean;
        private System.Windows.Forms.Button AddJapanese;
        private System.Windows.Forms.Button AddChinese;
        private System.Windows.Forms.Label label4;
    }
}

