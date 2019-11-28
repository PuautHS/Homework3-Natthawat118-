namespace CC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.FirstBox = new System.Windows.Forms.TextBox();
            this.SecBox = new System.Windows.Forms.TextBox();
            this.MlistBox = new System.Windows.Forms.ComboBox();
            this.hSq2 = new System.Windows.Forms.Button();
            this.ClearBT = new System.Windows.Forms.Button();
            this.resultLab = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstBox
            // 
            this.FirstBox.Location = new System.Drawing.Point(101, 166);
            this.FirstBox.Multiline = true;
            this.FirstBox.Name = "FirstBox";
            this.FirstBox.Size = new System.Drawing.Size(235, 44);
            this.FirstBox.TabIndex = 0;
            // 
            // SecBox
            // 
            this.SecBox.Location = new System.Drawing.Point(101, 266);
            this.SecBox.Multiline = true;
            this.SecBox.Name = "SecBox";
            this.SecBox.Size = new System.Drawing.Size(235, 44);
            this.SecBox.TabIndex = 1;
            // 
            // MlistBox
            // 
            this.MlistBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MlistBox.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MlistBox.FormattingEnabled = true;
            this.MlistBox.Items.AddRange(new object[] {
            "Square(จัตุรัต)",
            "Rectangle(ผืนผ้า)",
            "Diamond(ขนมเปียกปูน)",
            "Parallelogram(ด้านขนาน)"});
            this.MlistBox.Location = new System.Drawing.Point(101, 216);
            this.MlistBox.Name = "MlistBox";
            this.MlistBox.Size = new System.Drawing.Size(235, 44);
            this.MlistBox.TabIndex = 2;
            this.MlistBox.SelectedIndexChanged += new System.EventHandler(this.MlistBox_SelectedIndexChanged);
            // 
            // hSq2
            // 
            this.hSq2.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hSq2.Location = new System.Drawing.Point(101, 396);
            this.hSq2.Name = "hSq2";
            this.hSq2.Size = new System.Drawing.Size(116, 47);
            this.hSq2.TabIndex = 3;
            this.hSq2.Text = "Square";
            this.hSq2.UseVisualStyleBackColor = true;
            this.hSq2.Click += new System.EventHandler(this.hSq2_Click);
            // 
            // ClearBT
            // 
            this.ClearBT.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBT.Location = new System.Drawing.Point(220, 396);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(116, 47);
            this.ClearBT.TabIndex = 4;
            this.ClearBT.Text = "Clear";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // resultLab
            // 
            this.resultLab.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLab.Location = new System.Drawing.Point(136, 327);
            this.resultLab.Name = "resultLab";
            this.resultLab.Size = new System.Drawing.Size(269, 51);
            this.resultLab.TabIndex = 6;
            this.resultLab.Text = "0";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(46, 166);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(29, 37);
            this.text1.TabIndex = 7;
            this.text1.Text = "=";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(46, 273);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(29, 37);
            this.text2.TabIndex = 8;
            this.text2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 57);
            this.label2.TabIndex = 10;
            this.label2.Text = "SQUARE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 57);
            this.label3.TabIndex = 11;
            this.label3.Text = "Result :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(411, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Go To Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GTCalculate_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(169, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "Go To C.S.T";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GTCST_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(635, 572);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 44);
            this.button4.TabIndex = 15;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 624);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.resultLab);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.hSq2);
            this.Controls.Add(this.MlistBox);
            this.Controls.Add(this.SecBox);
            this.Controls.Add(this.FirstBox);
            this.Name = "Form3";
            this.Text = "Square";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstBox;
        private System.Windows.Forms.TextBox SecBox;
        private System.Windows.Forms.ComboBox MlistBox;
        private System.Windows.Forms.Button hSq2;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.TextBox resultLab;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}