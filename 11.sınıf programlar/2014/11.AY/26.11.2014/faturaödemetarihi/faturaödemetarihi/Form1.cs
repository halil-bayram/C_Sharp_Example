using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace faturaödemetarihi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            lblbaşlangıc.Text = "İlk Ödeme Tarihi: ";
            lblbitiştarihi.Text = "Son Ödeme Tarihi: ";
            DateTime gün=dtptarih.Value;
            DateTime başlangıctarih, bitiştarih;
            başlangıctarih = gün.AddDays(7);
            if (başlangıctarih.DayOfWeek.ToString() == "Saturday" )
            {
                başlangıctarih=başlangıctarih.AddDays(2);
            }
            if (başlangıctarih.DayOfWeek.ToString() == "Sunday")
            {
                başlangıctarih=başlangıctarih.AddDays(1);
                
            }
            lblbaşlangıc.Text += başlangıctarih;
            bitiştarih = başlangıctarih.AddDays(10);
            if (bitiştarih.DayOfWeek.ToString() == "Saturday")
            {
                bitiştarih=bitiştarih.AddDays(2);

            }
            if (bitiştarih.DayOfWeek.ToString() == "Sunday")
            {
                bitiştarih = bitiştarih.AddDays(1);
            }
            lblbitiştarihi.Text += bitiştarih;
           
        }

        
    }
}
