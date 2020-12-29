using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace faturaödemetarihi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarihler.accdb");
        string sorgu, tcno;
        DataSet ds = new DataSet();
        void tablodoldur(string tabloadı)
        {
            OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
            if (ds.Tables.Contains(tabloadı))
            {
                ds.Tables.Remove(tabloadı);
            }
            verial.Fill(ds, tabloadı);
        }
        void eklesilgüncelle()
        {
            OleDbCommand verial = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            verial.ExecuteNonQuery();
            baglantı.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DateTime başlangıcT = new DateTime();
            DateTime bitişT = new DateTime();

            tcno = txttcno.Text;
            if (tcno.Length < 11)
            {
                MessageBox.Show("Eksik Deger Girdiniz");
            }
            else
            {
                başlangıcT = dtp1.Value.AddDays(5);
                if (başlangıcT.DayOfWeek.ToString() == "Sunday")
                {
                    başlangıcT = başlangıcT.AddDays(1);
                }
                else if (başlangıcT.DayOfWeek.ToString() == "Saturday")
                {
                    başlangıcT = başlangıcT.AddDays(2);
                }
                bitişT = başlangıcT.AddDays(10);
                if (bitişT.DayOfWeek.ToString() == "Sunday")
                {
                    bitişT = bitişT.AddDays(1);
                }
                else if (bitişT.DayOfWeek.ToString() == "Saturday")
                {
                    bitişT = bitişT.AddDays(2);
                }
                sorgu = "insert into kayıtlar (musteritc,ilkodemeT,sonödemeT) values('" + tcno + "','" + başlangıcT.ToShortDateString() + "','" + bitişT.ToShortDateString() + "')";
                eklesilgüncelle();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string bugün = DateTime.Today.ToString("MM/dd/yyyy");
            bugün = bugün.Replace('.', '/');
            sorgu = "select  musteritc,ilkodemeT,sonödemeT from kayıtlar where #" + bugün + "# between ilkodemeT and sonödemeT ";
            tablodoldur("odemesiolanlar");
            dgv1.DataSource = ds.Tables["odemesiolanlar"];
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            sorgu = "select *from kayıtlar where musteritc='" + txttcnobul.Text + "'";
            tablodoldur("tcbul");
            dataGridView1.DataSource = ds.Tables["tcbul"];
        }

    }
}
