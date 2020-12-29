using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arabalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            groupBox1.Dock = DockStyle.Fill;
            groupBox2.Dock = DockStyle.Bottom;
            btntam.Left = (groupBox2.Size.Width / 2)-250;
            btncıkış.Left = groupBox2.Width / 2;

        }

        private void btncıkış_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            groupBox1.Dock = DockStyle.None;
            btntam.Left = (groupBox2.Size.Width / 2)-250;
            btncıkış.Left = groupBox2.Width / 2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
