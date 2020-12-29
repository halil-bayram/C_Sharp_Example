using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dinamikbutonsurukleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> sayılar = new List<int>();
        Random rnd = new Random();

        void tekrarsızsayıüret(int kactanerastgele)
        {
            sayılar.Clear();
            int sayı,sayac=0;
            do
            {
                sayı = rnd.Next(1,kactanerastgele+1);
                if (sayılar.IndexOf(sayı)==-1)
                {
                    sayılar.Add(sayı);
                    sayac++;
                }
                
            } while (sayac!=kactanerastgele);

        }

        void butonüret(int kaçtanebuton)
        {
            int x = 0, y = 30;
            for (int i = 1; i <= kaçtanebuton; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(30, 30);
                btn.Location = new Point(x, y);
                btn.Text = sayılar[i - 1].ToString();
                x += 32;
                if (i % 5 == 0)
                {
                    x = 0;
                    y += 32;
                }
                this.Controls.Add(btn);
                btn.MouseUp += new MouseEventHandler(btn_MouseUp);
                btn.MouseMove += new MouseEventHandler(btn_MouseMove);
                btn.MouseDown += new MouseEventHandler(btn_MouseDown);
            }
        }
        bool suruklensinmi = false;
        Button tıklananbuton;
        Point ilkkonum, butonilkkonum;
        int sayac = 1;
        void btn_MouseDown(object sender, MouseEventArgs e)
        {
            tıklananbuton = sender as Button;
            butonilkkonum = tıklananbuton.Location;
            ilkkonum = e.Location;
            suruklensinmi = true;

        }

        void btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklensinmi)
            {
                tıklananbuton.Left += e.X - ilkkonum.X;
                tıklananbuton.Top += e.Y - ilkkonum.Y;
            }
            
        }

        void btn_MouseUp(object sender, MouseEventArgs e)
        {
            suruklensinmi = false;
            if ((tıklananbuton.Location.X>=flowLayoutPanel1.Location.X&&tıklananbuton.Location.X<=flowLayoutPanel1.Location.X+flowLayoutPanel1.Width)&&(tıklananbuton.Location.Y>=flowLayoutPanel1.Location.Y&&tıklananbuton.Location.Y<=flowLayoutPanel1.Location.Y+flowLayoutPanel1.Height)&&tıklananbuton.Text==sayac.ToString())
            {
                flowLayoutPanel1.Controls.Add(tıklananbuton);
                sayac++;
            }
            else
            {
                tıklananbuton.Location = butonilkkonum;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;

        }

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            tekrarsızsayıüret(20);
            butonüret(20);
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            tekrarsızsayıüret(40);
            butonüret(40);
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            tekrarsızsayıüret(70);
            butonüret(70);
        }

    }
}
