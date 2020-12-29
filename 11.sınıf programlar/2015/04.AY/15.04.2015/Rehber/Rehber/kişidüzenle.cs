using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Rehber
{
    public partial class kişidüzenle : Form
    {
        public kişidüzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=localhost;Initial Catalog=kisiler;Integrated Security=True");
        DataSet ds = new DataSet();
        string sorgu, yol, hedef = "\\resimler\\";
        bool resimsecildimi = false;
        void eklesilgüncellle()
        {
            SqlCommand cmd = new SqlCommand(sorgu, baglantı);
            baglantı.Open();
            cmd.ExecuteNonQuery();
            baglantı.Close();
        }
        void temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txtnumara.Text = "";
        }
        private void btndegiştir_Click(object sender, EventArgs e)
        {
            OpenFileDialog sec = new OpenFileDialog();
            if (sec.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(sec.FileName);
                yol = sec.FileName;
                hedef = "resimler\\" + txtad.Text + "" + txtsoyad.Text + ".png";
                resimsecildimi = true;
            }
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Refresh(); 
            if (resimsecildimi)
            {
               
                if (File.Exists(hedef))
                {
                    File.Delete(hedef);
                }
                hedef = "resimler\\" + txtad.Text + "" + txtsoyad.Text + ".png";
                File.Copy(yol, Application.StartupPath + "\\" + hedef, true);
            }
            else
            {
                hedef = "resimler\\" + txtad.Text + "" + txtsoyad.Text + ".png";
                File.Copy(yol, Application.StartupPath + "\\" + hedef, true);
                File.Delete(yol);
            }
            if (btnkaydet.Text == "KAYDET")
            {
                File.Copy(yol, hedef, true);
                sorgu = "insert into rehber (ad,soyad,numara,reesimyolu) values('" + txtad.Text + "','" + txtsoyad.Text + "','" + txtnumara.Text + "','" + hedef + "')";
                SqlDataAdapter verial = new SqlDataAdapter(sorgu, baglantı);
                verial.Fill(ds, "ekle");
                temizle();
            }
            else if (btnkaydet.Text == "GÜNCELLE")
            {
                File.Copy(yol, hedef, true);
                sorgu = "update rehber set  ad='" + txtad.Text + "',soyad='" + txtsoyad.Text + "',numara='" + txtnumara.Text + "',reesimyolu='" + hedef + "' where kisiid=" + Form1.id + "";
                eklesilgüncellle();
                temizle();
            }
        }
        private void kişidüzenle_Load(object sender, EventArgs e)
        {
            hedef = yol;
            if (Form1.butuonadı == "KAYDET")
            {
                btnkaydet.Text = "KAYDET";
                btnsil.Visible = false;
                txtad.Text = "";
                txtsoyad.Text = "";
                txtnumara.Text = "";
            }
            if (Form1.butuonadı == "GÜNCELLE")
            {
                btnkaydet.Text = "GÜNCELLE";
                btnsil.Visible = true;
                txtad.Text = Form1.ds.Tables["kişiler"].Rows[Form1.index][1].ToString();
                txtsoyad.Text = Form1.ds.Tables["kişiler"].Rows[Form1.index][2].ToString();
                txtnumara.Text = Form1.ds.Tables["kişiler"].Rows[Form1.index][3].ToString();
                pictureBox1.Image = Image.FromFile(Form1.ds.Tables["kişiler"].Rows[Form1.index][4].ToString());
            }
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            hedef = "resimler\\" + txtad.Text + "" + txtsoyad.Text + ".png";
            sorgu = "delete from rehber where kisiid=" + Form1.ds.Tables["kişiler"].Rows[Form1.index][0] + " ";
            eklesilgüncellle();
            pictureBox1.Image.Dispose();
            pictureBox1.Refresh(); 
            if (File.Exists(hedef))
            {
                File.Delete(hedef);
            }
            temizle();
            this.Hide();
        }
    }
}
