using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clw6wf
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxRadius.Text))
            {
                double.TryParse(textBoxRadius.Text, out double r);
                double p = 3.14;
                double s = 0;
                s = p * (r * r);
                textBoxSquare.Text = s.ToString();
            }
            else if (!String.IsNullOrEmpty(textBoxDiametr.Text))
            {
                double.TryParse(textBoxDiametr.Text, out double d);
                double p = 3.14;
                double s = 0;
                s = (p * (d * d))/4;
                textBoxSquare.Text = s.ToString();
            }
            else if (!String.IsNullOrEmpty(textBoxLenghtCircumference.Text))
            {
                double.TryParse(textBoxLenghtCircumference.Text, out double l);
                double p = 3.14;
                double s = 0;
                s = l*l/(4*p);
                textBoxSquare.Text = s.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDiametr.Clear();
            textBoxLenghtCircumference.Clear();
            textBoxRadius.Clear();
            textBoxSquare.Clear();
        }
    }
}
