using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parcaal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string parcaAl(string metin, int karakter, bool bastanmı)
        {
            metin = txtgirilenmetin.Text;
            karakter = int.Parse(txtkaraktesayısı.Text);
            if (bastanmı == true)
            {
                for (int i = 0; i < karakter; i++)
                {
                    txtparcalımetin.Text += metin[i].ToString();
                }
            }
            if (bastanmı == false)
            {
                for (int i = metin.Length - karakter; i < metin.Length; i++)
                {
                    txtparcalımetin.Text += metin[i].ToString();
                }
            }
            return metin;
        }
        string parcaAl(string metin, int baslangıc, int karakter)
        {
            metin = txtgirilenmetin.Text;
            karakter = int.Parse(txtkaraktesayısı.Text);
            baslangıc = int.Parse(txtbaslangıcsayısı.Text);
            if (rdbortadan.Checked)
            {
                for (int i = baslangıc-1; i < karakter + baslangıc-1; i++)
                {
                    txtparcalımetin.Text += metin[i];
                }
            }
            return metin;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            if (txtgirilenmetin.Text.Length == 0)
            {
                rdbbastan.Enabled = false;
                rdbortadan.Enabled = false;
                rdbsondan.Enabled = false;
            }
            if (rdbbastan.Checked)
            {
                txtbaslangıcsayısı.Enabled = false;
            }
        }
        private void btnparcala_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtparcalımetin.Clear();
            rdbbastan.Enabled = true;
            rdbsondan.Enabled = true;
            rdbortadan.Enabled = true;
            if (rdbbastan.Checked)
            {
                parcaAl(txtgirilenmetin.Text, int.Parse(txtkaraktesayısı.Text), true);
            }
            else if (rdbsondan.Checked)
            {
                parcaAl(txtgirilenmetin.Text, int.Parse(txtkaraktesayısı.Text), false);
            }
            else if (rdbortadan.Checked)
            {
                parcaAl(txtgirilenmetin.Text, int.Parse(txtbaslangıcsayısı.Text), int.Parse(txtkaraktesayısı.Text));
            }
        }
        private void rdbbastan_CheckedChanged(object sender, EventArgs e)
        {
            txtbaslangıcsayısı.Clear();
            txtbaslangıcsayısı.Enabled = false;
            rdbortadan.Enabled = false;
            rdbsondan.Enabled = false;
            rdbbastan.Enabled = true;
        }
        private void rdbsondan_CheckedChanged(object sender, EventArgs e)
        {
            rdbsondan.Enabled = true;
            txtbaslangıcsayısı.Clear();
            txtbaslangıcsayısı.Enabled = false;
            rdbortadan.Enabled = false;
            rdbbastan.Enabled = false;
        }
        private void rdbortadan_CheckedChanged(object sender, EventArgs e)
        {
            rdbbastan.Enabled = false;
            rdbortadan.Enabled = true;
            txtbaslangıcsayısı.Enabled = true;
            rdbsondan.Enabled = false;
        }
        private void txtgirilenmetin_TextChanged(object sender, EventArgs e)
        {
            rdbbastan.Enabled = true;
            rdbortadan.Enabled = true;
            rdbsondan.Enabled = true;
        }
    }
}
