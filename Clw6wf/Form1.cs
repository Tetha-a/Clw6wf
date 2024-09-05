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
    }
}
