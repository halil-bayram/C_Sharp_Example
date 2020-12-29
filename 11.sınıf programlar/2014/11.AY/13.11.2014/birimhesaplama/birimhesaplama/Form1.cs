using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace birimhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double üsthesaplama(int taban,int üst)
        {
            Double sonuc = 1;
            if (üst>0)
            {
                for (int i = 0; i < üst; i++)
            {
                sonuc *= taban ;
            }
            }
            if (üst<0)
            {
                for (int i = 1; i > 0; i--)
                {
                    sonuc = sonuc / taban;
                }
            }
            return sonuc;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btncevir_Click(object sender, EventArgs e)
        {
            txtsonuc.Clear();
            txtsonuc.Text = (üsthesaplama(int.Parse(txttaban.Text),int.Parse(txtüst.Text))).ToString();
        }
    }
}
