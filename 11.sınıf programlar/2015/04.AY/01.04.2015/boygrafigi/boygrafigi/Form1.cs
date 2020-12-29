using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace boygrafigi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bilgiler.accdb");
        string sorgu;
        DataSet ds = new DataSet();
        void tablodoldur(string sorgu)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void cmbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string adı;
            if (cmbx1.SelectedIndex == 0)
            {
                ds.Tables.Clear();
                panel1.Controls.Clear();
                sorgu = "select * from boykilo order by BOY asc";
                OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
                verial.Fill(ds, "bilgiler");
                dataGridView1.DataSource = ds.Tables["bilgiler"];
                int x = 0, y = panel1.Height;
                for (int i = 0; i < ds.Tables["bilgiler"].Rows.Count; i++)
                {
                    Button btn = new Button();
                    Label lbl = new Label();
                    btn.Size = new Size(30, 2 * int.Parse(ds.Tables["bilgiler"].Rows[i][5].ToString()));
                    lbl.Text = ds.Tables["bilgiler"].Rows[i][5].ToString();
                    lbl.Size = new Size(30, int.Parse(ds.Tables["bilgiler"].Rows[i][5].ToString()));
                    if (ds.Tables["bilgiler"].Rows[i][3].ToString() == "ERKEK")
                    {
                        btn.BackColor = Color.Aqua;
                    }
                    else if (ds.Tables["bilgiler"].Rows[i][3].ToString() == "KIZ")
                    {
                        btn.BackColor = Color.Green;
                    }
                    adı = ds.Tables["bilgiler"].Rows[i][2].ToString();
                    for (int j = 0; j < adı.Length; j++)
                    {
                        btn.Text += adı[j].ToString() + "\n";
                    }
                    lbl.Location = new Point(x, (y - 2 * int.Parse(ds.Tables["bilgiler"].Rows[i][5].ToString())) - 20);
                    btn.Location = new Point(x, (y - 2 * int.Parse(ds.Tables["bilgiler"].Rows[i][5].ToString())));
                    x += 30;
                    panel1.Controls.Add(btn);
                    panel1.Controls.Add(lbl);
                }
            }
            else if (cmbx1.SelectedIndex == 1)
            {
                ds.Tables.Clear();
                panel1.Controls.Clear();
                sorgu = "select * from boykilo order by KILO desc";
                OleDbDataAdapter verial = new OleDbDataAdapter(sorgu, baglantı);
                verial.Fill(ds, "bilgiler");
                dataGridView1.DataSource = ds.Tables["bilgiler"];
                int x = 0, y = panel1.Height;
                for (int i = 0; i < ds.Tables["bilgiler"].Rows.Count; i++)
                {
                    Button btn = new Button();
                    Label lbl = new Label();
                    btn.Size = new Size(30, int.Parse(ds.Tables["bilgiler"].Rows[i][4].ToString()));
                    lbl.Text = ds.Tables["bilgiler"].Rows[i][4].ToString();
                    lbl.Size = new Size(30, int.Parse(ds.Tables["bilgiler"].Rows[i][4].ToString()));
                    if (ds.Tables["bilgiler"].Rows[i][3].ToString() == "ERKEK")
                    {
                        btn.BackColor = Color.Aqua;
                    }
                    else if (ds.Tables["bilgiler"].Rows[i][3].ToString() == "KIZ")
                    {
                        btn.BackColor = Color.Green;
                    }
                    adı = ds.Tables["bilgiler"].Rows[i][2].ToString();
                    for (int j = 0; j < adı.Length; j++)
                    {
                        btn.Text += adı[j].ToString() + "\n";
                    }


                    lbl.Location = new Point(x, y - int.Parse(ds.Tables["bilgiler"].Rows[i][4].ToString()) - 20);
                    btn.Location = new Point(x, y - int.Parse(ds.Tables["bilgiler"].Rows[i][4].ToString()));
                    x += 30;
                    panel1.Controls.Add(btn);
                    panel1.Controls.Add(lbl);
                }
            }
        }
    }
}
