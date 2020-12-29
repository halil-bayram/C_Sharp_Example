using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20._11._2014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
           
            DateTime başlangıc = dtpbaşlangıc.Value;
            DateTime bitiş = dtpbitiş.Value;
            for (DateTime i = başlangıc.AddDays(1); i < bitiş.AddDays(-1); i=i.AddDays(1))
            {
              
                if (i.DayOfWeek.ToString()!="Sunday")
                {
                    listBox1.Items.Add(i.ToLongDateString());
                }
            }
        }

        
    }
}
