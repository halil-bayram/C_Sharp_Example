using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace sinemarandevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sinemabilgiler.accdb");
        OleDbDataAdapter verial;
        DataSet ds = new DataSet();
        string sorgu,afişyolu;
        private void Form1_Load(object sender, EventArgs e)
        {

            sorgu = "select * from turler";
            verial = new OleDbDataAdapter(sorgu, baglantı);
            verial.Fill(ds, "türler");
            for (int i = 0; i < ds.Tables["türler"].Rows.Count; i++)
            {
                cmbturler.Items.Add(ds.Tables["türler"].Rows[i][1].ToString());
            }
            sorgu = "select * from salon";
            verial = new OleDbDataAdapter(sorgu, baglantı);
            verial.Fill(ds, "salonlar");
            for (int i = 0; i < ds.Tables["salonlar"].Rows.Count; i++)
            {
                cmbsalonsecimi.Items.Add(ds.Tables["salonlar"].Rows[i][1].ToString());
            }

        }
        string seanslar="";
        private void btnekle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstseanslar.CheckedItems.Count; i++)
			{
			 seanslar+=chklstseanslar.CheckedItems[i].ToString()+"/";
			}
            sorgu = "insert into filimler(adı,yönetmen,tür,süre,konu,afisyolu,saloid,seanslar) values ('" 
                + txtfilimadı.Text + "','" 
                + txtyönetmen.Text + "','"
                +(cmbturler.SelectedIndex+1)+"'," 
                + txtsüre.Text + ",'" 
                + txtkonu.Text + "','" 
                + afişyolu + "','"+(cmbsalonsecimi.SelectedIndex+1)+"','"+seanslar+"')";
            OleDbCommand cmd = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            cmd.ExecuteNonQuery();
            baglantı.Close();
            if (File.Exists(afişyolu))
            {
                MessageBox.Show("Lütfen Farklı Bir Film Adı Giriniz");
            }
            else
            { 
                File.Copy(resimsec.FileName, afişyolu);
            }
        }
        OpenFileDialog resimsec = new OpenFileDialog();
        private void btngöster_Click(object sender, EventArgs e)
        {
            resimsec.Title = "resim secini";
            resimsec.Filter = "resim dosyası|*.jpg|resim dosyası|*.png";
            if (resimsec.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(resimsec.FileName);
                afişyolu = "afişler\\" + txtfilimadı.Text + ".jpg";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            satışekranı frmsatışekranı = new satışekranı();
            frmsatışekranı.ShowDialog();
        }

        private void cmbsalonsecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dtbaşlangıc = new DateTime(2014,1,1,10,0,0);
            DateTime dtbitiş = new DateTime(2014,1,1,22,0,0);
            for (DateTime i = dtbaşlangıc; i < dtbitiş; i=i.AddMinutes(15))
            {
                chklstseanslar.Items.Add(i.ToShortTimeString());
            }
        }
    }
}
