using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace eslesmeoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> sayılar = new List<int>();
        SoundPlayer player = new SoundPlayer("sesler\\1.wav");
        Random rnd = new Random();
        int index, kalanresim = 8, deneme = 0;
        void listedoldur()
        {
            sayılar.Clear();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    sayılar.Add(j);
                }
            }
        }
        void picturbaxekle()
        {
            int x = 0, y = 0;
            for (int i = 1; i <= 16; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(64, 64);
                pb.Location = new Point(x, y);
                pb.BackColor = Color.BurlyWood;
                panel1.Controls.Add(pb);
                index = rnd.Next(0, sayılar.Count);
                pb.Name = sayılar[index].ToString();
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Image = Image.FromFile("Resimler\\0.png");
                sayılar.RemoveAt(index);
                x += 68;
                pb.Click += new EventHandler(pb_Click);
                if (i % 4 == 0)
                {
                    x = 0;
                    y += 68;
                }
            }
        }
        int sayac = 0;
        PictureBox ilktıklanan, tıklanan;
        void pb_Click(object sender, EventArgs e)
        {
            player.Play();
            PictureBox pb = sender as PictureBox;
            tıklanan = pb;
            tıklanan.Image = Image.FromFile("Resimler\\" + tıklanan.Name + ".png");

            sayac++;
            if (sayac == 1)
            {
                tıklanan.Enabled = false;
            }
            if (sayac == 2)
            {
                timer1.Start();
                deneme++;
                label2.Text = "Deneme:" + deneme.ToString();
                foreach (PictureBox pbn in panel1.Controls)
                {
                    pbn.Enabled = false;
                }
            }
            else
            {
                ilktıklanan = tıklanan;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listedoldur();
            picturbaxekle();
        }
        int sayac1 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (önizleme == false)
            {
                sayac1++;
                if (sayac1 == 1)
                {
                    timer1.Stop();
                    if (ilktıklanan.Name == tıklanan.Name)
                    {
                        ilktıklanan.Visible = false;
                        tıklanan.Visible = false;
                        if (kalanresim == 0)
                        {
                            MessageBox.Show("Tebrikler");
                            btnyenile_Click(sender, e);
                        }
                        else
                        {
                            kalanresim--;
                            label1.Text = "Kalan Resim:" + kalanresim.ToString();
                        }

                    }
                    else
                    {
                        ilktıklanan.Image = Image.FromFile("Resimler\\0.png");
                        tıklanan.Image = Image.FromFile("Resimler\\0.png");

                    }

                    foreach (PictureBox pb in panel1.Controls)
                    {
                        pb.Enabled = true;
                    }
                }
                sayac1 = 0;
                sayac = 0;
            }
            else
            {
                sayac1++;
                if (sayac1 == 2)
                {
                    foreach (PictureBox pb in panel1.Controls)
                    {
                        pb.Image = Image.FromFile("Resimler\\0.png");
                    }
                    sayac1 = 0;
                    timer1.Stop();
                    önizleme = false;
                }
                else
                {
                    foreach (PictureBox pb in panel1.Controls)
                    {
                        pb.Image = Image.FromFile("Resimler\\" + pb.Name + ".png");
                    }
                }
            }


        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            deneme = 0;
            kalanresim = 8;
            panel1.Controls.Clear();
            listedoldur();
            picturbaxekle();

        }
        bool önizleme = false;
        private void btnönizleme_Click(object sender, EventArgs e)
        {
            önizleme = true;
            timer1.Start();
        }

    }
}
