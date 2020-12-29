using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace butonlabulmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> isimler = new List<string> {"elma","armut","veli","bilgisayar","mönitor","fare","kasa" };
        List<int> sayılar = new List<int>();
        Random rnd = new Random();
        void tekrarsızsayıüret(string kelime)
        {
            sayılar.Clear();
            int sayı, sayac = 0;
            do
            {
                sayı=rnd.Next(0,kelime.Length);
                if (sayılar.IndexOf(sayı)==-1)
	{
		 sayılar.Add(sayı);
                    sayac++;
	}
            } while (sayac!=kelime.Length);
        }
        string secilenkelime;
        void kelimesec()
        {
            panel1.Controls.Clear();
            label1.Text = "";
            tıklama = 0;
            secilenkelime = isimler[rnd.Next(0, isimler.Count)];
            isimler.Remove(secilenkelime);
            tekrarsızsayıüret(secilenkelime);
            butonekle();
        }
        void butonekle()
        {
            int x = -30, y = 0;
            for (int i = 0; i < secilenkelime.Length; i++)
            {
                Button btn = new Button();
                btn.Text = secilenkelime[sayılar[i]].ToString();
                btn.Size = new Size(30, 30);
                btn.Location = new Point(x += 30, y);
                panel1.Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kelimesec();
        }
        int tıklama = 0;
        void btn_Click(object sender, EventArgs e)
        {
            Button özellik=sender as Button;
            label1.Text += özellik.Text;
            özellik.Visible = false;
            tıklama++;
            if (tıklama==secilenkelime.Length)
            {
                if (secilenkelime==label1.Text)
                {
                    MessageBox.Show("tebrikler");
                    if (isimler.Count!=0)
                    {
                        kelimesec();
                    }
                    else
                    {
                        MessageBox.Show("kelime bitti");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("kazanamadın");
                    label1.Text = "";
                    tıklama = 0;
                    foreach (Button item in panel1.Controls)
                    {
                        item.Visible = true;
                    }

                }
            }
        }

    }
}
