namespace CC
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
            this.FirstBox = new System.Windows.Forms.TextBox();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.Mlist = new System.Windows.Forms.ComboBox();
            this.CalBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLab = new System.Windows.Forms.Label();
            this.ClearButt = new System.Windows.Forms.Button();
            this.GTCST = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SquareF = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstBox
            // 
            this.FirstBox.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstBox.Location = new System.Drawing.Point(19, 149);
            this.FirstBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FirstBox.Name = "FirstBox";
            this.FirstBox.Size = new System.Drawing.Size(213, 43);
            this.FirstBox.TabIndex = 0;
            this.FirstBox.Text = "0";
            // 
            // secondBox
            // 
            this.secondBox.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondBox.Location = new System.Drawing.Point(478, 149);
            this.secondBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(213, 43);
            this.secondBox.TabIndex = 1;
            this.secondBox.Text = "0";
            // 
            // Mlist
            // 
            this.Mlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mlist.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mlist.FormattingEnabled = true;
            this.Mlist.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "^X",
            "Root"});
            this.Mlist.Location = new System.Drawing.Point(238, 149);
            this.Mlist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Mlist.Name = "Mlist";
            this.Mlist.Size = new System.Drawing.Size(234, 44);
            this.Mlist.TabIndex = 2;
            // 
            // CalBox
            // 
            this.CalBox.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalBox.Location = new System.Drawing.Point(19, 273);
            this.CalBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CalBox.Name = "CalBox";
            this.CalBox.Size = new System.Drawing.Size(188, 52);
            this.CalBox.TabIndex = 3;
            this.CalBox.Text = "Calculate";
            this.CalBox.UseVisualStyleBackColor = true;
            this.CalBox.Click += new System.EventHandler(this.calButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result :";
            // 
            // resultLab
            // 
            this.resultLab.AutoSize = true;
            this.resultLab.Font = new System.Drawing.Font("TH SarabunPSK", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLab.Location = new System.Drawing.Point(108, 204);
            this.resultLab.Name = "resultLab";
            this.resultLab.Size = new System.Drawing.Size(46, 64);
            this.resultLab.TabIndex = 7;
            this.resultLab.Text = "0";
            // 
            // ClearButt
            // 
            this.ClearButt.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButt.Location = new System.Drawing.Point(227, 273);
            this.ClearButt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(188, 52);
            this.ClearButt.TabIndex = 8;
            this.ClearButt.Text = "Clear";
            this.ClearButt.UseVisualStyleBackColor = true;
            this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
            // 
            // GTCST
            // 
            this.GTCST.Font = new System.Drawing.Font("TH SarabunPSK", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTCST.Location = new System.Drawing.Point(645, 466);
            this.GTCST.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GTCST.Name = "GTCST";
            this.GTCST.Size = new System.Drawing.Size(154, 37);
            this.GTCST.TabIndex = 9;
            this.GTCST.Text = "Go To C.S.T";
            this.GTCST.UseVisualStyleBackColor = true;
            this.GTCST.Click += new System.EventHandler(this.GTCST_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calculate";
            // 
            // SquareF
            // 
            this.SquareF.Location = new System.Drawing.Point(489, 466);
            this.SquareF.Name = "SquareF";
            this.SquareF.Size = new System.Drawing.Size(152, 37);
            this.SquareF.TabIndex = 11;
            this.SquareF.Text = "Square";
            this.SquareF.UseVisualStyleBackColor = true;
            this.SquareF.Click += new System.EventHandler(this.SquareF_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 44);
            this.button4.TabIndex = 16;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SquareF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GTCST);
            this.Controls.Add(this.ClearButt);
            this.Controls.Add(this.resultLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalBox);
            this.Controls.Add(this.Mlist);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.FirstBox);
            this.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "CC1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstBox;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.ComboBox Mlist;
        private System.Windows.Forms.Button CalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLab;
        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.Button GTCST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SquareF;
        private System.Windows.Forms.Button button4;
    }
}

