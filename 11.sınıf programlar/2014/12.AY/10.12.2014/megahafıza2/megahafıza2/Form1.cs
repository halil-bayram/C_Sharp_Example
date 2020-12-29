using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace megahafıza2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x=0, y=0, sırasayı=0;
        Random rnd = new Random();
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label2.Text = sırasayı.ToString();
            panel1.Controls.Clear();
            x = 0;
            y = 0;
            sayıüret();
            timer1.Start();
            timer2.Start();
            for (int i = 1; i < 101; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(40,40);
                btn.Location = new Point(x,y);
                panel1.Controls.Add(btn);
               
                btn.Text = sayılar[i - 1].ToString();
                btn.Click += new EventHandler(btn_Click);
                x += 40;
                if (i%10==0)
                {
                    x = 0;
                    y += 40;
                }


            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button b=sender as Button;
            
            if (sırasayı.ToString()==b.Text)
            {
                sayac = 0;
                puanekleme = 1000;
                toplampuan += tıklanmasayısı;
                label4.Text = toplampuan.ToString();
                sırasayı++;
                b.Visible = false;
                label2.Text = sırasayı.ToString();

            }
        }
        List<int> sayılar = new List<int>();
        void sayıüret()
        {
            sayılar.Clear();
            int sayı,sayac=0 ;
            do
            {
                sayı = rnd.Next(0,100);
            if (sayılar.IndexOf(sayı)==-1)
            {
                sayılar.Add(sayı);
                sayac++;
            }
            } while (sayac!=100);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        DateTime süre = new DateTime(1000,1,1,0,0,0);
        int sayac=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = süre.AddSeconds(1);
            label1.Text = süre.ToLongTimeString();
            sayac++;
            if (sayac==10)
            {
                foreach (Button b in panel1.Controls)
                {
                    if (b.Text==sırasayı.ToString())
                    {
                        b.BackColor = Color.Red;
                    }

                }
                sayac = 0;
            }
        }
        int puanekleme=1000,toplampuan=0,tıklanmasayısı;
        private void timer2_Tick(object sender, EventArgs e)
        {

            puanekleme--;
            tıklanmasayısı = puanekleme;
            label3.Text = puanekleme.ToString();
        }

    }
}
