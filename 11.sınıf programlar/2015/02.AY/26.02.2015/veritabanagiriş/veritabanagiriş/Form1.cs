using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;



namespace veritabanagiriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt;
        string sorgu;
        int urunid;
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\bilgiler.accdb");
        OleDbDataAdapter verial;
        private void button1_Click(object sender, EventArgs e)
        { 
            dt.Rows.Clear();
            sorgu = "select*from urunler";
            sorgugöster();
        }
        void sorgugöster()
        {
            verial = new OleDbDataAdapter(sorgu, baglantı);
            dt=new DataTable();
            verial.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        int index;
        void gösterilecekler()
        {
            txtad.Text = dt.Rows[index][1].ToString();
            txtmarka.Text = dt.Rows[index][2].ToString();
            txtrenk.Text = dt.Rows[index][3].ToString();
            txtücret.Text = dt.Rows[index][4].ToString();
            txtadet.Text = dt.Rows[index][5].ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            urunid = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            gösterilecekler();
        }
        private void btnileri_Click(object sender, EventArgs e)
        {
            index++;
            if (index==dt.Rows.Count)
            {
                index = 0;
             }
            gösterilecekler();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            index--;
            if (index<0)
            {
                index = dt.Rows.Count - 1; ;
            }
            gösterilecekler();
        }
        private void btnilk_Click(object sender, EventArgs e)
        {
            index = 0;
            gösterilecekler();
        }
        private void btnson_Click(object sender, EventArgs e)
        {
            index = dt.Rows.Count - 1;
            gösterilecekler();
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            if (cmbx1.SelectedIndex==0)
            {
                sorgu="select*from urunler where ad='"+txtarama.Text +"'";
                sorgugöster();
            }
            if (cmbx1.SelectedIndex==1)
            {
                sorgu="select*from urunler where marka='"+txtarama.Text +"'";
                sorgugöster();
            }
            if (cmbx1.SelectedIndex == 2)
            {
                sorgu = "select*from urunler where renk='" + txtarama.Text + "'";
                sorgugöster();
            }
            if (cmbx1.SelectedIndex == 3)
            {
                sorgu = "select*from urunler where ücret between " + txtarama.Text + " and " + txtarama2.Text + "";
                sorgugöster();
            }
        }
        private void cmbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx1.SelectedIndex == 3)
            {
                txtarama2.Visible = true;
                label7.Visible = true;
                label6.Text = "Min";
            }
            else
            {
                txtarama2.Visible = false;
                label6.Text = "Aranacak";
                label7.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sorgu = "select*from urunler";
            sorgugöster();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text.Length==0||txtadet.Text.Length==0||txtmarka.Text.Length==0||txtrenk.Text.Length==0||txtücret.Text.Length==0)
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurunuz!!!");
            }
            else
            {
            sorgu = "insert into urunler(ad,marka,renk,ücret,adet)values('" + txtad.Text + "','" + txtmarka.Text + "','" + txtrenk.Text + "'," + txtücret.Text + "," + txtadet.Text + ")";
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();

            sorgu = "select*from urunler";
            sorgugöster();
            btnkaydet.Visible = false;
            }   
        }
        private void btnürünekle_Click(object sender, EventArgs e)
        {
            btnkaydet.Visible = true;
            txtad.Text = "";
            txtadet.Text = "";
            txtmarka.Text = "";
            txtrenk.Text = "";
            txtücret.Text = "";
        }

        private void btnürüngüncelle_Click(object sender, EventArgs e)
        {
            sorgu = "update urunler set ad='"+txtad.Text+"',marka='"+txtmarka.Text+"',renk='"+txtrenk.Text+"',ücret="+txtücret.Text+",adet="+txtadet.Text+" where urunid="+urunid+"";
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            sorgu = "select*from urunler";
            sorgugöster();
        }

        private void btnürünsil_Click(object sender, EventArgs e)
        {
            sorgu = "delete from urunler where urunid=" + urunid;
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            sorgu = "select*from urunler";
            sorgugöster();
            

        }
    }
}
