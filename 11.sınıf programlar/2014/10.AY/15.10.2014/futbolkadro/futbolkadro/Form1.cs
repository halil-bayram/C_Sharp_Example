using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace futbolkadro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnilkbes_Click(object sender, EventArgs e)
        {
            if (lsbkadro.SelectedItems.Count > 5 || lsbkadro.SelectedItems.Count + lsbasılkadro.Items.Count > 5)
            {
                MessageBox.Show("5 tane oyuncu sece bilirsiniz!!!");
            }
            else
            {
                for (int i = 0; i < lsbkadro.SelectedItems.Count; )
                {
                    lsbasılkadro.Items.Add(lsbkadro.SelectedItems[i]);
                    lsbkadro.Items.Remove(lsbkadro.SelectedItems[i]);
                }
                if (lsbasılkadro.Items.Count == 5)
                {
                    btnilkbes.Enabled = false;
                }
            }
        }
        private void btnyedek_Click(object sender, EventArgs e)
        {
            if (lsbkadro.SelectedItems.Count > 5 || lsbkadro.SelectedItems.Count + lsbyedek.Items.Count > 5)
            {
                MessageBox.Show("5 tane oyuncu sece bilirsiniz!!!");
            }
            else
            {
                for (int i = 0; i < lsbkadro.SelectedItems.Count; )
                {
                    lsbyedek.Items.Add(lsbkadro.SelectedItems[i]);
                    lsbkadro.Items.Remove(lsbkadro.SelectedItems[i]);
                }
                if (lsbyedek.Items.Count == 5)
                {
                    btnyedek.Enabled = false;
                }
            }
        }
        private void btnilkbestencıkar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbasılkadro.SelectedItems.Count; )
            {
                lsbkadro.Items.Add(lsbasılkadro.SelectedItems[i]);
                lsbasılkadro.Items.Remove(lsbasılkadro.SelectedItems[i]);
            }
            if (lsbasılkadro.Items.Count<5)
            {
                btnilkbes.Enabled = true;
            }
        }
        private void btnyedekcıkar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbyedek.SelectedItems.Count; )
            {
                lsbkadro.Items.Add(lsbyedek.SelectedItems[i]);
                lsbyedek.Items.Remove(lsbyedek.SelectedItems[i]);
            }
            if (lsbyedek.Items.Count<5)
            {
                 btnyedek.Enabled = true;
            }
        }
        private void btnoyuncudegis_Click(object sender, EventArgs e)
        {
            if (lsbasılkadro.SelectedItems.Count==lsbyedek.SelectedItems.Count)
            {
                for (int i = 0; i < lsbyedek.SelectedItems.Count; )
            {
                lsbasılkadro.Items.Add(lsbyedek.SelectedItems[i]);
                lsbyedek.Items.Remove(lsbyedek.SelectedItems[i]);

                lsbyedek.Items.Add(lsbasılkadro.SelectedItems[i]);
                lsbasılkadro.Items.Remove(lsbasılkadro.SelectedItems[i]);
            }
            }
            else
            {
                MessageBox.Show("giren ve cıkan oyuncu sayısı birbirine eşit olmalıdır");
            }
        }
    }
}
