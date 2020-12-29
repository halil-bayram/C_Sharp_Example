using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace üyekayıt
{
    public partial class programagiriş : Form
    {
        public programagiriş()
        {
            InitializeComponent();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giriş frmgiriş = new Giriş();
            frmgiriş.ShowDialog();
        }
    }
}
