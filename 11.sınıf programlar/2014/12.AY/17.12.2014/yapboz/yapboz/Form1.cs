using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yapboz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        List<int> sayılar = new List<int>();
        List<PictureBox> bospbox = new List<PictureBox>();
        List<Image> kodlaparcalananresim = new List<Image>();
        Random rnd = new Random();
        void sayıüret(int adet)
        {
            sayılar.Clear();
            int sayı;
            do
            {
                sayı = rnd.Next(0, adet);
                if (sayılar.IndexOf(sayı) == -1)
                {
                    sayılar.Add(sayı);
                }

            } while (sayılar.Count != adet);
        }
        void picturboxekle()
        {
            panel1.Controls.Clear();
            sayıüret(boyut * boyut);
            resimparcala();
            sayac = 0;


            //panel1  picturbox ekliyo resim
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    PictureBox pctrbx = new PictureBox();
                    pctrbx.Size = new Size(pbboyut, pbboyut);
                    pctrbx.Name = sayılar[sayac].ToString();
                    pctrbx.BringToFront();
                    pctrbx.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctrbx.Image = kodlaparcalananresim[sayılar[sayac]];
                    pctrbx.Location = new Point(j * pbboyut, i * pbboyut);
                    pctrbx.BorderStyle = BorderStyle.FixedSingle;
                    panel1.Controls.Add(pctrbx);
                    sayac++;
                    pctrbx.MouseDown += new MouseEventHandler(pctrbx_MouseDown);
                    pctrbx.MouseMove += new MouseEventHandler(pctrbx_MouseMove);
                    pctrbx.MouseUp += new MouseEventHandler(pctrbx_MouseUp);


                }

            }
            //panel1 picturbox ekliyo
            sayac = 0;
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    PictureBox pctrbx = new PictureBox();
                    pctrbx.Size = new Size(pbboyut, pbboyut);
                    pctrbx.SendToBack();
                    pctrbx.Name = sayılar[sayac].ToString();
                    pctrbx.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctrbx.BorderStyle = BorderStyle.FixedSingle;
                    pctrbx.Location = new Point(j * pbboyut +boyut*100+50, i * pbboyut);
                    panel1.Controls.Add(pctrbx);
                    bospbox.Add(pctrbx);
                    sayac++;


                }
            }
        }
        int xfark, yfark, yersayısı = 0;
        void pctrbx_MouseUp(object sender, MouseEventArgs e)
        {
            sürüklenmisse = false;
            PictureBox hedef = bospbox[int.Parse(secilen.Name)];
            xfark = Math.Abs(secilen.Location.X - hedef.Location.X);
            yfark = Math.Abs(secilen.Location.Y - hedef.Location.Y);

            if (xfark < 10 && yfark < 10)
            {
                secilen.Enabled = false;
                secilen.Location = hedef.Location;
                yersayısı++;
                if (yersayısı == boyut*boyut)
                {
                    foreach (PictureBox pb in panel1.Controls)
                    {
                        pb.BorderStyle = BorderStyle.None;
                    }

                    if (MessageBox.Show("Tebrikler", "Sonuç", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (anaresimno == 8)
                        {
                            if (MessageBox.Show("Tebrikler", "Sonuç", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                panel1.Controls.Clear();
                                picturboxekle();
                                yersayısı = 0;
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            anaresimno++;
                            panel1.Controls.Clear();
                            picturboxekle();
                            yersayısı = 0;
                        }
                        

                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                secilen.Location = pcrsbxilkkonum;
            }
        }

        void pctrbx_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürüklenmisse)
            {
                secilen.Left += e.X - ilkkonumfare.X;
                secilen.Top += e.Y - ilkkonumfare.Y;
            }

        }
        bool sürüklenmisse = false;
        Point ilkkonumfare, pcrsbxilkkonum;
        PictureBox secilen;
        void pctrbx_MouseDown(object sender, MouseEventArgs e)
        {


            sürüklenmisse = true;
            secilen = sender as PictureBox;
            pcrsbxilkkonum = secilen.Location;
            ilkkonumfare = e.Location;



        }
        int anaresimno = 1;

        void resimparcala()
        {
            kodlaparcalananresim.Clear();
            Image anaresim = Image.FromFile("resimler\\manzara\\" + "" + anaresimno + ".jpg");
            Bitmap orjinalresim = new Bitmap(anaresim);
            Bitmap parcalıresim;
            Rectangle kesimalanı = new Rectangle(0, 0, anaresim.Width / boyut, anaresim.Height / boyut);
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    kesimalanı.X = j * orjinalresim.Width / boyut;
                    kesimalanı.Y = i * orjinalresim.Height / boyut;
                    parcalıresim = orjinalresim.Clone(kesimalanı, orjinalresim.PixelFormat);
                    Image kucukresim = (Image)parcalıresim;
                    kodlaparcalananresim.Add(kucukresim);
                }
            }

        }
        int boyut,pbboyut;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            boyut = comboBox1.SelectedIndex + 3;
            pbboyut = 400 / boyut;
            picturboxekle();

        }

    }
}
