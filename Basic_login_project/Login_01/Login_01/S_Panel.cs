using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login_01
{
    public partial class S_Panel : Form
    {
        public S_Panel()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt1.Text += btn0.Text;
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            if ((txt1.Text == "1645") || 
                (txt1.Text == "1689") || 
                (txt1.Text == "8345") || 
                (txt1.Text == "9998") || 
                (txt1.Text == "1006") || 
                (txt1.Text == "1008"))
            {
                lb1.Items.Add(DateTime.Now + " Login Succes ");
                txt1.Clear();
            }
            else
            {
                lb1.Items.Add(DateTime.Now + " Restricted Access!");
                txt1.Clear();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txt1.Clear();
        }
        private void e_app()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(e_app));
            thread.Start();
            this.Close();
        }
    }
}
