using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tarihnöbetci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> günler = new List<string>() { "Monday", "Tuesdey", "Wednesday", "Thursdey", "Friday" };
        List<string> bölümgünleri = new List<string>() { "pazartesi", "salı", "çarşamba", "perşembe", "cuma" };
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            grbxsonuc.Visible = true;
            btnyenile.Visible = true;
            int sayac = 0;
            DateTime başlagıc = dtpbaşlangıc.Value;
            DateTime bitiş = dtpbitiş.Value;
            for (int i = 0; i < chkbxbölümgünleri.CheckedItems.Count; i++)
            {
                bölümgünleri.Add(günler[chkbxbölümgünleri.CheckedIndices[i]]);
            }
            for (DateTime i = başlagıc; i < bitiş; i = i.AddDays(1))
            {
                if (bölümgünleri.IndexOf(i.DayOfWeek.ToString()) != -1)
                {
                    if (lxtkişiler.Items.Count % 2 == 0)
                    {
                        lxbsonuclar.Items.Add(i.ToLongDateString() + " " + lxtkişiler.Items[sayac] + "  " + lxtkişiler.Items[sayac + 1]);
                        sayac++;
                        if (sayac >= lxtkişiler.Items.Count)
                        {
                            sayac = 0;
                        }
                    }
                    else if (lxtkişiler.Items.Count % 2 == 1)
                    {
                        if (lxtkişiler.Items.Count == sayac + 1)
                        {
                            lxbsonuclar.Items.Add(i.ToLongDateString() + " " + lxtkişiler.Items[sayac] + "  " + lxtkişiler.Items[sayac - sayac]);
                            sayac = lxtkişiler.Items.Count - (lxtkişiler.Items.Count - 1);
                        }
                        if (lxtkişiler.Items.Count != sayac + 1)
                        {
                            lxbsonuclar.Items.Add(i.ToLongDateString() + " " + lxtkişiler.Items[sayac] + "  " + lxtkişiler.Items[sayac + 1]);
                        }
                        sayac += 2;
                        if (sayac >= lxtkişiler.Items.Count)
                        {
                            sayac = 0;
                        }
                    }
                }
            }
        }

        private void btnkişiekle_Click(object sender, EventArgs e)
        {
            lxbsonuclar.Text = "";
            if (txtkişiekle.Text == "")
            {
                MessageBox.Show("Lütfen Bir İsim Giriniz!!");
                txtkişiekle.Clear();
            }
            else
            {
                lxtkişiler.Items.Add(txtkişiekle.Text);
            }

            txtkişiekle.Clear();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {

            btnhesapla.Visible = false;
            grbxisimekle.Visible = false;
            grbxsonuc.Visible = false;
            grbxtarih.Visible = false;
            btnyenile.Visible = false;
            lxtkişiler.Items.Clear();
            lxbsonuclar.Items.Clear();
            txtkişiekle.Clear();
            btnhesapla_Click(sender, e);
        }
        private void chkbxbölümgünleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            grbxisimekle.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grbxsonuc.Visible = false;
            grbxisimekle.Visible = false;
            grbxtarih.Visible = false;
            btnhesapla.Visible = false;
            btnyenile.Visible = false;
        }
        private void grbxtarih_Enter(object sender, EventArgs e)
        {
            btnhesapla.Visible = true;
        }

        private void btnkişiekleme_Click(object sender, EventArgs e)
        {
            grbxtarih.Visible = true;
        }
    }
}
