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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBox_Sqare.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxA.Text, out double a);
            double.TryParse(textBoxB.Text, out double b);
            double.TryParse(textBoxC.Text, out double c);
            if(a+b>c || b+c>a || a+c>b)
            {
                double p = (a + b + c) / 2;
                double result = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                textBox_Sqare.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка. Такого треугольника не существует!");
            }

        }
    }
}
