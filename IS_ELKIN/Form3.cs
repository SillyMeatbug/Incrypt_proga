using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_ELKIN
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(); frm4.Show();
            frm4.label1.Text = this.label1.Text;
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(); frm5.Show();
            frm5.label1.Text = this.label1.Text;
            this.Hide();
        }
    }
}
