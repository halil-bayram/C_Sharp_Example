using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace megahafıza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> sayılar = new List<int>();
       
        Random rnd = new Random();
        
        void tekrarsızsayıüret()
        {
            sayılar.Clear();
            int sayı, sayac = 0;
            do
            {
                sayı = rnd.Next(0, 100);
                if (sayılar.IndexOf(sayı) == -1)
                {
                    sayılar.Add(sayı);
                    sayac++;
                }
            } while (sayac !=100);

        }

        void butonüretme()
        {
            int x=0, y=0;
            
            for (int i = 1; i < 101; i++)
            {
                Button btn=new Button();
                btn.Name = sayılar[i-1].ToString();
                btn.Text = sayılar[i - 1].ToString();
                btn.Size = new Size(35,35);
                btn.Location = new Point(x,y);
                x += 35;
                lblsıradaklisayı.Text = 0.ToString();
                btn.Click += new EventHandler(btn_Click);
                panel1.Controls.Add(btn);
                if (i%10==0)
                {
                    x = 0;
                    y += 35;
                }
            }
        }
            int sıradakisayı = 0;
         
        void btn_Click(object sender, EventArgs e)
        {

            Button yenihal = sender as Button;
            lblsıradaklisayı.Text = (sıradakisayı+1).ToString();
            if (yenihal.Text==sıradakisayı.ToString())
            {
                
                sıradakisayı++;
                yenihal.Visible = false;
                
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tekrarsızsayıüret();
            butonüretme();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dakika, saniye;

        }

    }
}
