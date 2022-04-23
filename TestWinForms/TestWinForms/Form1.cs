using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            lbl_Hello.Text = "First Program Lmao";
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            
            lbl_Hello.ForeColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            lbltxt1.Text = textBox1.Text + " The Best";
        }
    }
}
