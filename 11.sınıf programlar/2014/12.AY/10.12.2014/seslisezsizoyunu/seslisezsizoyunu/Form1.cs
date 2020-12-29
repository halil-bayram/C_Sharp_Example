using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace seslisezsizoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sessizharf = "qwrtypğsdfghjlkşzxcvbnmç";
        string sesliharf = "euıoüaiö";
        string secilenkelimem = "";
        Random rnd =new Random();
        List<string> kelimeler = new List<string>() {"VELİ","HALİL","BURAK" };
        void buronekle(string harfler, Panel paneladı)
        {
            int x = 0, y = 0;
            for (int i = 1; i <= harfler.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(35,35);
                btn.Location = new Point(x,y);
                btn.Name =harfler[i - 1].ToString().ToUpper();
                if (paneladı!=panelsecilenkelime)
                {
                    btn.Text =harfler[i - 1].ToString().ToUpper();
                }
                paneladı.AutoSize = true;
                paneladı.Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);
                x+=38;
                
                if (i%8==0)
	              {
	                 x=0;
                        y+=38;
        
	             }
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button b=sender as Button;
            if (panelsesliharf.Visible==true)
            {
                panelsesliharf.Visible = false;
            }
            foreach (Button btn in panelsecilenkelime.Controls)
            {
                if (b.Name==btn.Name)
                {
                    btn.Text = btn.Name;
                }
            }
            
        }

        void secilenkelime()
        {
            
            secilenkelimem=kelimeler[rnd.Next(0,kelimeler.Count)];
            kelimeler.Remove(secilenkelimem);
            buronekle(secilenkelimem, panelsecilenkelime);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buronekle(sessizharf, panelsessizharf);
            buronekle(sesliharf, panelsesliharf);
            secilenkelime();

        }

        private void btnünlü_Click(object sender, EventArgs e)
        {
            panelsesliharf.Visible = true;
        }

        private void btntahmin_Click(object sender, EventArgs e)
        {
            grbxtahmin.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txttahmin.Text.ToUpper()==secilenkelimem)
            {
                MessageBox.Show("Tebrikler!!!");
            }
            else
            {
                MessageBox.Show("Yanlış Cevap!!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grbxtahmin.Visible = false;
            txttahmin.Text = "";
        }


       

        
    }
}
