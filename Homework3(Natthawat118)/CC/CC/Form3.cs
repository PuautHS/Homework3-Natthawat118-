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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void hSq2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(FirstBox.Text);
            b = double.Parse(SecBox.Text);
            resultLab.Text = Square(a, b);
        }
        public string Square(double x, double y)
        {
            double z = 0;
            if (MlistBox.Text == "Square(จัตุรัต)")
            {
                if (FirstBox.Text == "")
                {
                    MessageBox.Show("Please insert NUM Side1");
                }
                else if (SecBox.Text == "")
                {
                    MessageBox.Show("Please insert NUM Side2");
                }
                else
                {
                    z = x * y;
                }
            }
            else if (MlistBox.Text == "Rectangle(ผืนผ้า)")
            {
                if (FirstBox.Text == "")
                {
                    MessageBox.Show("Please insert NUM Width");
                }
                else if (SecBox.Text == "")
                {
                    MessageBox.Show("Please insert NUM Long");
                }
                else
                {
                    z = x * y;
                }
            }
            else if (MlistBox.Text == "Diamond(ขนมเปียกปูน)")
            {
                if (FirstBox.Text == "")
                {
                    MessageBox.Show("Please insert NUM Base");
                }
                else if (SecBox.Text == "")
                {
                    MessageBox.Show("Please insert NUM Height");
                }
                else
                {
                    z = x * y;
                }
            }
            else if (MlistBox.Text == "Parallelogram(ด้านขนาน)")
            {
                if (FirstBox.Text == "")
                {
                    MessageBox.Show("Please insert NUM Base");
                }
                else if (SecBox.Text == "")
                {
                    MessageBox.Show("Please insert NUM Height");
                }
                else
                {
                    z = x * y;
                }
            }
            return z.ToString();
        }

        private void MlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MlistBox.Text == "Square(จัตุรัต)")
            {
                text1.Text = "ด้าน";
                text2.Text = "ด้าน";
            }
            else if (MlistBox.Text == "Rectangle(ผืนผ้า)")
            {
                text1.Text = "กว้าง";
                text2.Text = "ยาว";
            }
            else if (MlistBox.Text == "Diamond(ขนมเปียกปูน)")
            {
                text1.Text = "ฐาน";
                text2.Text = "สูง";
            }
            else if (MlistBox.Text == "Parallelogram(ด้านขนาน)")
            {
                text1.Text = "ฐาน";
                text2.Text = "สูง";
            }
        }

        private void GTCST_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();

        }

        private void GTCalculate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye");
            Close();
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            FirstBox.Text = "0";
            SecBox.Text = "0";
            resultLab.Text = "0"; 
        }
    }
}