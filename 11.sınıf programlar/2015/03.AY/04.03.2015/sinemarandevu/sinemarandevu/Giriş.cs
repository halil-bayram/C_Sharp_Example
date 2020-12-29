using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinemarandevu
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void btnfilmekle_Click(object sender, EventArgs e)
        {
            Form1 frmfilimkaydet = new Form1();
            frmfilimkaydet.Show();
        }

        private void btnsatış_Click(object sender, EventArgs e)
        {
            satışekranı frmsatış = new satışekranı();
            frmsatış.Show();
        }
    }
}
