using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace turnıvaeşleşmesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        List<string> isimler = new List<string>() {"Halil","Hüseyin","Veli","Fatih","Burak","İsamil","Ayşegül","Sibel","Aleyna","Hacer","Aslı","Yunus","Murat","Emre","Mahmut","Hamza" };
        List<string> kaybeden = new List<string>();
        List<int> sayılar = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                kariştir();
                for (int j = 0; j < isimler.Count; j+=2)
                {
                    if (i==0)
                    {
                        lsttureşleşme.Items.Add(isimler[sayılar[j]]+"       "+isimler[sayılar[j+1]]);
                    }
                    else if (i==1)
                    {
                        lstceyrekfinal.Items.Add(isimler[sayılar[j]] + "       " + isimler[sayılar[j + 1]]);
                    }
                    else if (i==2)
                    {
                       lstyarıfinal.Items.Add(isimler[sayılar[j]] + "       " + isimler[sayılar[j + 1]]);
                    }
                    else if (i==3)
                    {
                       lstfinal.Items.Add(isimler[sayılar[j]] + "       " + isimler[sayılar[j + 1]]);
                    }
                    else if (i==4)
                    {
                       label5.Text=(isimler[0]);
                    }
                    int kaybedenkişi = rnd.Next(0, 2);
                    if (kaybedenkişi==0)
                    {
                        kaybeden.Add(isimler[sayılar[j]]);
                    }
                    if (kaybedenkişi == 1)
                    {
                        kaybeden.Add(isimler[sayılar[j+1]]);
                    }
                }
                eleme();
            }
        }
        void kariştir()
        {
            int sayı;
            sayılar.Clear();
            do
            {
                sayı = rnd.Next(0,isimler.Count);
                if (sayılar.IndexOf(sayı)==-1)
                {
                    sayılar.Add(sayı);
                }
            } while (isimler.Count!=sayılar.Count);
        }
        void eleme()
        {
            for (int i = 0; i < kaybeden.Count; i++)
            {
                isimler.Remove(kaybeden[i]);
            }
            kaybeden.Clear();
        }

    }
}
