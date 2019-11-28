namespace CC
{
    partial class Form2
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
            this.RadiusBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.resultLab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CirRB = new System.Windows.Forms.RadioButton();
            this.hSqRB = new System.Windows.Forms.RadioButton();
            this.TriRB = new System.Windows.Forms.RadioButton();
            this.EnterBT = new System.Windows.Forms.Button();
            this.ClearBT = new System.Windows.Forms.Button();
            this.GTCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GTS = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadiusBox
            // 
            this.RadiusBox.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadiusBox.Location = new System.Drawing.Point(124, 183);
            this.RadiusBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RadiusBox.Multiline = true;
            this.RadiusBox.Name = "RadiusBox";
            this.RadiusBox.Size = new System.Drawing.Size(184, 48);
            this.RadiusBox.TabIndex = 0;
            // 
            // HeightBox
            // 
            this.HeightBox.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBox.Location = new System.Drawing.Point(124, 257);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.HeightBox.Multiline = true;
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(184, 48);
            this.HeightBox.TabIndex = 1;
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(124, 325);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.WidthBox.Multiline = true;
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(184, 48);
            this.WidthBox.TabIndex = 2;
            // 
            // resultLab
            // 
            this.resultLab.Font = new System.Drawing.Font("TH SarabunPSK", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLab.Location = new System.Drawing.Point(124, 383);
            this.resultLab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.resultLab.Multiline = true;
            this.resultLab.Name = "resultLab";
            this.resultLab.Size = new System.Drawing.Size(214, 48);
            this.resultLab.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Radius :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result :";
            // 
            // CirRB
            // 
            this.CirRB.AutoSize = true;
            this.CirRB.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CirRB.Location = new System.Drawing.Point(81, 111);
            this.CirRB.Name = "CirRB";
            this.CirRB.Size = new System.Drawing.Size(89, 41);
            this.CirRB.TabIndex = 8;
            this.CirRB.TabStop = true;
            this.CirRB.Text = "Circle";
            this.CirRB.UseVisualStyleBackColor = true;
            this.CirRB.CheckedChanged += new System.EventHandler(this.CirRB_CheckedChanged);
            // 
            // hSqRB
            // 
            this.hSqRB.AutoSize = true;
            this.hSqRB.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hSqRB.Location = new System.Drawing.Point(219, 111);
            this.hSqRB.Name = "hSqRB";
            this.hSqRB.Size = new System.Drawing.Size(102, 41);
            this.hSqRB.TabIndex = 9;
            this.hSqRB.TabStop = true;
            this.hSqRB.Text = "Square";
            this.hSqRB.UseVisualStyleBackColor = true;
            this.hSqRB.CheckedChanged += new System.EventHandler(this.hSqRB_CheckedChanged);
            // 
            // TriRB
            // 
            this.TriRB.AutoSize = true;
            this.TriRB.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriRB.Location = new System.Drawing.Point(368, 111);
            this.TriRB.Name = "TriRB";
            this.TriRB.Size = new System.Drawing.Size(111, 41);
            this.TriRB.TabIndex = 10;
            this.TriRB.TabStop = true;
            this.TriRB.Text = "Triangle";
            this.TriRB.UseVisualStyleBackColor = true;
            this.TriRB.CheckedChanged += new System.EventHandler(this.Tri_CheckedChanged);
            // 
            // EnterBT
            // 
            this.EnterBT.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBT.Location = new System.Drawing.Point(53, 458);
            this.EnterBT.Name = "EnterBT";
            this.EnterBT.Size = new System.Drawing.Size(135, 55);
            this.EnterBT.TabIndex = 11;
            this.EnterBT.Text = "Enter";
            this.EnterBT.UseVisualStyleBackColor = true;
            this.EnterBT.Click += new System.EventHandler(this.EnterBT_Click);
            // 
            // ClearBT
            // 
            this.ClearBT.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBT.Location = new System.Drawing.Point(203, 458);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(135, 55);
            this.ClearBT.TabIndex = 12;
            this.ClearBT.Text = "Clear";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // GTCalculate
            // 
            this.GTCalculate.Font = new System.Drawing.Font("TH SarabunPSK", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTCalculate.Location = new System.Drawing.Point(651, 12);
            this.GTCalculate.Name = "GTCalculate";
            this.GTCalculate.Size = new System.Drawing.Size(148, 52);
            this.GTCalculate.TabIndex = 13;
            this.GTCalculate.Text = "Go To Calculate";
            this.GTCalculate.UseVisualStyleBackColor = true;
            this.GTCalculate.Click += new System.EventHandler(this.GTCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TH SarabunPSK", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 50);
            this.label5.TabIndex = 14;
            this.label5.Text = "C.S.T";
            // 
            // GTS
            // 
            this.GTS.Font = new System.Drawing.Font("TH SarabunPSK", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTS.Location = new System.Drawing.Point(651, 70);
            this.GTS.Name = "GTS";
            this.GTS.Size = new System.Drawing.Size(148, 52);
            this.GTS.TabIndex = 15;
            this.GTS.Text = "Go To Square";
            this.GTS.UseVisualStyleBackColor = true;
            this.GTS.Click += new System.EventHandler(this.GTS_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(669, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 44);
            this.button4.TabIndex = 16;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 534);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GTS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GTCalculate);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.EnterBT);
            this.Controls.Add(this.TriRB);
            this.Controls.Add(this.hSqRB);
            this.Controls.Add(this.CirRB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLab);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.RadiusBox);
            this.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form2";
            this.Text = "C.S.T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RadiusBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox resultLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton CirRB;
        private System.Windows.Forms.RadioButton hSqRB;
        private System.Windows.Forms.RadioButton TriRB;
        private System.Windows.Forms.Button EnterBT;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.Button GTCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GTS;
        private System.Windows.Forms.Button button4;
    }
}