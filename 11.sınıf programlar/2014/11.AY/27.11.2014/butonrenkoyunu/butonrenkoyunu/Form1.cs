using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace butonrenkoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color[] renkler = { Color.Aqua, Color.Beige, Color.BlanchedAlmond, Color.Brown, Color.DarkGreen, Color.DarkTurquoise, Color.Goldenrod, Color.Fuchsia, Color.Khaki };
        List<int> sayılar = new List<int>();
        Random rnd = new Random();
        void butonekleme()
        {
            int x=0, y=0;
            for (int i = 1; i < 10; i++)
            {
                Button renkbutonu=new Button();
                renkbutonu.Name = i.ToString();
                renkbutonu.Size = new Size(30,30);
                renkbutonu.BackColor=renkler[sayılar[i-1]];
                renkbutonu.Location = new Point(x,y);
                x += 30;
                renkbutonu.Click += new EventHandler(renkbutonu_Click);
                panel1.Controls.Add(renkbutonu);
                if (i%3==0)
                {
                    x = 0;
                    y += 30;
                }
            }
        }
        void button()
        {
            buton123.BackColor = renkler[rnd.Next(0,renkler.Length)];
        }
        int puan = 0;

        void renkbutonu_Click(object sender, EventArgs e)
        {
            Button renközellikleri = sender as Button;
            renközellikleri.Visible = false;
            if (buton123.BackColor==renközellikleri.BackColor)
            {
                puan++;
                label1.Text = puan.ToString();
            }
            else
            {
                puan--;
                label1.Text = puan.ToString();
            }
        }
        void tekrarsızrenk()
        {
            sayılar.Clear();
            int sayı, sayac = 0;
            do
            {
                sayı = rnd.Next(0, renkler.Length);
                if (sayılar.IndexOf(sayı) == -1)
                {
                    sayılar.Add(sayı);
                    sayac++;
                }
            } while (sayac != renkler.Length);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            button();
            tekrarsızrenk();
            butonekleme();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            tekrarsızrenk();
            butonekleme();
            button();
        }

    }
}
