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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            double c = double.Parse(textBoxC.Text);
            double x1, x2;
            double discrimenant = b * b - 4 * a * c;
            if(discrimenant < 0)
            {
                MessageBox.Show("Действительных корней нет");
            }
            else if(discrimenant > 0)
            {

                x1 = ((-b+Math.Sqrt(discrimenant))/2*a);
                x2 = x1 = ((-b - Math.Sqrt(discrimenant)) / 2 * a);
                textBoxX1.Text = x1.ToString();
                textBoxX2.Text = x2.ToString();
                labelX2.Visible = true;
                textBoxX2.Visible = true;
            }
            else
            {
                x1 = (-b) / (2 * a);
                textBoxX1.Text = x1.ToString();
                labelX2.Visible = false;
                textBoxX2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
