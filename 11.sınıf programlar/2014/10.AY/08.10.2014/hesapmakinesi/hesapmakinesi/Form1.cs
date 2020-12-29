using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1=0,sayı2=0;
        string ıslem;
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtekranı.Text += "0";
        }
        private void btnesit_Click(object sender, EventArgs e)
        {
            sayı2 = int.Parse(txtekranı.Text);
            if (ıslem=="+")
            {
                txtekranı.Text = (sayı1 + sayı2).ToString();
            }
            else if (ıslem=="-")
            {
                txtekranı.Text = (sayı1 - sayı2).ToString();
            }
            else if (ıslem == "*")
            {
                txtekranı.Text = (sayı1 * sayı2).ToString();
            }
            else if (ıslem == "/")
            {
                txtekranı.Text = (sayı1 / sayı2).ToString();
            }
             sayı2=0;
        }
        private void btnclr_Click(object sender, EventArgs e)
        {
            txtekranı.Text = "";
        }
        private void btnartı_Click(object sender, EventArgs e)
        {
            sayı1 += int.Parse(txtekranı.Text);
            ıslem = "+";
            sayı1 = 0;
        }
        private void btneksi_Click(object sender, EventArgs e)
        {
            sayı1 -= int.Parse(txtekranı.Text);
            ıslem = "-";
            txtekranı.Text = "";
            sayı1 = 0;
        }
        private void btncarpı_Click(object sender, EventArgs e)
        {
            sayı1 *= int.Parse(txtekranı.Text);
            ıslem = "*";
            txtekranı.Text = "";
            sayı1 = 0;
        }
        private void btnbolu_Click(object sender, EventArgs e)
        {
            sayı1 /= int.Parse(txtekranı.Text);
            ıslem = "/";
            txtekranı.Text = "";
            sayı1=0;
        }
        string gerial;
        
        private void btngerial_Click(object sender, EventArgs e)
        {
            gerial = txtekranı.Text;
            txtekranı.Text="";
            for (int i = 0; i < gerial.Length-1; i++)
            {
                txtekranı.Text+=gerial[i];
            }
        }
			
			 
			
    }
}
