using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace futbolcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=1;
        bool king =true;
        string yol = Application.StartupPath;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image =Image.FromFile (yol + "\\ftbl\\" + sayac + ".jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==12)
            {
                button2.Enabled = false;
            }
            if (sayac>0)
            {
                button1.Enabled = true;
            }
            pictureBox1.Image = Image.FromFile(yol + "\\ftbl\\" + sayac + ".jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac--;
            if (sayac == 1)
            {
                button1.Enabled = false;
            }
            if (sayac <12)
            {
                button2.Enabled = true;
            }
            pictureBox1.Image = Image.FromFile(yol + "\\ftbl\\" + sayac + ".jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac<12 && king==true)
            {
                sayac++;
                pictureBox1.Image = Image.FromFile(yol + "\\ftbl\\" + sayac + ".jpg");
                 if (sayac==12)
	             {
                 king = false;
                     
	           }
            }
            if (sayac <=12 && king == false)
            {
                sayac--;
                pictureBox1.Image = Image.FromFile(yol + "\\ftbl\\" + sayac + ".jpg");
                if (sayac == 1)
                {
                    king = true;
                }
            }
	        
        }
    }
}
