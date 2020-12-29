using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sınıfkulup
{
    public partial class Kulüp_Düzenle : Form
    {
        public Kulüp_Düzenle()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=siniflisteleri.accdb");
        string sorgu;
        DataSet ds = new DataSet();
        void eklesilgüncelle()
        {
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        void listeişlem()
        {
            sorgu = "select * from kulupler";
            tablodoldur("kulupler");
            for (int i = 0; i < ds.Tables["kulupler"].Rows.Count; i++)
            {
                lstbxkulüp.Items.Add(ds.Tables["kulupler"].Rows[i][1].ToString());
            }
        }
        void tablodoldur(string tabload)
        {
            OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
            if (ds.Tables.Contains(tabload))
            {
                ds.Tables.Remove(tabload);
            }
            verial.Fill(ds, tabload);
        }
        private void rdbkulüpdüzenle_CheckedChanged(object sender, EventArgs e)
        {
            txtkulüp.Visible = true;
        }

        private void btnnayla_Click(object sender, EventArgs e)
        {
          
            if (rdbyenikulüpdüzenle.Checked)
            {
                sorgu = "insert into kulupler (kulupadi) values ('" + txtkulüp.Text + "')";
                eklesilgüncelle();
                lstbxkulüp.Items.Clear();
                txtkulüp.Text = "";
                listeişlem();
                
            }
            else if (rdbdüzenle.Checked)
            {
               
                sorgu = "update kulupler set kulupadi='" + txtkulüp.Text + "' where kulupid=" + Convert.ToInt16(ds.Tables["kulupler"].Rows[lstbxkulüp.SelectedIndex][0].ToString()) + "";
                eklesilgüncelle();
                lstbxkulüp.Items.Clear();
                txtkulüp.Text = "";
                 listeişlem();
            }

            else if (rdbsil.Checked)
            {

                sorgu = "delete from kulupler where kulupid=" + ds.Tables["kulupler"].Rows[lstbxkulüp.SelectedIndex][0]+"";
                eklesilgüncelle();
                sorgu = "update ogrenciler set kulupid=null where kulupid=" + ds.Tables["kulupler"].Rows[lstbxkulüp.SelectedIndex][0] + " ";
                eklesilgüncelle();
                lstbxkulüp.Items.Clear();
                txtkulüp.Text = "";
                listeişlem();

                

            }
        }
        private void rdbdüzenle_CheckedChanged(object sender, EventArgs e)
        {
            lstbxkulüp.Items.Clear();
            txtkulüp.Visible = true;
            sorgu = "select * from kulupler";
            tablodoldur("kulupler");
            for (int i = 0; i < ds.Tables["kulupler"].Rows.Count; i++)
            {
                lstbxkulüp.Items.Add(ds.Tables["kulupler"].Rows[i][1].ToString());
            }
        }
        private void lstbxkulüp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkulüp.Text = lstbxkulüp.SelectedItem.ToString();
        }

        private void rdbsil_CheckedChanged(object sender, EventArgs e)
        {

            lstbxkulüp.Items.Clear();
            sorgu = "select * from kulupler";
            tablodoldur("kulupler");
            for (int i = 0; i < ds.Tables["kulupler"].Rows.Count; i++)
            {
                lstbxkulüp.Items.Add(ds.Tables["kulupler"].Rows[i][1].ToString());
            }
        }

        private void Kulüp_Düzenle_Load(object sender, EventArgs e)
        {
            listeişlem();
        }

    }
}
