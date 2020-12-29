using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sayılarlaoyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1, sayı2, büyüksayı, sayac = 0, bölensayı, küçüksayı;
        bool asalmi = true;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbtercih_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstsayılar.Items.Clear();
            sayı1 = Convert.ToInt32(txtbsayı1.Text);
            sayı2 = Convert.ToInt32(txtbsayı2.Text);

            if (sayı1 > sayı2)
            {
                büyüksayı = sayı1;
                küçüksayı = sayı2;

            }
            else
            {
                büyüksayı = sayı2;
                küçüksayı = sayı1;
            }

            if (cmbtercih.SelectedIndex == 1)
            {
                sayac = büyüksayı;
                do
                {
                    if (sayac % sayı1 == 0 && sayac % sayı2 == 0)
                    {
                        lstsayılar.Items.Add(sayac);

                        break;
                    }

                    sayac++;
                } while (true);
            }

            if (cmbtercih.SelectedIndex == 0)
            {
                for (int i = 1; i < büyüksayı; i++)
                {
                    if (sayı1 % i == 0 && sayı2 % i == 0)
                    {
                        bölensayı = i;
                    }
                }
                lstsayılar.Items.Add(bölensayı);
            }
            if (cmbtercih.SelectedIndex == 2)
            {
                for (int i = küçüksayı; i < büyüksayı; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            asalmi = false;
                            break;
                        }
                    }
                    if (asalmi)
                    {
                        lstsayılar.Items.Add(i);
                    }
                    asalmi = true;
                }

            }

            if (cmbtercih.SelectedIndex == 3)
            {
                
                for (int i = küçüksayı; i < büyüksayı; i++)
                {
                    int ters = 0;
                    int ters2 = 0;
                    int index = i;

                    while (index > 0) // sayının tersini buluyoruz
                    {
                        ters2 = index % 10;
                        index /= 10;
                        ters = ters * 10 + ters2;
                    }
                    if (i == ters)
                        lstsayılar.Items.Add(i.ToString());
                }
            }

            if (cmbtercih.SelectedIndex == 4)
            {
                int toplam = 0;
            
            for (int i = küçüksayı; i < büyüksayı; i++)
            {
                toplam = 0;
                for (int y = 1; y < i; y++)
                {
                    if (i%y==0)
                    {
                        toplam +=y;
                    }
                }
                if (toplam==i)
                {
                   lstsayılar.Items.Add(i.ToString());
                }
            }

            
            }

        }

       


    }
}
