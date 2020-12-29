using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace butonyakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, sayac = 0, deger = 0;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            x = rnd.Next(0, this.Width - button1.Width);
            y = rnd.Next(0, this.Height - button1.Height);
            lblx.Text = "x:" + x.ToString();
            lbly.Text = "y:" + y.ToString();
            button1.Location = new Point(x, y);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            x = rnd.Next(0, this.Width - (button1.Width+20));
            y = rnd.Next(0, this.Height - (button1.Height+20));
            button1.Location = new Point(x, y);
            lblx.Text = "x:" + x.ToString();
            lbly.Text = "y:" + y.ToString();
            
            deger = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (deger == 0)
            {
                sayac++;
                lblsayac.Text = sayac.ToString();
                deger = 1;
            }

        }

    }
}
