using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAKIKALIOYUN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, sayac = 10, tıklama = 0;
        Random rnd = new Random();

        private void tmrsüre_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;

            sayac--;
            lblsüre.Text = "kalan süre:" + sayac.ToString();
            x = rnd.Next(0,this.Width-btn1.Width);
            y = rnd.Next(0, this.Height - btn1.Height);
            btn1.Location=new Point(x,y);
            if (sayac==0)
            {
                tmrsüre.Stop();
                if (tıklama<10)
                {
                    MessageBox.Show("kaybettiniz:");

                }
                else
                {
                    MessageBox.Show("tebrikler kazandınız:");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrsüre.Start();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tıklama++;
            lbltıklama.Text = "tıklama=" + tıklama.ToString();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }       
    }
}
        