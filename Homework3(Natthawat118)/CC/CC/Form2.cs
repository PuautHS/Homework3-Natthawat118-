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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CirRB_CheckedChanged(object sender, EventArgs e)
        {
            if (CirRB.Checked == true)
            {
                RadiusBox.Enabled = true;
                HeightBox.Enabled = false;
                WidthBox.Enabled = false;
                RadiusBox.Focus();
            }
        }
        private void hSqRB_CheckedChanged(object sender, EventArgs e)
        {
            if (hSqRB.Checked == true)
            {
                RadiusBox.Enabled = false;
                HeightBox.Enabled = true;
                WidthBox.Enabled = true;
                RadiusBox.Focus();
            }
        }
        private void Tri_CheckedChanged(object sender, EventArgs e)
        {
            if (TriRB.Checked == true)
            {
                RadiusBox.Enabled = false;
                HeightBox.Enabled = true;
                WidthBox.Enabled = true;
                RadiusBox.Focus();
            }
        }
        private void EnterBT_Click(object sender, EventArgs e)
        {
            float radius, height, width, resultL;
            double Z;

            //Cir
            if (CirRB.Checked == true)
            {
                if (RadiusBox.Text == "")
                {
                    MessageBox.Show("Please Insert Radius");
                }
                else
                {
                    radius = float.Parse(RadiusBox.Text);
                    resultL = (22 / 7) * radius * radius;
                    resultLab.Text = resultL.ToString();
                }
            }

            //Square
            else if (hSqRB.Checked == true)
            {
                if (HeightBox.Text == "")
                {
                    MessageBox.Show("Please Insert Number height");
                }
                else if (WidthBox.Text == "")
                {
                    MessageBox.Show("Please Insert Number width");
                }
            else
                {
                    height = float.Parse(HeightBox.Text);
                    width = float.Parse(WidthBox.Text);
                    resultL = height * width;
                    resultLab.Text = resultL.ToString();
                }
            }

            //Triangle
            else if (TriRB.Checked == true)
            {
                if (HeightBox.Text == "")
                {
                    MessageBox.Show("Please Insert Number height");
                }
                else if (WidthBox.Text == "")
                {
                    MessageBox.Show("Please Insert Number width");
                }
                else
                {
                    height = float.Parse(HeightBox.Text);
                    width = float.Parse(WidthBox.Text);
                    Z = (0.5) * height * width;
                    resultLab.Text = Z.ToString("#.00");
                }
            }
            else
            {
                MessageBox.Show("Please input value", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void GTCalculate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            RadiusBox.Clear();
            HeightBox.Clear();
            WidthBox.Clear();
            resultLab.Clear();
        }

        private void GTS_Click(object sender, EventArgs e)
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