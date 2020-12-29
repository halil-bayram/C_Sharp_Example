using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sınıfkulup
{
    public partial class Ana_Menü : Form
    {
        public Ana_Menü()
        {
            InitializeComponent();
        }

        private void kulübeÖgrenciAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kulübeögrenciata klp = new Kulübeögrenciata();
            klp.MdiParent = this;
            klp.Dock = DockStyle.Fill;
            klp.Show();
        }

        private void kulüpÖğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kulüp_Ögrenci_Listesi klpö = new Kulüp_Ögrenci_Listesi();
            klpö.MdiParent = this;
            klpö.Dock = DockStyle.Fill;
            klpö.Show();
        }

        private void kulüpDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kulüp_Düzenle klpdznl = new Kulüp_Düzenle();
            klpdznl.MdiParent = this;
            klpdznl.Dock = DockStyle.Fill;
            klpdznl.Show();
        }

        private void ögrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenci_İşlemleri frmogrenciişlemleri = new Ogrenci_İşlemleri();
            frmogrenciişlemleri.Dock = DockStyle.Fill;
            frmogrenciişlemleri.MdiParent = this;
            frmogrenciişlemleri.Show();

        }

        private void ogrenciAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenci_Ara frmogrenciişlemleri = new Ogrenci_Ara();
            frmogrenciişlemleri.Dock = DockStyle.Fill;
            frmogrenciişlemleri.MdiParent = this;
            frmogrenciişlemleri.Show();
        }
    }
}
