using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sinemarandevu
{
    public partial class satışekranı : Form
    {
        public satışekranı()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sinemabilgiler.accdb");
        OleDbDataAdapter verial;
        DataSet ds = new DataSet();
        string sorgu;
        void tablodüzenle(string isim)
        {
            if (ds.Tables.Contains(isim))
            {
                ds.Tables.Remove(isim);
            }
           
            verial = new OleDbDataAdapter(sorgu, baglantı);
            verial.Fill(ds, isim);
            
            
        }
        private void satışekranı_Load(object sender, EventArgs e)
        {
            sorgu = "select * from filimler";
            verial = new OleDbDataAdapter(sorgu, baglantı);
            verial.Fill(ds, "filimadı");
            for (int i = 0; i < ds.Tables["filimadı"].Rows.Count; i++)
            {
                cmbfilimler.Items.Add(ds.Tables["filimadı"].Rows[i][1].ToString());
            }
               
            
        }

        private void cmbfilimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxsalon.Items.Clear();
            cmbxseans.Items.Clear();
            txtyönetmen.Text = ds.Tables["filimadı"].Rows[cmbfilimler.SelectedIndex][2].ToString();
            txtsüre.Text = ds.Tables["filimadı"].Rows[cmbfilimler.SelectedIndex][4].ToString();
            txtkonu.Text = ds.Tables["filimadı"].Rows[cmbfilimler.SelectedIndex][5].ToString();
            if (ds.Tables["filimadı"].Rows[cmbfilimler.SelectedIndex][6]==null)
            {
                pctrbxafiş.Image = null;
            }
            else
            {
                pctrbxafiş.Image = Image.FromFile(ds.Tables["filimadı"].Rows[cmbfilimler.SelectedIndex][6].ToString());
            }
            sorgu="select * from turler where turid=("+ds.Tables["filimadı"].Rows[cmbfilimler.SelectedIndex][3]+")";
            tablodüzenle("flimturleri");
            txttur.Text = ds.Tables["flimturleri"].Rows[0][1].ToString();
            cmbxsalon.Items.Add(ds.Tables["filimadı"].Rows[cmbfilimler.SelectedIndex][7].ToString());
            string[] seanslar = ds.Tables["filimadı"].Rows[cmbfilimler.SelectedIndex][8].ToString().Split('/');

            for (int i = 0; i < seanslar.Length; i++)
            {
                cmbxseans.Items.Add(seanslar[i]);
            }
        }

        int biletno,filimid,filiminsalonu;
        string filiminseansı;
        int koltuksayısı, x, y;
        List<int> koltuklar = new List<int>();
        private void cmbxseans_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorgu = "select * from filimler";
            tablodüzenle("biletkayıt");
            filimid = Convert.ToInt16(ds.Tables["biletkayıt"].Rows[cmbfilimler.SelectedIndex][0].ToString());
            filiminsalonu = Convert.ToInt16(ds.Tables["biletkayıt"].Rows[cmbfilimler.SelectedIndex][7].ToString());
            filiminseansı = cmbxseans.SelectedItem.ToString();
            pnl1.Controls.Clear();
            x = 0;
            y = 0;
            sorgu = "select * from salon";
            tablodüzenle("koltuksayısı");
            koltuksayısı = Convert.ToInt16(ds.Tables["koltuksayısı"].Rows[cmbxsalon.SelectedIndex][2].ToString());
            sorgu = "select * from bilet where filmid="+filimid+" and salonid="+filiminsalonu+" and seansid='"+filiminseansı+"'";
            tablodüzenle("koltukvarmı");
            for (int i = 0; i < ds.Tables["koltukvarmı"].Rows.Count; i++)
            {
                koltuklar.Add(int.Parse(ds.Tables["koltukvarmı"].Rows[i][4].ToString()));
            }
            for (int i = 1; i <= koltuksayısı; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Location = new Point(x, y);
                btn.Size = new Size(35, 30);
                x += 35;
                if (koltuklar.IndexOf(i)==-1)
                {
                    btn.BackColor = Color.Green;
                }
                else
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }
                pnl1.Controls.Add(btn);
                if (i % 10 == 0)
                {
                    x = 0;
                    y += 35;
                }
                btn.Click += new EventHandler(btn_Click);
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (rdbiptal.Checked)
            {
                if (b.BackColor==Color.Red)
                {
                    b.BackColor = Color.Yellow;
                   koltuklar.Add(int.Parse(b.Text));
                }
                else 
                {
                    b.BackColor = Color.Red;
                     koltuklar.Remove(int.Parse(b.Text));
                }
            }
            else
            {
                if (b.BackColor == Color.Yellow)
            {
                b.BackColor = Color.Green;
                koltuklar.Remove(int.Parse(b.Text));
            }
            else 
            {
                b.BackColor = Color.Yellow;
                koltuklar.Add(int.Parse(b.Text));
            }
            }
            
        }
        void olekomut(string sorgu)
        {
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        private void btnrandevu_Click(object sender, EventArgs e)
        {
            biletno = cmbfilimler.SelectedIndex;
            for (int i = 0; i < koltuklar.Count; i++)
            {
                sorgu = "insert into bilet(filmid,salonid,seansid,koltukno) values(" + filimid + "," + filiminsalonu + ",'" + filiminseansı + "'," + koltuklar[i] + ")";
                olekomut(sorgu);
            }
        }

        private void rdbiptal_CheckedChanged(object sender, EventArgs e)
        {
            koltuklar.Clear();
            btnbiletal.Enabled = false;
            foreach (Button b in pnl1.Controls)
            {
                if (b.BackColor==Color.Green)
                {
                    b.Enabled = false;
                }
                else
                {
                    b.Enabled = true;
                }
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            btnbiletal.Enabled = true;
            rdbiptal.Checked = false;
            for (int i = 0; i < koltuklar.Count; i++)
            {
                sorgu = "delete from bilet where filmid=" + filimid + " and salonid="+filiminsalonu+" and seansid='"+cmbxseans.SelectedItem.ToString()+"' and koltukno="+koltuklar[i]+"";
                olekomut(sorgu);
            }

            foreach (Button b in pnl1.Controls)
            {
                if (b.BackColor==Color.Yellow)
                {
                    b.BackColor = Color.Green;
                    b.Enabled = true;

                }
                
            }

        }
    }
}
