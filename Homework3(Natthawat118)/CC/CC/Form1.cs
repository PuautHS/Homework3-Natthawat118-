using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Mlist.Text = "Sample";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calButt_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(FirstBox.Text);
            b = double.Parse(secondBox.Text);
            resultLab.Text = calculate(a,b);
        }
        public string calculate(double x, double y)
        {
            double z = 0;
            if (Mlist.Text == "+")
            {
                z = x + y;
            }
            else if (Mlist.Text == "-")
            {
                z = x - y;
            }
            else if (Mlist.Text == "*")
            {
                z = x * y;
            }
            else if (Mlist.Text == "/")
            {
                z = x / y;
            }
            else if (Mlist.Text == "^X")
            {
                z = Math.Pow(x, y);
            }
            else if (Mlist.Text == "Root")
            {
                z = Math.Pow(x, (1 / y));
            }
            return z.ToString();
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            FirstBox.Text = "0";
            secondBox.Text = "0";
            resultLab.Text = "0";
        }

        private void GTCST_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void SquareF_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye");
            Close();
        }
    }
}
