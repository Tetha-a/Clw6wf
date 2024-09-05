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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxAlgebra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxAlgebra.SelectedIndex == 0)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else if (listBoxAlgebra.SelectedIndex == 1)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
        }

        private void listBoxGeometry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGeometry.SelectedIndex == 0)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
            else if (listBoxGeometry.SelectedIndex == 1)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
            else
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
            }
        }
    }
}
