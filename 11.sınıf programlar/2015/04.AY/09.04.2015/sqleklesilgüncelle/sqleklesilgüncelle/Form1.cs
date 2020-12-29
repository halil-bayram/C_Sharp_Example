using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sqleklesilgüncelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=localhost;Initial Catalog=bilgiler;Integrated Security=True");
        string[] metinkriter = { "eşit", "eşit degil", "içerir", "içermez", "ile başlar", "ile başlamaz" };
        string[] sayikriter = { "eşit", "eşit degil", "büyük", "küçük", "arasında" };
        string[] metinsembol = { "=", "!=", "%", "%", "%", "%" };
        string[] sayisembol = { "=", "!=", ">", "<" };
        string sorgu;
        DataSet ds = new DataSet();

        void tablodoldur(string tabloadı)
        {
            SqlDataAdapter verial = new SqlDataAdapter(sorgu, baglantı);
            if (ds.Tables.Contains(tabloadı))
            {
                ds.Tables.Remove(tabloadı);
            }
            verial.Fill(ds, tabloadı);
        }
        void eklesilgüncelle()
        {
            SqlCommand cmd = new SqlCommand(sorgu, baglantı);
            baglantı.Open();
            cmd.ExecuteNonQuery();
            baglantı.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sorgu = "select * from atl10a";
            tablodoldur("bilgileri");
            dataGridView1.DataSource = ds.Tables["bilgileri"];

            for (int i = 1; i < ds.Tables["bilgileri"].Columns.Count; i++)
            {
                cmbxalan.Items.Add(ds.Tables["bilgileri"].Columns[i].ColumnName);
            }
        }
        double boy, kilo;
        private void tlsbKaydet_Click(object sender, EventArgs e)
        {
            boy = Convert.ToDouble(txtboy.Text) / 100;
            kilo = Convert.ToDouble(txtkilo.Text);
            double vctktli = kilo / (boy * boy);
            vki2 = vctktli.ToString().Replace(',', '.');
            txtvki.Text = vki2;
            sorgu = "insert into atl10a(NUMARA,ADSOYAD,CİNSİYET,KİLO,BOY,VKİ) values(" + txtno.Text + ",'" + txtadsoyad.Text + "','" + txtcinsiyet.Text + "'," + txtkilo.Text + "," + txtboy.Text + "," + txtvki.Text + ")";
            eklesilgüncelle();
            sorgu = "select * from atl10a";
            tablodoldur("bilgileri");
            dataGridView1.DataSource = ds.Tables["bilgileri"];
        }
        string vki2;
        private void tlsbgüncelle_Click(object sender, EventArgs e)
        {
            boy = Convert.ToDouble(txtboy.Text) / 100;
            kilo = Convert.ToDouble(txtkilo.Text);
            double vctktli = kilo / (boy * boy);
            vki2 = vctktli.ToString().Replace(',','.');
            txtvki.Text = vki2;
            sorgu = "update atl10a set NUMARA=" + txtno.Text + ",ADSOYAD='" + txtadsoyad.Text + "',CİNSİYET='" + txtcinsiyet.Text + "',KİLO=" + txtkilo.Text + ",BOY=" + txtboy.Text + ",VKİ=" + txtvki.Text + " where SIRANO=" + sırano + " ";
            eklesilgüncelle();
            sorgu = "select * from atl10a";
            tablodoldur("bilgileri");
            dataGridView1.DataSource = ds.Tables["bilgileri"];
        }
        int index, sırano;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtadsoyad.Text = ds.Tables["bilgileri"].Rows[index][2].ToString();
            txtno.Text = ds.Tables["bilgileri"].Rows[index][1].ToString();
            txtcinsiyet.Text = ds.Tables["bilgileri"].Rows[index][3].ToString();
            txtkilo.Text = ds.Tables["bilgileri"].Rows[index][4].ToString();
            txtboy.Text = ds.Tables["bilgileri"].Rows[index][5].ToString();
            txtvki.Text = ds.Tables["bilgileri"].Rows[index][6].ToString();
            sırano = int.Parse(ds.Tables["bilgileri"].Rows[index][0].ToString());
        }
        private void tlsbsil_Click(object sender, EventArgs e)
        {
            sorgu = "delete from atl10a where SIRANO=" + sırano + "";
            eklesilgüncelle();
            sorgu = "select * from atl10a";
            tablodoldur("bilgileri");
            dataGridView1.DataSource = ds.Tables["bilgileri"];
            temizle();
        }
        void temizle()
        {
            txtadsoyad.Text = "";
            txtno.Text = "";
            txtcinsiyet.Text = "";
            txtkilo.Text = "";
            txtboy.Text = "";
            txtvki.Text = "";
        }
        private void tlsbyenikayıt_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void cmbxalan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxkriter.Items.Clear();

            if (cmbxalan.SelectedIndex == 0 || cmbxalan.SelectedIndex == 3 || cmbxalan.SelectedIndex == 4 || cmbxalan.SelectedIndex == 5)
            {
                for (int i = 0; i < sayikriter.Length; i++)
                {
                    cmbxkriter.Items.Add(sayikriter[i]);
                }
            }
            if (cmbxalan.SelectedIndex == 1 || cmbxalan.SelectedIndex == 2)
            {
                for (int i = 0; i < metinkriter.Length; i++)
                {
                    cmbxkriter.Items.Add(metinkriter[i]);
                }
            }
        }
        string deger, hangisi;
        private void btnbul_Click(object sender, EventArgs e)
        {
            if (cmbxalan.SelectedIndex == 0 || cmbxalan.SelectedIndex == 3 || cmbxalan.SelectedIndex == 4 || cmbxalan.SelectedIndex == 5)
            {
                if (cmbxalan.SelectedIndex == 0)
                {
                    hangisi = "NUMARA";
                }
                if (cmbxalan.SelectedIndex == 3)
                {
                    hangisi = "KİLO";
                }
                if (cmbxalan.SelectedIndex == 4)
                {
                    hangisi = "BOY";
                }
                if (cmbxalan.SelectedIndex == 5)
                {
                    hangisi = "VKİ";
                }
                if (cmbxkriter.SelectedIndex == 0)
                {
                    deger = "=" + "'" + int.Parse(txtdeger.Text) + "'";
                }
                else if (cmbxkriter.SelectedIndex == 1)
                {
                    deger = "!=" + "'" + int.Parse(txtdeger.Text) + "'";
                }
                else if (cmbxkriter.SelectedIndex == 2)
                {
                    deger = ">" + "'" + int.Parse(txtdeger.Text) + "'";
                }
                else if (cmbxkriter.SelectedIndex == 3)
                {
                    deger = "<" + "'" + int.Parse(txtdeger.Text) + "'";
                }
                else if (cmbxkriter.SelectedIndex == 4)
                {
                    deger = " between " + int.Parse(txtdeger.Text) + " and " + int.Parse(txtve.Text);
                }
                sorgu = "select * from atl10a where " + hangisi + "" + deger + "";
                tablodoldur("bilgileri");
                dataGridView1.DataSource = ds.Tables["bilgileri"];
            }
            else if (cmbxalan.SelectedIndex == 1 || cmbxalan.SelectedIndex == 2)
            {
                if (cmbxkriter.SelectedIndex == 0)
                {
                    deger = "=" + txtdeger.Text;
                }
                else if (cmbxkriter.SelectedIndex == 1)
                {
                    deger = "!=" + txtdeger.Text;
                }
                else if (cmbxkriter.SelectedIndex == 2)
                {
                    deger = "like '%" + txtdeger.Text + "%'";
                }
                else if (cmbxkriter.SelectedIndex == 3)
                {
                    deger = "not like '%" + txtdeger.Text + "%'";
                }
                else if (cmbxkriter.SelectedIndex == 4)
                {
                    deger = " like '" + txtdeger.Text + "%'";
                }
                else if (cmbxkriter.SelectedIndex == 5)
                {
                    deger = "not like '" + txtdeger.Text + "%'";
                }
                if (cmbxalan.SelectedIndex == 1)
                {
                    hangisi = "ADSOYAD";
                }
                if (cmbxalan.SelectedIndex == 2)
                {
                    hangisi = "CİNSİYET";
                }
                sorgu = "select * from atl10a where " + hangisi + " " + deger + "";
                tablodoldur("bilgileri");
                dataGridView1.DataSource = ds.Tables["bilgileri"];
            }
        }
    }
}
