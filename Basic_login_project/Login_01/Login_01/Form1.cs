using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;  //Khai bao su dung luong

namespace Login_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SFrom2()
        {
            S_Panel f = new S_Panel();
            f.ShowDialog();
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            if ((txt1.Text == "admin") && (txt2.Text == "12345"))
            {
                if ((MessageBox.Show("Login complete", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    Thread thread = new Thread(new ThreadStart(SFrom2));
                    thread.Start();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong account or passord", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
