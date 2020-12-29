using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace takımdagıtımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=liste.accdb");
        DataSet ds;
        string sorgu, cinsiyet;
        int kişisayısı, oyuncusayısı;
        bool attır = true;
        void tablodoldur(string tabloadı)
        {
            OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
            if (ds.Tables.Contains(tabloadı))
            {
                ds.Tables.Remove(tabloadı);
            }
            verial.Fill(ds, tabloadı);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnoluştur_Click(object sender, EventArgs e)
        {
             ds = new DataSet();
            if (cbxcinsiyet.SelectedIndex == 0)
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }
            sorgu = "select * from ogrliste where sinifseviye='" + cmxsınıfseviye.SelectedItem + "' and cinsiyet='" + cinsiyet + "'";
            tablodoldur("gelenkişiler");
            if (cbxtakımlar.SelectedIndex == 0)
            {
                oyuncusayısı = 12;
            }
            else if (cbxtakımlar.SelectedIndex == 1)
            {
                oyuncusayısı = 10;
            }
            else if (cbxtakımlar.SelectedIndex == 2)
            {  
                oyuncusayısı = 16;
            }
            kişisayısı = int.Parse(ds.Tables["gelenkişiler"].Rows.Count.ToString()) / oyuncusayısı;
            for (int i = 1; i <= kişisayısı; i++)
            {
                cbxtakımsayısı.Items.Add(i);
            }
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            tmr1.Start();
            attır = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int kacıncıtakım;
            kacıncıtakım = cbxtakımsayısı.SelectedIndex;
            for (int i = (kacıncıtakım * oyuncusayısı); i < ((kacıncıtakım * oyuncusayısı) + oyuncusayısı); i++)
            {
                listBox1.Items.Add(ds.Tables["gelenkişiler"].Rows[i][1].ToString());
                listBox2.Items.Add(ds.Tables["gelenkişiler"].Rows[i][2].ToString());
            }
        }
       
        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (attır==true)
            {
                if (this.Width >= 723)
            {
                tmr1.Stop();
            }
            else
            {
                this.Width += 10;
            }
            }
            

            if (attır==false)
            {
                if (this.Width >= 121)
            {
                tmr1.Stop();

            }
            else
            {
                this.Width -= 10;
            }
            }
            
        }

        private void cbxtakımlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmr1.Start();
            attır = false;
            
        }
    }
}
