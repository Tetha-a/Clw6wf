using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clw6wf
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGep.Text))
            {
                double a = double.Parse(textBoxKatA.Text);
                double b = double.Parse(textBoxKatB.Text);
                double result = Math.Sqrt(a*a+b*b);
                textBoxGep.Text = result.ToString();
            }
            else if (String.IsNullOrEmpty(textBoxKatA.Text))
            {
                double b = double.Parse(textBoxKatB.Text);
                double c = double.Parse(textBoxGep.Text);
                if (c <= b)
                {
                    MessageBox.Show("Катет не может быть больше гепотинузы");
                }
                else
                {
                    double result = Math.Sqrt(c * c - b * b);
                    textBoxKatA.Text = result.ToString();
                }
            }
            else
            {
                double a = double.Parse(textBoxKatA.Text);
                double c = double.Parse(textBoxGep.Text);
                if (c <= a)
                {
                    MessageBox.Show("Катет не может быть больше гепотинузы");
                }
                else
                {
                    double result = Math.Sqrt(c * c - a * a);
                    textBoxKatB.Text = result.ToString();
                }
            }
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxKatA.Clear();
            textBoxKatB.Clear();
            textBoxGep.Clear();
        }
    }
}
