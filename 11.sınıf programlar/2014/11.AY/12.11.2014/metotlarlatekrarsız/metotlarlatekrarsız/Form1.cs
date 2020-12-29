using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metotlarlatekrarsız
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        public void sayıüret()
    {
        List<int> tekrarsızSayılar = new List<int>();
        int sayı, sayac = 0;
        do
        {
            sayı = rnd.Next(1, 100);
            if (tekrarsızSayılar.IndexOf(sayı) == -1)
            {
                tekrarsızSayılar.Add(sayı);
                listBox1.Items.Add(sayı);
                sayac++;

            }
        } while (sayac < 10);
    }
        public void sayıüret(int adet, int kucuksayı, int buyuksayı)
        {
            List<int> tekrarsızSayılar = new List<int>();
            int sayı, sayac = 0;
            do
            {
                sayı = rnd.Next(kucuksayı, buyuksayı);
                if (tekrarsızSayılar.IndexOf(sayı) == -1)
                {
                    tekrarsızSayılar.Add(sayı);
                    listBox1.Items.Add(sayı);
                    sayac++;

                }
            } while (sayac < adet);
        }
        public List<int> sayıuret(int adet,int kucuksayı,int buyuksayı)
        {
            List<int> tekrarsızSayılar = new List<int>();
            int sayı,sayac=0;
            do
            {
                sayı = rnd.Next(kucuksayı,buyuksayı);
                if (tekrarsızSayılar.IndexOf(sayı)==-1)
                {
                    tekrarsızSayılar.Add(sayı);   
                    sayac++;
                }
            } while (sayac<adet);
            return tekrarsızSayılar;
        }
        public List<int> sayıuret()
        {
            List<int> tekrarsızSayılar = new List<int>();
            int sayı, sayac = 0;
            listBox1.Items.Clear();
            do
            {
                sayı = rnd.Next(1, 100);
                if (tekrarsızSayılar.IndexOf(sayı) == -1)
                {
                    tekrarsızSayılar.Add(sayı);
                    sayac++;
                }
            } while (sayac < 10);
            return tekrarsızSayılar;
        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnüret_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.TextLength==0)
            {
               sayıüret(); 
            }
            else if (textBox1.TextLength>0)
            {
               sayıüret(int.Parse(textBox1.Text),int.Parse(textBox2.Text),int.Parse(textBox3.Text));
            }
            temizle();
        }
    }
}
