using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbase_Click(object sender, EventArgs e)
        {
            basenum sisnum = new basenum();
            sisnum.Show();
            this.Hide();
        }

        private void btnascii_Click(object sender, EventArgs e)
        {
            ASCII codascii = new ASCII();
            codascii.Show();
            this.Hide();
        }
    }
}
