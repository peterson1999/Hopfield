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
            this.CreateNNBtn.BackColor = System.Drawing.Color.White;
            this.CreateNNBtn.Location = new System.Drawing.Point(13, 38);
            this.CreateNNBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNNBtn.Name = "CreateNNBtn";
            this.CreateNNBtn.Size = new System.Drawing.Size(428, 45);
            this.CreateNNBtn.TabIndex = 0;
            this.CreateNNBtn.Text = "Create Character Set";
            this.CreateNNBtn.UseVisualStyleBackColor = false;
            this.CreateNNBtn.Click += new System.EventHandler(this.CreateNNBtn_Click);
            // 
            // RunDynamicsBtn
            // 
            this.RunDynamicsBtn.BackColor = System.Drawing.Color.White;
            this.RunDynamicsBtn.Enabled = false;
            this.RunDynamicsBtn.Location = new System.Drawing.Point(13, 251);
            this.RunDynamicsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RunDynamicsBtn.Name = "RunDynamicsBtn";
            this.RunDynamicsBtn.Size = new System.Drawing.Size(428, 40);
            this.RunDynamicsBtn.TabIndex = 2;
            this.RunDynamicsBtn.Text = "Find Character";
            this.RunDynamicsBtn.UseVisualStyleBackColor = false;
            this.RunDynamicsBtn.Click += new System.EventHandler(this.RunDynamicsBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.currentState);
            this.groupBox2.Location = new System.Drawing.Point(294, 332);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(228, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current State";
            // 
            // currentState
            // 
            this.currentState.BackColor = System.Drawing.Color.White;
            this.currentState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentState.Location = new System.Drawing.Point(4, 19);
            this.currentState.Margin = new System.Windows.Forms.Padding(4);
            this.currentState.Name = "currentState";
            this.currentState.Size = new System.Drawing.Size(220, 205);
            this.currentState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentState.TabIndex = 0;
            this.currentState.TabStop = false;
            this.currentState.Paint += new System.Windows.Forms.PaintEventHandler(this.currentState_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.StoredImgPanel);
            this.groupBox3.Location = new System.Drawing.Point(501, 38);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(263, 276);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Characters Saved";
            // 
            // StoredImgPanel
            // 
            this.StoredImgPanel.AutoScroll = true;
            this.StoredImgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoredImgPanel.Location = new System.Drawing.Point(4, 19);
            this.StoredImgPanel.Margin = new System.Windows.Forms.Padding(4);
            this.StoredImgPanel.Name = "StoredImgPanel";
            this.StoredImgPanel.Padding = new System.Windows.Forms.Padding(40, 4, 40, 4);
            this.StoredImgPanel.Size = new System.Drawing.Size(255, 253);
            this.StoredImgPanel.TabIndex = 0;
            // 
            // SelectPictureBtn
            // 
            this.SelectPictureBtn.BackColor = System.Drawing.Color.White;
            this.SelectPictureBtn.Enabled = false;
            this.SelectPictureBtn.Location = new System.Drawing.Point(13, 189);
            this.SelectPictureBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SelectPictureBtn.Name = "SelectPictureBtn";
            this.SelectPictureBtn.Size = new System.Drawing.Size(428, 38);
            this.SelectPictureBtn.TabIndex = 6;
            this.SelectPictureBtn.Text = "Select Picture to Identify";
            this.SelectPictureBtn.UseVisualStyleBackColor = false;
            this.SelectPictureBtn.Click += new System.EventHandler(this.SelectPictureBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.distortedImg);
            this.groupBox4.Location = new System.Drawing.Point(13, 332);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(273, 228);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Picture to Identify";
            // 
            // distortedImg
            // 
            this.distortedImg.BackColor = System.Drawing.Color.White;
            this.distortedImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.distortedImg.Location = new System.Drawing.Point(4, 19);
            this.distortedImg.Margin = new System.Windows.Forms.Padding(4);
            this.distortedImg.Name = "distortedImg";
            this.distortedImg.Size = new System.Drawing.Size(265, 205);
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
            this.nearPat.Location = new System.Drawing.Point(33, 50);
            this.nearPat.Margin = new System.Windows.Forms.Padding(4);
            this.nearPat.Name = "nearPat";
            this.nearPat.Size = new System.Drawing.Size(200, 201);
            this.nearPat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nearPat.TabIndex = 7;
            this.nearPat.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.nearPat);
            this.groupBox5.Location = new System.Drawing.Point(530, 332);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(269, 258);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nearest Character";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // AddKorean
            // 
            this.AddKorean.BackColor = System.Drawing.Color.White;
            this.AddKorean.Enabled = false;
            this.AddKorean.Location = new System.Drawing.Point(315, 108);
            this.AddKorean.Margin = new System.Windows.Forms.Padding(4);
            this.AddKorean.Name = "AddKorean";
            this.AddKorean.Size = new System.Drawing.Size(126, 56);
            this.AddKorean.TabIndex = 9;
            this.AddKorean.Text = "Add Korean";
            this.AddKorean.UseVisualStyleBackColor = false;
            this.AddKorean.Click += new System.EventHandler(this.AddKorean_Click);
            // 
            // AddJapanese
            // 
            this.AddJapanese.BackColor = System.Drawing.Color.White;
            this.AddJapanese.Enabled = false;
            this.AddJapanese.Location = new System.Drawing.Point(170, 108);
            this.AddJapanese.Margin = new System.Windows.Forms.Padding(4);
            this.AddJapanese.Name = "AddJapanese";
            this.AddJapanese.Size = new System.Drawing.Size(137, 56);
            this.AddJapanese.TabIndex = 10;
            this.AddJapanese.Text = "Add Japanese";
            this.AddJapanese.UseVisualStyleBackColor = false;
            this.AddJapanese.Click += new System.EventHandler(this.AddJapanese_Click);
            // 
            // AddChinese
            // 
            this.AddChinese.BackColor = System.Drawing.Color.White;
            this.AddChinese.Enabled = false;
            this.AddChinese.Location = new System.Drawing.Point(13, 108);
            this.AddChinese.Margin = new System.Windows.Forms.Padding(4);
            this.AddChinese.Name = "AddChinese";
            this.AddChinese.Size = new System.Drawing.Size(149, 56);
            this.AddChinese.TabIndex = 11;
            this.AddChinese.Text = "Add Chinese";
            this.AddChinese.UseVisualStyleBackColor = false;
            this.AddChinese.Click += new System.EventHandler(this.AddChinese_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(819, 614);
            this.Controls.Add(this.AddChinese);
            this.Controls.Add(this.AddJapanese);
            this.Controls.Add(this.AddKorean);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SelectPictureBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RunDynamicsBtn);
            this.Controls.Add(this.CreateNNBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "East Asian Character Recognizer";
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
        private System.Windows.Forms.GroupBox groupBox2;
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

