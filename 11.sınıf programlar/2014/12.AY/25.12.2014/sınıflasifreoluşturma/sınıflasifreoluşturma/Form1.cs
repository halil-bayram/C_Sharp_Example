using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sınıflasifreoluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnoluştur_Click(object sender, EventArgs e)
        {
            sıfreolustur oluşturulacak = new sıfreolustur();
            List<string> gelenşifre = new List<string>();
            int şifreuzunlugu;
            şifreuzunlugu = int.Parse(txtşifreuzunlugu.Text);
            string netür;
            if (rdbharf.Checked)
            {
                netür = "Harf";
                gelenşifre=oluşturulacak.olusturma(şifreuzunlugu, netür, true);
                for (int i = 0; i < gelenşifre.Count; i++)
                {
                    txtsonuc.Text += gelenşifre[i];
                }
            }
            else if (rdbrakam.Checked)
            {
                netür = "Rakam";
                gelenşifre=oluşturulacak.olusturma(şifreuzunlugu, netür, true);
                for (int i = 0; i < gelenşifre.Count; i++)
                {
                    txtsonuc.Text = gelenşifre[i];
                }
            }
            else if (rdbkarışık.Checked)
            {
                netür = "Karışık";
                if (chkbxözelkarakter.Checked)
                {
                    gelenşifre=oluşturulacak.olusturma(şifreuzunlugu, netür, true);
                    for (int i = 0; i < gelenşifre.Count; i++)
                    {
                        txtsonuc.Text = gelenşifre[i];
                    }
                }
                else
                {
                    gelenşifre=oluşturulacak.olusturma(şifreuzunlugu, netür, false);
                    for (int i = 0; i < gelenşifre.Count; i++)
                    {
                        txtsonuc.Text = gelenşifre[i];
                    }
                }
            }
            
        }
    }
}
