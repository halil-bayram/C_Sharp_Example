using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ikinciderecedendeklemcözme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            label9.Text = "";
            double d,x1,x2,a, b, c;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
            d=(b*b)-(4*a*c);
            if (d>0)
            {
                x1 = ((b * -1) + Math.Sqrt(d)) / (2 * a);
                x2 = ((b * -1) - Math.Sqrt(d)) / (2 * a);
                label8.Text = "X1= " + x1;
                label9.Text = "x2= " + x2;
            }
            else if (d<0)
            {
                MessageBox.Show("Denklemin Reel Kökleri Yoktur!");
            }
            else if (d==0)
            {
                x1 = (b * -1) / (2 * a);
                label8.Text = "X1= " + x1+"Bir Kökü Vardır";
                
            }
        }
    }
}
