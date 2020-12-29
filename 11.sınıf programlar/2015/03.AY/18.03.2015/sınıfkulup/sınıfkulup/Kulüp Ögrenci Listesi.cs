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
    public partial class Kulüp_Ögrenci_Listesi : Form
    {
        public Kulüp_Ögrenci_Listesi()
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
        private void cbmkulupler_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorgu = "select * from ogrenciler where kulupid=" + Convert.ToInt16(ds.Tables["kulupler"].Rows[cbmkulupler.SelectedIndex][0]) + "";
            tablodoldur("kulupdoldur");
            dgv2.DataSource = ds.Tables["kulupdoldur"];
        }

        private void Kulüp_Ögrenci_Listesi_Load(object sender, EventArgs e)
        {
            List<int> kulupler = new List<int>();
            sorgu = "select * from kulupler";
            tablodoldur("kulupler");
            sorgu = "select kulupid from ogrenciler where kulupid is not null";
            tablodoldur("ogrenciler");
            for (int i = 0; i < ds.Tables["ogrenciler"].Rows.Count; i++)
            {
                kulupler.Add(Convert.ToInt32(ds.Tables["ogrenciler"].Rows[i][0].ToString()));
            }
            for (int i = 0; i < ds.Tables["kulupler"].Rows.Count; i++)
            {
                if (kulupler.IndexOf(Convert.ToInt16(ds.Tables["kulupler"].Rows[i][0].ToString())) == -1)
                {
                    lsbx1.Items.Add(ds.Tables["kulupler"].Rows[i][1]);
                }
                else
                {
                    cbmkulupler.Items.Add(ds.Tables["kulupler"].Rows[i][1]);
                }
            }


        }

    }
}
