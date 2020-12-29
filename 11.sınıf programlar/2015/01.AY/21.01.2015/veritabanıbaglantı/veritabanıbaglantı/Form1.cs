using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace veritabanıbaglantı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\eokul.accdb");
            string sorgu="select * from dersler";
            OleDbDataAdapter verial=new OleDbDataAdapter(sorgu,baglantı);
            DataTable tablo=new DataTable();
            verial.Fill(tablo);
            dataGridView1.DataSource=tablo;
        }
    }
}
