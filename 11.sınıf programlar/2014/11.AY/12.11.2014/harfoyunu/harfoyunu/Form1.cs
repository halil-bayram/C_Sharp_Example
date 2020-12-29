using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace harfoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string secilenkelime,secilenyedek,harfler="ertyuıopğüasdfghjklşizcvbnmöç",bekle="LODİNG...";
        List<string> kelimeler = new List<string>() { "hayat", "karpuz", "araba", "motosiklet", "bilgisayar" };
        string yol = Application.StartupPath + "\\resimler\\";
        int sayac=0;
        public void kelime()
        {
            int sayı;
            if (kelimeler.Count == 0)
            {
                MessageBox.Show("kelime bitti");
                Application.Exit();
            }
            else
            {
                sayı = rnd.Next(0, kelimeler.Count);
                secilenkelime = kelimeler[sayı];
                kelimeler.RemoveAt(sayı);
            }

           secilenyedek = secilenkelime;
            resimler(secilenyedek);
        }
        public void harfleriKarıstır()
        {
            for (int i = 0; i < 10 - secilenyedek.Length; i++)
            {
                secilenkelime += harfler[rnd.Next(harfler.Length)];
            }
            int[] sayılarım = new int[secilenkelime.Length];
            int sayı, sayac = 0;
            
            do
            {
                sayı = rnd.Next(1, secilenkelime.Length + 1);
                if (Array.IndexOf(sayılarım, sayı) == -1)
                {
                    sayılarım[sayac] = sayı;
                    sayac++;
                }
            } while (sayac < secilenkelime.Length);
            for (int i = 0; i < secilenkelime.Length; i++)
            {
                txtkelime.Text += secilenkelime[sayılarım[i] - 1];
            }
        }
        public void kontroletme()
        {
            if (secilenyedek == txttahmin.Text)
            {   
                MessageBox.Show("TEBRİKLER KAZANDINIZ!!!");
            }
            else
            {
                MessageBox.Show(" ÜZGÜNÜM KAYBETTİNİZ!!!");   
            }
        }
        public void resimler(string kaynak)
        {
            pictureBox1.Image = Image.FromFile(yol +"\\"+ kaynak + "\\0.jpg");
            pictureBox2.Image = Image.FromFile(yol +"\\"+ kaynak + "\\1.jpg");
            pictureBox3.Image = Image.FromFile(yol +"\\"+ kaynak + "\\2.jpg");
            pictureBox4.Image = Image.FromFile(yol +"\\"+ kaynak + "\\3.jpg");
        }
        void temizle()
        {
            txtkelime.Text = "";
            txttahmin.Text = "";
        }
        

        private void btnbasla_Click(object sender, EventArgs e)
        {
            
            temizle();
            kelime();
            harfleriKarıstır();
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {

            kontroletme();
            btnbasla_Click(sender, e);
        }
         int zaman = 0,zaman2=30;
        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value++;
            if (progressBar1.Value==progressBar1.Maximum)
            {
                
                timer1.Stop();
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }

            label3.Text += bekle[zaman];
              zaman++;
            if (zaman==bekle.Length)
            {
                zaman = 0;
                label3.Text = "";
            }
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {groupBox2.Visible = false;
            timer1.Start();
            
        }

        

        

       

       

        

        

        
    }
}
