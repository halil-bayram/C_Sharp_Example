using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atyarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1, sayı2, sayı3, sayı4;
        Random rnd = new Random();
           
        private void Form1_Load(object sender, EventArgs e)
        {
            tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            sayı1 = rnd.Next(1,10);
            btn1.Left += sayı1;

            sayı2 = rnd.Next(1, 10);
            btn2.Left += sayı2;

            sayı3 = rnd.Next(1, 10);
            btn3.Left += sayı3;

            sayı4 = rnd.Next(1, 10);
            btn4.Left += sayı4;
            if (btn1.Left>this.Width-btn1.Width)
            {
                tmr1.Stop();
                MessageBox.Show("1.at kazandı");
                
            }
            else if (btn2.Left > this.Width - btn2.Width)
            {
            tmr1.Stop();
                MessageBox.Show("2.at kazandı");
                
            }
            else if (btn3.Left > this.Width - btn3.Width)
            {
            tmr1.Stop();
                MessageBox.Show("3.at kazandı");
                
            }
            else if (btn4.Left > this.Width - btn4.Width)
            {
            tmr1.Stop();
                MessageBox.Show("4.at kazandı");
                
                
            }
        }

    }
}
