using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yaşhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            string[] yaş = txtyaş.Text.ToString().Split('/');
            DateTime dtarih = new DateTime(int.Parse(yaş[2]), int.Parse(yaş[1]), int.Parse(yaş[0]));
            DateTime bugün = DateTime.Today;
            TimeSpan fark = bugün - dtarih;
            int yıl = fark.Days / 365;
            int gun = fark.Days % 365;
            if (yıl % 4 == 0)
            {
                gun -= (yıl / 4);
            }
            else
            {
                gun -= (yıl / 4);
            }
            lblsonuc.Text += yıl + " yıl " + gun + " gündür yaşıyorsunuz";
        }
        private void txtyaş_TextChanged(object sender, EventArgs e)
        {
            if (txtyaş.Text.Length == 2 || txtyaş.Text.Length == 5)
            {
                txtyaş.Text += "/";
                txtyaş.Select(txtyaş.Text.Length, 0);
            }
        }
    }
}
