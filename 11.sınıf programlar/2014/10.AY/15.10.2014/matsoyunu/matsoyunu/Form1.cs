using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace matsoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tmr1.Start();
        }
        int sayı1, sayı2,konturol,sayac=1,sayac2=0;
        Random rnd = new Random();
        Color[] renkler = {Color.Red,Color.White,Color.Yellow,Color.SpringGreen,Color.Snow,Color.Salmon,Color.Olive,Color.GreenYellow,Color.LimeGreen,Color.Lime,Color.LemonChiffon };
        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (sayac2==0)
            {
            sayı1 = rnd.Next(1,10);
            sayı2 = rnd.Next(1, 10);
            lblsayı1.Text = sayı1.ToString();
            lblsayı2.Text = sayı2.ToString();
            konturol = rnd.Next(1,3);
            if (konturol==1)
            {
                lblsonuc.Text=(sayı1 + sayı2).ToString();
            }
            else
            {
                lblsonuc.Text = ((sayı1 + sayı2) + rnd.Next(1,20)).ToString();
            }
            }
            sayac2++;
             if (sayac2>4)
            {
                tmr1.Stop();
                MessageBox.Show("süreniz doldu");
                Application.Exit();
            }
        }
        private void btnd_Click(object sender, EventArgs e)
        {
           this.BackColor=renkler[rnd.Next(0,11)];
           btnd.BackColor = renkler[rnd.Next(0, 11)];
           btny.BackColor = renkler[rnd.Next(0, 11)];
            if (konturol==1)
            {
            sayac2 = 0;
                lblsayac.Text=(sayac++).ToString();
            }
            else
            {
                tmr1.Stop();
                MessageBox.Show("Yanlış Cevap Verdiniz");
                Application.Exit();
            }
        }
        private void btny_Click(object sender, EventArgs e)
        {
            this.BackColor = renkler[rnd.Next(0, 11)];
            btny.BackColor=renkler[rnd.Next(0,11)];
            btnd.BackColor = renkler[rnd.Next(0, 11)];
            if (konturol==2)
            {
                sayac2 = 0;
                lblsayac.Text=(sayac--).ToString();
            }
            else
            {
                tmr1.Stop();
                MessageBox.Show("Yanlış Cevap Verdiniz");
                Application.Exit();
            }
        }

       
        

        
    }
}
