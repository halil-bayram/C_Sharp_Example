using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hobisecme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> kızhobileri = new List<string>() { "barbi giydirme", "sek sek", "ip atlama", "voleybol", "alış veriş" };
        List<string> erkekhobileri = new List<string>() { "pes", "ben ten", "counter", "futbol", "balkon seyir" };
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnhepsec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hobiler.Items.Count; i++)
            {
                hobiler.SetItemChecked(i, true);
            }
        }
        private void btnhepkaldır_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hobiler.Items.Count; i++)
            {
                hobiler.SetItemChecked(i, false);
            }
        }
        private void rdberkek_CheckedChanged(object sender, EventArgs e)
        {
            btnhobiekle.Enabled = true;
            hobiler.Items.Clear();
            listBox1.Items.Clear();
            txbhobi.Text = "";
            for (int i = 0; i < erkekhobileri.Count; i++)
            {
                hobiler.Items.Add(erkekhobileri[i]);
               
            }
        }
        private void rdbkız_CheckedChanged(object sender, EventArgs e)
        {
            btnhobiekle.Enabled = true;
            hobiler.Items.Clear();
            listBox1.Items.Clear();
            txbhobi.Text = "";
            for (int i = 0; i < kızhobileri.Count; i++)
            {
                hobiler.Items.Add(kızhobileri[i]);
            }
        }
        private void btnhobiekle_Click(object sender, EventArgs e)
        {
            txbhobi.Text = "";
            hobiler.Items.Add(txbhobi.Text);
            
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            btnhobiekle.Enabled = false;
            int sayac=0;
            do
            {
                for (int i = 0; i < hobiler.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(hobiler.CheckedItems[i]);
                
            }

                hobiler.Items.Remove(hobiler.CheckedItems[sayac]);
            sayac++;
            } while (sayac==erkekhobileri.Count);
            

        }
        private void hobiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbhobi_TextChanged(object sender, EventArgs e)
        {

        }









    }
}
