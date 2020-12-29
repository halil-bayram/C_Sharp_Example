using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace raporlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=siniflisteleri.accdb");
        public static DataTable dt = new DataTable();
        string sorgu;
        public static string islem;
        private void cbsınıf_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            sorgu = "select okulno,ad,soyad,cinsiyet from ogrenciler where okulturu='" + cbokulturu.SelectedItem + "' and sınıf='" + cbsınıf.SelectedItem + "'";
            OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
            verial.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnraporal_Click(object sender, EventArgs e)
        {
            islem = btnraporal.Text;
            rapor frmrapor = new rapor();
            frmrapor.Show();
        }
        int ogrno;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ogrno =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btnbelge_Click(object sender, EventArgs e)
        {
            dt.Clear();
            islem = btnbelge.Text;
            sorgu = "select okulno,ad,soyad,okulturu,sınıf from ogrenciler where okulturu='" + cbokulturu.SelectedItem + "' and sınıf='" + cbsınıf.SelectedItem + "' and okulno="+ogrno+"";
            OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
            verial.Fill(dt);
            dataGridView1.DataSource = dt;
            rapor frmrapor = new rapor();
            frmrapor.Show();
        }
    }
}
