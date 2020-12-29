using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace trafikısık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            tmr1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac < 11)
            {
                btnkırmızı.BackColor = Color.Red;
                btnyesil1.BackColor = Color.Green;
                lbl1.Text = (11 - sayac).ToString();
                lbl1.BackColor = Color.Red;
                if (sayac == 10)
                {

                    btnkırmızı.BackColor = Color.White;
                    btnyesil1.BackColor = Color.White;
                }
            }
            if (sayac >= 11)
            {
                lbl1.Text="";
                btnsarı.BackColor = Color.Yellow;
                btnsarı1.BackColor = Color.Yellow;
                if (sayac >= 13)
                {
                    btnsarı.BackColor = Color.White;
                    btnsarı1.BackColor = Color.White;
                }
            }
            if (sayac >= 13)
            {
                btnyesil.BackColor = Color.Green;
                btnkırmızı1.BackColor = Color.Red;
                lbl1.Text = (23 - sayac).ToString();
                lbl1.BackColor = Color.Green;
                if (sayac >= 23)
                {
                    btnyesil.BackColor = Color.White;
                    btnkırmızı1.BackColor = Color.White;

                }
            }
            if (sayac == 23)
            {
                sayac = 0;
            }

        }
    }
}
