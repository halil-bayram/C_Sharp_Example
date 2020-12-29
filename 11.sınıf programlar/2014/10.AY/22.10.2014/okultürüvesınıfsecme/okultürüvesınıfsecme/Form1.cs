using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace okultürüvesınıfsecme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> tl11a = new List<string>() {"HALİL","HÜSEYİN","VELİ","FATİH","EMRE","BURAK","İSMAİL","ALEYNA","AYŞEGÜL","SİBEL","HACER","ASLI" };
        List<string> atl11a = new List<string>() { "ALİ","CAN","TANER","ÖMER","FARUK" };
                
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            listBox1.Items.Clear();
            comboBox2.Items.Add("");
            if (comboBox1.SelectedItem.ToString()=="AMP")
            {
                comboBox2.Items.Add(9);
            }
            else
            {
                comboBox2.Items.Add(10);
                comboBox2.Items.Add(11);
                comboBox2.Items.Add(12);
            }
            comboBox2.SelectedIndex = 0;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==1&&comboBox2.SelectedIndex==2)
            {
                for (int i = 0; i < tl11a.Count; i++)
                {
                    listBox1.Items.Add(tl11a[i]);
                }
            }
            if (comboBox1.SelectedItem.ToString()=="ATL"&&comboBox2.SelectedItem.ToString()=="11")
            {
                for (int i = 0; i < atl11a.Count; i++)
                {
                    listBox1.Items.Add(atl11a[i]);
                }
            }
        }

        
    }
}
