using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listelemesistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] bilgiler = new string[10, 9];
        int sayac = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbsınıf.Items.Add("");
            cmbtakım.Items.Add("");
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            bilgiler[sayac, 0] = txtokulno.Text;
            bilgiler[sayac, 1] = txtadı.Text;
            bilgiler[sayac, 2] = cmbsınıf.SelectedItem.ToString();
            bilgiler[sayac, 3] = cmbtakım.SelectedItem.ToString();
            bilgiler[sayac, 4] = txtyazılı.Text;
            bilgiler[sayac, 5] = txtyazılı2.Text;
            bilgiler[sayac, 6] = txtsözlü.Text;
            bilgiler[sayac, 8] = ((Convert.ToInt32(bilgiler[sayac, 4]) +Convert.ToInt32( bilgiler[sayac, 5]) + Convert.ToInt32(bilgiler[sayac, 6])/3).ToString());
                sayac++;
            if (sayac==10)
            {
                sayac = 0;
                grbveriler.Visible = false;
            }
            txtokulno.Text="";
             txtadı.Text="";
             txtyazılı.Text="";
             txtyazılı2.Text="";
             txtsözlü.Text = "";
             cmbsınıf.SelectedIndex = 29;
             cmbtakım.SelectedIndex = 5;
        }
 private void cmblistetürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmblistetürü.SelectedItem.ToString()=="NOTA GÖRE")
            {
                grbsınıf.Enabled = false;
                grptakımlar.Enabled = false;
                grpnotagöre.Enabled = true;
            }
             if (cmblistetürü.SelectedItem.ToString() == "SINIFA GÖRE")
            {
                grpnotagöre.Enabled = false;
                grptakımlar.Enabled = false;
                grbsınıf.Enabled = true;
            }
             if (cmblistetürü.SelectedItem.ToString() == "TAKIMA GÖRE")
            {
                grpnotagöre.Enabled = false;
                grbsınıf.Enabled = false;
                grptakımlar.Enabled = true;
            }
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            lstsonuc.Items.Clear();
            if (grpnotagöre.Enabled==true&&rdbkalanlar.Checked)
            {
                for (int i = 0; i < bilgiler.GetLength(0); i++)
                {
                    if (bilgiler[i,8]!=null)
                    {
                        if (Convert.ToInt32(bilgiler[i,8])<50)
                    {
                        lstsonuc.Items.Add(bilgiler[i,0]+bilgiler[i,1]+bilgiler[i,8]);
                    }
                    }
                }
            }
            if (grpnotagöre.Enabled==true&&rdbgeçenler.Checked)
            {
                for (int i = 0; i < bilgiler.GetLength(0); i++)
                {
                    if (bilgiler[i,8]!=null)
                    {
                        if (Convert.ToInt32(bilgiler[i,8])>50)
                    {
                        lstsonuc.Items.Add(bilgiler[i,0]+bilgiler[i,1]+bilgiler[i,8]);
                    }
                    }
                }
            }
            if (grpnotagöre.Enabled == true && rdbtümü.Checked)
            {
                for (int i = 0; i < bilgiler.GetLength(0); i++)
                {
                    if (bilgiler[i, 8] != null)
                    {
                            lstsonuc.Items.Add(bilgiler[i, 0] + bilgiler[i, 1] + bilgiler[i, 8]);
                    }
                }
            }
            if (grptakımlar.Enabled==true)
            {
                for (int i = 0; i < bilgiler.GetLength(0); i++)
                {
                    if (bilgiler[i,3]!=null)
                    {
                        if (chkbgs.Checked&&bilgiler[i,3]=="GALATASARAY")
                    {
                        lstsonuc.Items.Add(bilgiler[i,1]+bilgiler[i,3]);
                    }
                        if (chkfb.Checked && bilgiler[i, 3] == "FENERBAHÇE")
                        {
                            lstsonuc.Items.Add(bilgiler[i, 1] + bilgiler[i, 3]);
                        }
                        if (chktrab.Checked && bilgiler[i, 3] == "TRABZON")
                        {
                            lstsonuc.Items.Add(bilgiler[i, 1] + bilgiler[i, 3]);
                        }
                        if (chkbes.Checked && bilgiler[i, 3] == "BEŞİKTAŞ")
                        {
                            lstsonuc.Items.Add(bilgiler[i, 1] + bilgiler[i, 3]);
                        }
                        if (chkdiger.Checked && bilgiler[i, 3] == "DİGER")
                        {
                            lstsonuc.Items.Add(bilgiler[i, 1] + bilgiler[i, 3]);
                        }
                    }
                }
            }
            if (grbsınıf.Enabled==true)
            {
                for (int i = 0; i < bilgiler.GetLength(0); i++)
                {
                    if (bilgiler[i, 8] != null)
                    {
                        if (bilgiler[i,2]==cmbverisınıf.SelectedItem.ToString())
                        {
                            lstsonuc.Items.Add(bilgiler[i, 1] + bilgiler[i, 2]);
                        }
                    } 
                }
            }
        }
    }
}
