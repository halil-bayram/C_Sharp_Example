using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace randevusistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> isimler = new List<string>() {"hüseyin","aleyna","fatih","sibel","ismail","yunus" };
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime tarih = dtpgün.Value;
            DateTime mesaibaşlangıc, mesaibitiş;
            mesaibaşlangıc = new DateTime(tarih.Year, tarih.Month, tarih.Day, 8, 0, 0);
            mesaibitiş = new DateTime(tarih.Year, tarih.Month, tarih.Day, 17, 0, 0);
            for (DateTime i = mesaibaşlangıc; i < mesaibitiş; i=i.AddMinutes(15))
            {
                
                     cmbbaşlangıc.Items.Add(i.ToShortTimeString());   
                
            }
            for (int i = 0; i < 60; i+=+5)
            {
                cmbaralık.Items.Add(i+" dk");
            }
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            lxtrandevusonuc.Items.Clear();
            string[] gorusmesüresi = cmbaralık.SelectedItem.ToString().Split(' ');
            int süre = Convert.ToInt32(gorusmesüresi[0]);
            DateTime başlangıc = Convert.ToDateTime(cmbbaşlangıc.SelectedItem);
            for (int i = 0; i < isimler.Count; i++)
            {
                lxtrandevusonuc.Items.Add(isimler[i]+" "+başlangıc);
                başlangıc = başlangıc.AddMinutes(süre);
                if (başlangıc.Hour>=12&&başlangıc.Hour<13)
                {
                    başlangıc = new DateTime(başlangıc.Year, başlangıc.Month, başlangıc.Day, 13, 0, 0);
                
                }
                
            }
            
        }

    }
}
