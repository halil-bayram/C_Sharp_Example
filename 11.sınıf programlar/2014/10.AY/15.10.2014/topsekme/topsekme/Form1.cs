using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace topsekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int altnokta,üstnokta=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            tmr1.Start();
            altnokta = this.Height - btn1.Height*2;
        }
        string yon = "asagı";

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (yon=="asagı")
            {
                btn1.Top += 5;
            }
            if (yon=="yukarı")
            {
                btn1.Top -= 5;
            }
            if (btn1.Top>=altnokta)
            {
                yon = "yukarı";
                üstnokta += ((altnokta - üstnokta) / 4);
            }
            if (btn1.Top<=üstnokta)
            {
                yon = "asagı";
            }
            if (altnokta-üstnokta<5)
            {
                tmr1.Stop();
            }
        }
    }
}
