using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace üyekayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ililce.accdb");
        OleDbDataAdapter verial;
        string sorgu,cinsiyet;
        int plaka;

        void temizlik()
        {
            txtadı.Text = "";
            txtgüvenliksorusucevabı.Text = "";
            txtkullanıcıadı.Text = "";
            txtsifre.Text = "";
            txtsoyadı.Text = "";
            txtşifretekrar.Text = "";
            txtkullanıcıadı.BackColor = Color.White;
            txtsifre.BackColor = Color.White;
            txtşifretekrar.BackColor = Color.White;
            
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (!rdberkek.Checked&&!rdbkız.Checked)
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurunuz!");
            }
            else
            {
                if (rdberkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (rdbkız.Checked)
            {
                cinsiyet = "Kız";
            }  
                sorgu = "insert into bilgiler values('" + txtkullanıcıadı.Text + "','"
                + txtsifre.Text + "','"
                + txtadı.Text + "','"
                + txtsoyadı.Text + "','"
                + dtpdtarih.Value.ToShortDateString() + "','"
                + cinsiyet + "','"
                + cbil.SelectedItem.ToString() + "','"
                + cbilce.SelectedItem.ToString() + "','"
                + cbgüvenliksorusu.SelectedItem.ToString() + "','"
                + txtgüvenliksorusucevabı.Text + "')";
                OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
                baglantı.Open();
                komut.ExecuteNonQuery();
                baglantı.Close();
            }
            temizlik();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sorgu = "select *from iller";
            verial = new OleDbDataAdapter(sorgu, baglantı);
            DataTable dt=new DataTable();
            verial.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
			{
                cbil.Items.Add(dt.Rows[i][1]);
			}
        }

        private void cbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbilce.Items.Clear();
            plaka=cbil.SelectedIndex+1;
            sorgu = "select *from ilceler where sehir="+plaka+"";
            verial = new OleDbDataAdapter(sorgu, baglantı);
            DataTable dt = new DataTable();
            verial.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbilce.Items.Add(dt.Rows[i][1]);
            }
        }

        private void txtadı_TextChanged(object sender, EventArgs e)
        {

            sorgu="select kadi from bilgiler ";
            verial = new OleDbDataAdapter(sorgu, baglantı);
            DataTable dt = new DataTable();
            verial.Fill(dt);
            bool renk = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString()==txtkullanıcıadı.Text)
            {
                renk = true;
               
                   
            }
               
            }
            if (renk==true)
            {
                txtkullanıcıadı.BackColor = Color.MediumVioletRed;
            }
            else
            {
                txtkullanıcıadı.BackColor = Color.GreenYellow;
            }
            if (txtsifre.Text != txtşifretekrar.Text)
            {
                MessageBox.Show("Yanlış Şifre!");
            }
            else
            {
                txtsifre.BackColor = Color.GreenYellow;
                txtşifretekrar.BackColor = Color.GreenYellow;
            }
            
        }

        private void lnklblgiriş_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Giriş frmgiriş = new Giriş();
            frmgiriş.ShowDialog();
        }


        

        
    }
}
