using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace atasözüoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt_atasozleri.accdb");
        string sorgu, secilenatasözü,cevap,gelenisim;
        DataSet ds = new DataSet();
        Random rnd = new Random();
        int sayı,sık,atasözünindeksi,sayı2,sayac=0,puan=0;
        List<string> atasözleri = new List<string>();
        List<string> yedekatasözleri = new List<string>();
        string[] sıkparcalanan;
        private void Form1_Load(object sender, EventArgs e)
        {
            tmr1.Start();
            gelenisim = Giriş.isim;
            lblkullanıcı.Text = "Hoş Geldin "+gelenisim;
            sorgu = "select * from atasozleri";
            OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
            verial.Fill(ds, "atasözleri");
            atasözügetriparacla();
        }
        void btnlar()
        {
            lblatasözü.Text = "";
            btna.Text = "";
            btnb.Text = "";
            btnc.Text = "";
            btnd.Text = "";
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btna.BackColor = Color.Transparent;
            btnb.BackColor = Color.Transparent;
            btnc.BackColor = Color.Transparent;
            btnd.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
        }
        void atasözügetriparacla()
        {
            btnlar();
            yedekatasözleri.Clear();
            atasözleri.Clear();
            atasözünindeksi=rnd.Next(0, ds.Tables["atasözleri"].Rows.Count-3);
            secilenatasözü = ds.Tables["atasözleri"].Rows[atasözünindeksi][1].ToString();
            for (int i = 1; i <=3 ; i++)
            {
                atasözleri.Add(ds.Tables["atasözleri"].Rows[atasözünindeksi+i][1].ToString());
            }
            string[] parcalanankelime = secilenatasözü.Split(' ');
            for (int i = 0; i < atasözleri.Count; i++)
            {
                sıkparcalanan = atasözleri[i].Split(' ');
                sayı2 = rnd.Next(0, sıkparcalanan.Length);
                    yedekatasözleri.Add(sıkparcalanan[sayı2]);
            }
            sayı = rnd.Next(0, parcalanankelime.Length);
            sık = rnd.Next(0,4);
            cevap = parcalanankelime[sayı];
            for (int i = 0; i < parcalanankelime.Length; i++)
            {
                if (i == sayı)
                {
                    lblatasözü.Text += "________";
                }
                else
                {
                    lblatasözü.Text += " " + parcalanankelime[i] + " ";
                }
            }
            if (sık == 0)
            {
                btna.Text = cevap;
                btnb.Text=yedekatasözleri[0];
                btnc.Text=yedekatasözleri[1];
                btnd.Text=yedekatasözleri[2];
            }
            else if (sık == 1)
            {
                btnb.Text = cevap;
                btna.Text=yedekatasözleri[0];
                btnc.Text=yedekatasözleri[1];
                btnd.Text=yedekatasözleri[2];
            }
            else if (sık == 2)
            {
                btnc.Text = cevap;
                btna.Text=yedekatasözleri[0];
                btnb.Text=yedekatasözleri[1];
                btnd.Text=yedekatasözleri[2];
            }
            else if (sık == 3)
            {
                btnd.Text = cevap;
                btna.Text=yedekatasözleri[0];
                btnc.Text=yedekatasözleri[1];
                btnb.Text=yedekatasözleri[2];
            }
        }
        private void btna_Click(object sender, EventArgs e)
        {
            if (cevap==btna.Text)
            {
                lblatasözü.Text = secilenatasözü;
                puan++;
                lblpuan.Text = "Puan:" + puan.ToString();
                btna.BackColor = Color.Green;
                
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                atasözügetriparacla();
            }
            else
            {
                btna.BackColor = Color.Red;
                puan--;
                lblpuan.Text = "Puan:" + puan.ToString();
                btna.Enabled = false;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                btna.BackColor = Color.Transparent;
            }
        }
        private void btnb_Click(object sender, EventArgs e)
        {
            if (cevap == btnb.Text)
            {
                puan++;
                lblatasözü.Text = secilenatasözü;
                lblpuan.Text = "Puan:" + puan.ToString();
                btnb.BackColor = Color.Green;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                atasözügetriparacla();
            }
            else
            {
                puan--;
                lblpuan.Text = "Puan:" + puan.ToString();
                btnb.BackColor = Color.Red;
                btnb.Enabled = false;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                btnb.BackColor = Color.Transparent;
            }
        }
        private void btnc_Click(object sender, EventArgs e)
        {
            if (cevap == btnc.Text)
            {
                puan++;
                lblpuan.Text = "Puan:" + puan.ToString();
                lblatasözü.Text = secilenatasözü;
                btnc.BackColor = Color.Green;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                atasözügetriparacla();
            }
            else
            {
                puan--;
                lblpuan.Text = "Puan:" + puan.ToString();
                btnc.BackColor = Color.Red;
                btnc.Enabled = false;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                btnc.BackColor = Color.Transparent;

            }
        }
        private void btnd_Click(object sender, EventArgs e)
        {
            if (cevap == btnd.Text)
            {
                puan++;
                lblpuan.Text = "Puan:" + puan.ToString();
                lblatasözü.Text = secilenatasözü;
                btnd.BackColor = Color.Green;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                atasözügetriparacla();
            }
            else
            {
                puan--;
                lblpuan.Text = "Puan:" + puan.ToString();
                btnd.BackColor = Color.Red;
                btnd.Enabled = false;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                btnd.BackColor = Color.Transparent;
            }
        }
        private void btnpas_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            atasözügetriparacla();
        }

        void olekomut(string sorgu1)
        {
            OleDbCommand komut = new OleDbCommand(sorgu1, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        private void tmr1_Tick(object sender, EventArgs e)
        {
            sayac++;
            lblsüre.Text = "Süre:" + sayac.ToString();
            if (sayac>=30)
            {
                tmr1.Stop();
                MessageBox.Show("Sürenüz Bitmiştir");
                sorgu = "select * from bilgiler where kullanıcıadı='"+gelenisim+"'";
                OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
                verial.Fill(ds, "bilgiler");
                if (ds.Tables["bilgiler"].Rows.Count!=0)
	{
		  if (int.Parse(ds.Tables["bilgiler"].Rows[0][1].ToString())<puan)
          {
          sorgu = "update bilgiler set puan=" + puan + " where kullanıcıadı='"+gelenisim+"'";
                        olekomut(sorgu);
          }
                else
                    {
                        MessageBox.Show("Aynı Puanda Kaldınız!");
                    }
	}
             if (ds.Tables["bilgiler"].Rows.Count==0)
                    {
                        sorgu = "insert into bilgiler(kullanıcıadı,puan) values('"+gelenisim+"',"+puan+")";
                        olekomut(sorgu);
                    }

                ////for (int i = 0; i < ds.Tables["bilgiler"].Rows.Count; i++)
                ////{
                //    if (ds.Tables["bilgiler"].Rows[i][0].ToString()==gelenisim)
                ////{
                //    if (Convert.ToInt16(ds.Tables["bilgiler"].Rows[i][1].ToString())<=puan)
                //    {
                        
                //    }
                
            }

        }
    }
}
