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
    public partial class Ogrenci_İşlemleri : Form
    {
        public Ogrenci_İşlemleri()
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

        private void Ogrenci_İşlemleri_Load(object sender, EventArgs e)
        {
            sorgu = "select distinct okulturu from  ogrenciler";
            tablodoldur("okulturu");
            for (int i = 0; i < ds.Tables["okulturu"].Rows.Count; i++)
            {
                cmbokultürü.Items.Add(ds.Tables["okulturu"].Rows[i][0].ToString());
                cmbx2okultürü.Items.Add(ds.Tables["okulturu"].Rows[i][0].ToString());
                
            }

        }
        List<int> ogrencino = new List<int>();
        private void cmbokultürü_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbsınıf.Items.Clear();
            sorgu = "select distinct sınıf from ogrenciler where okulturu='" + cmbokultürü.SelectedItem + "'";
            tablodoldur("sınıflar");
            for (int i = 0; i < ds.Tables["sınıflar"].Rows.Count; i++)
            {
               cmbsınıf.Items.Add(ds.Tables["sınıflar"].Rows[i][0].ToString());
            }
            sorgu = "select okulno from ogrenciler where okulturu='" + cmbokultürü.SelectedItem + "'";
            tablodoldur("okulno");
            for (int i = 0; i < ds.Tables["okulno"].Rows.Count; i++)
            {
                ogrencino.Add(Convert.ToInt16(ds.Tables["okulno"].Rows[i][0].ToString()));
            }
            for (int i = 1; i <= 1000; i++)
            {
                if (ogrencino.IndexOf(i)==-1)
                {
                    cmbokulno.Items.Add(i);
                }
                
            }
        }
        string cinsiyet;
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            sorgu="select sira from ogrenciler";
            tablodoldur("sıra");
            int sira=Convert.ToInt16(ds.Tables["sıra"].Rows[ds.Tables["sıra"].Rows.Count-1][0])+1;
            sorgu = "insert into ogrenciler(sira,okulno,ad,soyad,okulturu,sınıf,cinsiyet) values ("
                +sira+",'"
                +cmbokulno.SelectedItem+"','"
                +txtadı.Text.ToUpper()+"','"
                +txtsoyadı.Text.ToUpper()+"','"
                +cmbokultürü.SelectedItem+"','"
                +cmbsınıf.SelectedItem+"','"
                +cinsiyet+"')";
            eklesilgüncelle();
        }

        private void rdbkız_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kız";
        }

        private void rdberkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void cmbx2okultürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            combx2sınıf.Items.Clear();
            sorgu = "select distinct sınıf from ogrenciler where okulturu='" + cmbx2okultürü.SelectedItem + "'";
            tablodoldur("sınıflar");
            for (int i = 0; i < ds.Tables["sınıflar"].Rows.Count; i++)
            {
                combx2sınıf.Items.Add(ds.Tables["sınıflar"].Rows[i][0].ToString());
            }
           

        }

        private void combx2sınıf_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorgu = "select * from ogrenciler where okulturu='" + cmbx2okultürü.SelectedItem + "'and sınıf='"+combx2sınıf.SelectedItem+"'";
            tablodoldur("görüntüle");
            dataGridView1.DataSource = ds.Tables["görüntüle"];

        }

        string cinsiyet2;
        int sira,index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbokulno.Items.Clear();
            index = dataGridView1.CurrentRow.Index;
            sira=Convert.ToInt16(ds.Tables["görüntüle"].Rows[index][0].ToString());
            cmbokultürü.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbsınıf.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbokulno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtadı.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsoyadı.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cinsiyet2=dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (cinsiyet2=="Kız")
            {
                rdbkız.Checked=true;
            }
            else
            {
                rdbkız.Checked = false;
            }
            if (cinsiyet2=="Erkek")
            {
                rdberkek.Checked = true;
            }
            else
            {
                rdberkek.Checked = false;
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            if (cinsiyet2 == "Kız")
            {
                rdbkız.Checked = true;
            }
            else
            {
                rdbkız.Checked = false;
            }
            sorgu = "update ogrenciler set okulno="
                +cmbokulno.Text+", ad='"
                +txtadı.Text+"', soyad='"
                +txtsoyadı.Text+"', okulturu='"
                +cmbokultürü.Text+"', sınıf='"+cmbsınıf.Text+"', cinsiyet='"+cinsiyet2+"' where sira="+sira+"";
            eklesilgüncelle();
            sorgu = "select * from ogrenciler where okulturu='" + cmbx2okultürü.SelectedItem + "'and sınıf='" + combx2sınıf.SelectedItem + "'";
            tablodoldur("görüntüle");
            dataGridView1.DataSource = ds.Tables["görüntüle"];

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            sorgu = "delete from ogrenciler where sira="+sira+"";
            eklesilgüncelle();
            sorgu = "select * from ogrenciler where okulturu='" + cmbx2okultürü.SelectedItem + "'and sınıf='" + combx2sınıf.SelectedItem + "'";
            tablodoldur("görüntüle");
            dataGridView1.DataSource = ds.Tables["görüntüle"];
        }

    }
}
