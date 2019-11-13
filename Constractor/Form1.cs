using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //Form2 frm1 = new Form2();
            //frm.Show();

            //Form2 frm1 = new Form2("Bilge adam");

            Form2 frmx = new Form2(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));
            numericUpDown1.Value = numericUpDown2.Value = numericUpDown3.Value = 0;

            frmx.Show();
        }
    }
}
