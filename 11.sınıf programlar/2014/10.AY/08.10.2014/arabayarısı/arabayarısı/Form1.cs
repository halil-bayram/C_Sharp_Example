using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arabayarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void süre_Tick(object sender, EventArgs e)
        {
            btnaraba.Left += 10;
                if (btnaraba.Left>this.Width-btnaraba.Width)
	{
		 süre.Stop();
	}   
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
 süre.Start();
        }

        
        
    }
}
