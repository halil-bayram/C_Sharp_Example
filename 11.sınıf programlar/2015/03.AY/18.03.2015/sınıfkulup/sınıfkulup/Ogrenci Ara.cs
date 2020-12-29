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
    public partial class Ogrenci_Ara : Form
    {
        public Ogrenci_Ara()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=siniflisteleri.accdb");
        string sorgu;
        DataSet ds = new DataSet();
        void tablodoldur(string tabload)
        {
            OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
            if (ds.Tables.Contains(tabload))
            {
                ds.Tables.Remove(tabload);
            }
            verial.Fill(ds, tabload);
        }
        void eklesilgüncelle()
        {
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        string[] kriter ={"okulno","ad","soyad"};
        private void btnara_Click(object sender, EventArgs e)
        {
            if (cmbxaramkriteri.SelectedIndex==0)
            {
                  sorgu = "select * from ogrenciler where "+ kriter[cmbxaramkriteri.SelectedIndex]+"="+Convert.ToInt16(txtaranacak.Text)+"";
            }
            else
            {
                sorgu = "select * from ogrenciler where " + kriter[cmbxaramkriteri.SelectedIndex] + "='" + txtaranacak.Text + "'";
            }
            tablodoldur("aramasonucu");
            dataGridView1.DataSource = ds.Tables["aramasonucu"];
        }
    }
}
