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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Result_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1A.Text);
            double b = double.Parse(textBox1B.Text);
            double result = (a*a)-(b*b);
            textBoxResult.Text = result.ToString();
            textBox1A.Clear();
            textBox1B.Clear();
        }

        private void button2Result_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox2A.Text);
            double b = double.Parse(textBox2B.Text);
            double result = (a * a) + (b * b) + 2 * a * b;
            textBox2Result.Text = result.ToString();
            textBox2A.Clear();
            textBox2B.Clear();
        }
    }
}
