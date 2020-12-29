using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=localhost;Initial Catalog=kisiler;Integrated Security=True");
      public static  DataSet ds = new DataSet();
        string sorgu;

        void kişigöster(string numara)
        {
            ds.Tables.Clear();
            listBox1.Items.Clear();
            sorgu = "select * from rehber where numara like '%"+numara+"%'";
            SqlDataAdapter verial = new SqlDataAdapter(sorgu,baglantı);
            verial.Fill(ds,"kişiler");
            for (int i = 0; i < ds.Tables["kişiler"].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables["kişiler"].Rows[i][1].ToString()+"   "+ds.Tables["kişiler"].Rows[i][2].ToString());
            }
        }
        private void btnclik(object sender, EventArgs e)
        {
            Button btn=sender as Button;
            txtnumara.Text += btn.Text;
            kişigöster(txtnumara.Text);

        }
        string numara;
        private void btnsil_Click(object sender, EventArgs e)
        {
            numara = txtnumara.Text;
            txtnumara.Clear();
            for (int i = 0; i < numara.Length-1; i++)
            {
                txtnumara.Text+=numara[i];
            }
            kişigöster(txtnumara.Text);

            if (txtnumara.Text=="")
            {
                listBox1.Items.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorgu = "select * from rehber ";
            SqlDataAdapter verial = new SqlDataAdapter(sorgu, baglantı);
            verial.Fill(ds, "kişiler");
            txtnumara.Text=ds.Tables["kişiler"].Rows[listBox1.SelectedIndex][3].ToString();
        }
        string aranıyor = "ARANIYOR....";
        int sayac = 0;
        bool netarafa=true;
        private void btnara_Click(object sender, EventArgs e)
        {
            lblad.Text = listBox1.SelectedItem.ToString();
            lblnumara.Text = txtnumara.Text;
            timer1.Start();
            netarafa = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (netarafa==false)
            {
                if (this.Width<427)
            {
                 this.Width += 20;
                for (int i = 0; i < 20; i++)
            {
                this.Height += 10;
                this.Left += 10;
                this.Height -= 10;
                this.Left -= 10;
            }
            }
            else if (this.Width>=427)
            {
                this.Width = 427;

            }
                lblloding.Text += aranıyor[sayac];
            sayac++;
            if (sayac==aranıyor.Length)
            {
                sayac = 0;
                lblloding.Text = "";
            }
            }
            else if (netarafa==true)
            {
                if (this.Width<=427)
                {
                    this.Width -= 20;
                }
                  if (this.Width<=220)
                {
                    this.Width = 220;
                    timer1.Stop();
                }
            }
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            netarafa = true;
            timer1.Start();
        }
        public static string butuonadı;
        public static int id, index;
        public static bool yenimi=true;
        private void btnkişiekle_Click(object sender, EventArgs e)
        {
            
            butuonadı = "KAYDET";
            index = listBox1.SelectedIndex;
           
            kişidüzenle frmdüzenle = new kişidüzenle();
            frmdüzenle.Show();
        }
       
        private void btngüncelle_Click(object sender, EventArgs e)
        {

            butuonadı = "GÜNCELLE";
            index = listBox1.SelectedIndex;
            if (index==-1)
            {
                MessageBox.Show("Lütfen Bir Kişi Seciniz Veya Kişi Ekleyiniz");
            }
            else
            {
            id = Convert.ToInt16(ds.Tables["kişiler"].Rows[listBox1.SelectedIndex][0].ToString()); 
            kişidüzenle frmdüzenle = new kişidüzenle();
            frmdüzenle.Show();
            yenimi = false;
            }
            
           
        }
       
    }
}
