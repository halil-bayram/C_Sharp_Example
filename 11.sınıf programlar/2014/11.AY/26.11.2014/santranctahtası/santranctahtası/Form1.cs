using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace santranctahtası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0, y = 0, satir = 0;
            for (int i = 1; i <= 64; i++)
            {
                Button btn = new Button();
                
                btn.Name = "btn" + i.ToString();
                btn.Size = new Size(80, 80);
                btn.Location = new Point(x, y);
                if ((i % 2 == 0 && satir % 2 == 1) || (i % 2 == 1 && satir % 2 == 0))
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;

                }
                else
                {
                    btn.BackColor = Color.Bisque;
                    btn.ForeColor = Color.Black;
                }
                panel1.Controls.Add(btn);
                x += btn.Width;
                if (i % 8 == 0)
                {
                    x = 0;
                    y += btn.Height;
                    satir++;
                }
                if (i==1||i==8||i==57||i==64)
                {
                    btn.Text = "Kale";
                }
                if (i == 2 || i == 7 || i == 58 || i == 63)
                {
                    btn.Text = "At";
                }
                if (i == 3 || i == 6 || i == 59 || i == 62)
                {
                    btn.Text = "Fil";
                }
                if (i == 4 || i == 61 )
                {
                    btn.Text = "Vezir";
                }
                if (i == 5 || i == 60 )
                {
                    btn.Text = "Şah";
                }
                if ((i>=9&&i<=16)||(i>=49&&i<=56))
                {
                    btn.Text = "Piyon";
                }
            }
        }

        

    }
}
