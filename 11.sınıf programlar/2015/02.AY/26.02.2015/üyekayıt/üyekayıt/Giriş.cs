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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ililce.accdb");
        OleDbDataAdapter verial;
        string sorgu;
        private void btngiriş_Click(object sender, EventArgs e)
        {
            sorgu = "select kadi, şifre from bilgiler where kadi='"+txtkullanıcıgiriş.Text+"' and şifre='"+txtşifregiriş.Text+"'";
            verial = new OleDbDataAdapter(sorgu, baglantı);
            DataTable dt = new DataTable();
            verial.Fill(dt);
            if (dt.Rows.Count==0)
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
            else
            {
                this.Hide();
                programagiriş frmgirildi = new programagiriş();
                frmgirildi.ShowDialog(); 
            }
          }
        private void lnklblüyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frmüyeol=new Form1();
            frmüyeol.ShowDialog();
        }
        private void lklblşifreunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şifremi_unuttum frmşifremiunuttum = new Şifremi_unuttum();
            frmşifremiunuttum.ShowDialog();

        }
            
                
            
        
    }
}
