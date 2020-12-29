using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace atasözüoyunu
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
      
       
        static public string isim;
        private void btngiriş_Click(object sender, EventArgs e)
        {
            isim = txtisim.Text;
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
