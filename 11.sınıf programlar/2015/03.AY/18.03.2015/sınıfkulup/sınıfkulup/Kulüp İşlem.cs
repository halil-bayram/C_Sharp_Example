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
    public partial class Kulübeögrenciata : Form
    {
        public Kulübeögrenciata()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=siniflisteleri.accdb");
        string sorgu;
        DataSet ds = new DataSet();
        int sayı, sayac2 = 0;
        List<int> sayılar = new List<int>();
        Random rnd = new Random();
        void eklesilgüncelle()
        {
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
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
        void tekrarsızsayı()
        {
            do
            {
                sayı = rnd.Next(0, ds.Tables["kulupler"].Rows.Count);

                if (sayılar.IndexOf(sayı) == -1)
                {
                    sayılar.Add(sayı);
                    sayac2++;
                }
            } while (sayac2 != ds.Tables["kulupler"].Rows.Count);

        }
        private void cbmokulturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmsınıf.Items.Clear();
            sorgu = "select distinct sınıf from ogrenciler where okulturu='" + cbmokulturu.SelectedItem + "'";
            tablodoldur("sınıflar");
            for (int i = 0; i < ds.Tables["sınıflar"].Rows.Count; i++)
            {
                cbmsınıf.Items.Add(ds.Tables["sınıflar"].Rows[i][0].ToString());
            }
        }

        private void cbmsınıf_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorgu = "select * from ogrenciler where okulturu='" + cbmokulturu.SelectedItem + "' and sınıf='" + cbmsınıf.SelectedItem + "'";
            tablodoldur("ogrenciler");
            dgv1.DataSource = ds.Tables["ogrenciler"];
        }
        int sayac = 0;
        private void btnkuluple_Click(object sender, EventArgs e)
        {
             sorgu = "select * from kulupler";
            tablodoldur("kulupler");
            tekrarsızsayı();
            for (int i = 0; i < ds.Tables["ogrenciler"].Rows.Count; i++)
            {
                sorgu = "update ogrenciler set kulupid=" + ds.Tables["kulupler"].Rows[sayılar[sayac]][0] + " where okulturu='" + cbmokulturu.SelectedItem + "' and sınıf='" + cbmsınıf.SelectedItem + "' and sira=" + ds.Tables["ogrenciler"].Rows[i][0] + "";
                eklesilgüncelle();
                sayac++;
                if (sayac == ds.Tables["kulupler"].Rows.Count)
                {
                    sayac = 0;
                }
            }
            sorgu = "select * from ogrenciler where okulturu='" + cbmokulturu.SelectedItem + "' and sınıf='" + cbmsınıf.SelectedItem + "'";
            tablodoldur("ogrenciler");
            dgv1.DataSource = ds.Tables["ogrenciler"];
        
        }

        private void Kulübeögrenciata_Load(object sender, EventArgs e)
        {
            sorgu = "select distinct okulturu from ogrenciler";
            tablodoldur("okulturu");
            for (int i = 0; i < ds.Tables["okulturu"].Rows.Count; i++)
            {
                cbmokulturu.Items.Add(ds.Tables["okulturu"].Rows[i][0].ToString());
            }
        }

        private void btnkulüpsıfırla_Click(object sender, EventArgs e)
        {
            sorgu = "update ogrenciler set kulupid=null";
            eklesilgüncelle();

        }

        private void btnomayan_Click(object sender, EventArgs e)
        {
            sorgu = "select * from ogrenciler where okulturu='" + cbmokulturu.SelectedItem + "' and sınıf='" + cbmsınıf.SelectedItem + "' and kulupid is null";
            tablodoldur("ogrenciler");
            dgv1.DataSource = ds.Tables["ogrenciler"];
        }
    }
}
