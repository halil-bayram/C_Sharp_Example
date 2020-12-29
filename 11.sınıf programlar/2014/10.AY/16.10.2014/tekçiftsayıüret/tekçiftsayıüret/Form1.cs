using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tekçiftsayıüret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> sayılar = new List<int>();
        Random rnd = new Random();
        int sayi, sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnhesap_Click(object sender, EventArgs e)
        {
            sayac = 0;
            sayılar.Clear();
            lblsonuç.Text = "";
            if (chkteksayı.Checked == true && chkçiftsayı.Checked == true)
            {
                do
                {
                    if (sayac % 2 == 0)
                    {
                        sayi = rnd.Next(0, 10);

                        if (sayılar.IndexOf(sayi) == -1 && sayi % 2 == 0)
                        {
                            sayılar.Add(sayi);
                            lblsonuç.Text += (sayılar[sayac]).ToString();
                            sayac++;
                        }

                    }
                    if (sayac % 2 == 1)
                    {

                        sayi = rnd.Next(0, 10);
                        if (sayılar.IndexOf(sayi) == -1 && sayi % 2 == 1)
                        {
                            sayılar.Add(sayi);
                            lblsonuç.Text += (sayılar[sayac]).ToString();
                            sayac++;
                        }
                    }

                } while (sayac != 6);

            }
            else if (chkteksayı.Checked == true)
            {
                do
                {
                    sayi = rnd.Next(0, 10);
                    if (sayılar.IndexOf(sayi) == -1 && sayi % 2 == 1)
                    {
                        sayılar.Add(sayi);
                        lblsonuç.Text += (sayılar[sayac]).ToString();
                        sayac++;
                    }
                } while (sayac != 3);
            }
            else if (chkçiftsayı.Checked == true)
            {
                do
                {
                    sayi = rnd.Next(0, 10);

                    if (sayılar.IndexOf(sayi) == -1 && sayi % 2 == 0)
                    {
                        sayılar.Add(sayi);
                        lblsonuç.Text += (sayılar[sayac]).ToString();
                        sayac++;
                    }
                } while (sayac != 3);
            }
        }

    }
}
