using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sınıflatekrarsızsayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnoluştur_Click(object sender, EventArgs e)
        {
            sayıüret üretec = new sayıüret();
            List<int> sayılarım = new List<int>();
            int küçüksayı, büyüksayı, adet,katları;
            küçüksayı = int.Parse(txtküçüksayı.Text);
            büyüksayı = int.Parse(txtbüyüksayı.Text);
            adet = int.Parse(txtadet.Text);
            katları = cbxkatları.SelectedIndex;
            sayılarım.Clear();
            listBox1.Items.Clear();
            if (!rdbçift.Checked&&!rdbtek.Checked&&cbxkatları.SelectedIndex==0)
            {
                   sayılarım = üretec.sayıuret(adet, küçüksayı, büyüksayı);
                   for (int i = 0; i < sayılarım.Count; i++)
                   {
                       listBox1.Items.Add(sayılarım[i]);
                   }
            }
            else if (rdbçift.Checked||rdbtek.Checked)
            {
                if (rdbçift.Checked)
                {
                    sayılarım = üretec.sayıuret(adet, küçüksayı, büyüksayı,false);
                    for (int i = 0; i < sayılarım.Count; i++)
                    {
                        listBox1.Items.Add(sayılarım[i]);
                    }
                }
                if (rdbtek.Checked)
                {
                    sayılarım = üretec.sayıuret(adet, küçüksayı, büyüksayı,true);
                    for (int i = 0; i < sayılarım.Count; i++)
                    {
                        listBox1.Items.Add(sayılarım[i]);
                    }
                }
            }
            else if (!rdbçift.Checked&&!rdbtek.Checked&&cbxkatları.SelectedIndex!=0)
            {
                sayılarım = üretec.sayıuret(adet, küçüksayı, büyüksayı,katları);
                for (int i = 0; i < sayılarım.Count; i++)
                {
                    listBox1.Items.Add(sayılarım[i]);
                }
            }
        }

        private void rdbçift_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbçift.Checked)
            {
                cbxkatları.SelectedIndex = 0;
            }
            
        }

        private void rdbtek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtek.Checked)
            {
                cbxkatları.SelectedIndex = 0;
            }
            
        }

        private void cbxkatları_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbçift.Checked = false;
            rdbtek.Checked = false;
        }
    }
}
