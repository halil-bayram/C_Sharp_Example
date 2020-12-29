using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kelimeoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:kelimeler.accdb");
        string sorgu;
        int sayac = 0;
        DataSet ds=new DataSet();
        Random rnd = new Random();
        void tablodoldur(string sorgu,string tabloadı)
        {
            OleDbDataAdapter verial = new OleDbDataAdapter(sorgu,baglantı);
         
            if (ds.Tables.Contains(tabloadı))
            {
                ds.Tables.Remove(tabloadı);
            }
            verial.Fill(ds,tabloadı);
        }
        int x = 0, y = 0;
        void panelekle(string kelime,bool kullanıcı)
        {
            Label lbl = new Label();
            lbl.Text = kelime;
            lbl.Location = new Point(x,y);
            y += 20;
            if (kullanıcı)
            {
                lbl.BackColor = Color.Plum;
            }
            else
            {
                lbl.BackColor = Color.Aqua;
            }
            panel1.Controls.Add(lbl);
        }
        string secilenkelime;

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr1.Start();
            sorgu = "select * from kelimeler";
            tablodoldur(sorgu,"kelimeler");
            secilenkelime = ds.Tables["kelimeler"].Rows[rnd.Next(0, ds.Tables["kelimeler"].Rows.Count)][1].ToString();
            panelekle(secilenkelime,false);
        }
        string kelime,sonharf,ilkharf;
        private void btnonayla_Click(object sender, EventArgs e)
        {
            
            bool varmı = false;
            kelime = txtkelime.Text;
            sonharf = secilenkelime[(secilenkelime.Length - 1)].ToString();
            ilkharf = kelime[0].ToString();
            
            if (sonharf == ilkharf)
            {
                for (int i = 0; i < ds.Tables["kelimeler"].Rows.Count; i++)
			{
                if (ds.Tables["kelimeler"].Rows[i][1].ToString()==kelime)
                {
                    varmı = true;
                    break;
                }
			}
                if (varmı)
                {
                    sayac = 0;
                     panelekle(kelime, true);
                     sorgu = "select * from kelimeler where kelime like '" + kelime[kelime.Length-1] + "%'";
                     tablodoldur(sorgu, "secilenkelime");
                     secilenkelime = ds.Tables["secilenkelime"].Rows[rnd.Next(0, ds.Tables["secilenkelime"].Rows.Count)][1].ToString();
                     panelekle(secilenkelime, false);

                }
                else
                {
                    MessageBox.Show("böyle bir kelime yok ");
                }
            }
                else
               {
                   MessageBox.Show("Karakterler Uyuşmuyor");
               }
            txtkelime.Text = "";
        }
        
        private void tmr1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac>=7)
            {
                lblsüre.BackColor = Color.Red;
            }
            else
            {
                lblsüre.BackColor = Color.Green;
            }
            lblsüre.Text = "Süre:"+sayac.ToString();
        }

        private void txtkelime_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
