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
    public partial class Şifremi_unuttum : Form
    {
        public Şifremi_unuttum()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ililce.accdb");
        OleDbDataAdapter verial;
        string sorgu;
        DataTable dt = new DataTable();
        private void btnşifreunuttum_Click(object sender, EventArgs e)
        {
            if (txtşifre.Text==txtşifretekrar.Text)
            {
                sorgu = "update bilgiler set şifre='" + txtşifre.Text + "' where kadi='"+txtkullanıcıadı.Text+"'";
                OleDbCommand cmd = new OleDbCommand(sorgu,baglantı);
                baglantı.Open();
                cmd.ExecuteNonQuery();
                baglantı.Close();
                this.Hide();
                programagiriş frmprogramagir = new programagiriş();
                frmprogramagir.ShowDialog();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor");
            }
       
        }

        private void txtdevam_Click(object sender, EventArgs e)
        {
            sorgu = "select gvsorusu,gvcevabı from bilgiler where kadi='" + txtkullanıcıadı.Text + "' ";
            verial = new OleDbDataAdapter(sorgu, baglantı);
            verial.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Yanlış Kullanıcı Adı");
            }
            else
            {
                txtgüvenliksorusu.Text = dt.Rows[0][0].ToString();
                groupBox2.Visible = true;
            }
        }

        private void btndevam2_Click(object sender, EventArgs e)
        {
           
            if (txtgüvenliksorusununcevabı.Text == dt.Rows[0][1].ToString())
            {
                groupBox3.Visible = true;
            } 

        }
    }
}
