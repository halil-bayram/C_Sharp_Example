using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kangrubu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            cbxkangrubu.Items.Add("");

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
            lstbkisiler.Items.Add(txtbadsoyad.Text);
            lstkangrubu.Items.Add(cbxkangrubu.SelectedItem);
            txtbadsoyad.Text = "";
            cbxkangrubu.SelectedIndex = 8;

        }

        private void cbxdonörkangrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstdonöradı.Items.Clear();
            lstdonörkangrubu.Items.Clear();

            for (int i = 0; i < lstkangrubu.Items.Count; i++)
            {
                
                 if (cbxdonörkangrubu.SelectedItem.ToString()=="AB Rh+")
                {
                    lstdonörkangrubu.Items.Add(lstkangrubu.Items[i]);
                    lstdonöradı.Items.Add(lstbkisiler.Items[i]);
                }
                 if (cbxdonörkangrubu.SelectedItem.ToString() == "AB Rh-")
                {
                    if (lstkangrubu.Items[i].ToString()=="O Rh-"||lstkangrubu.Items[i].ToString()=="A Rh-"||lstkangrubu.Items[i].ToString()=="B Rh-"||lstkangrubu.Items[i].ToString()=="AB Rh-")
                    {
                        lstdonöradı.Items.Add(lstbkisiler.Items[i]);
                        lstdonörkangrubu.Items.Add(lstkangrubu.Items[i]);
                    }
                }
                 if (cbxdonörkangrubu.SelectedItem.ToString() == "A Rh+")
                {
                    if (lstkangrubu.Items[i].ToString() == "O Rh-" || lstkangrubu.Items[i].ToString() == "O Rh+" || lstkangrubu.Items[i].ToString() == "A Rh-" || lstkangrubu.Items[i].ToString() == "A Rh+")
                    {
                        lstdonöradı.Items.Add(lstbkisiler.Items[i]);
                        lstdonörkangrubu.Items.Add(lstkangrubu.Items[i]);
                    }
                }
                 if (cbxdonörkangrubu.SelectedItem.ToString() == "A Rh-")
                {
                    if (lstkangrubu.Items[i].ToString() == "A Rh-" || lstkangrubu.Items[i].ToString() == "A Rh+" )
                    {
                        lstdonöradı.Items.Add(lstbkisiler.Items[i]);
                        lstdonörkangrubu.Items.Add(lstkangrubu.Items[i]);
                    }
                }
                 if (cbxdonörkangrubu.SelectedItem.ToString() == "B Rh+")
                {
                    if (lstkangrubu.Items[i].ToString() == "O Rh-" || lstkangrubu.Items[i].ToString() == "O Rh+" || lstkangrubu.Items[i].ToString() == "B Rh-" || lstkangrubu.Items[i].ToString() == "B Rh+")
                    {
                        lstdonöradı.Items.Add(lstbkisiler.Items[i]);
                        lstdonörkangrubu.Items.Add(lstkangrubu.Items[i]);
                    }
                }
                 if (cbxdonörkangrubu.SelectedItem.ToString() == "B Rh-")
                {
                    if (lstkangrubu.Items[i].ToString() == "O Rh-" || lstkangrubu.Items[i].ToString() == "B Rh-")
                    {
                        lstdonöradı.Items.Add(lstbkisiler.Items[i]);
                        lstdonörkangrubu.Items.Add(lstkangrubu.Items[i]);
                    }
                }
                 if (cbxdonörkangrubu.SelectedItem.ToString() == "O Rh+")
                {
                    if (lstkangrubu.Items[i].ToString() == "O Rh-" || lstkangrubu.Items[i].ToString() == "O Rh+" )
                    {
                        lstdonöradı.Items.Add(lstbkisiler.Items[i]);
                        lstdonörkangrubu.Items.Add(lstkangrubu.Items[i]);
                    }
                }
                 if (cbxdonörkangrubu.SelectedItem.ToString() == "O Rh-")
                {
                    if (lstkangrubu.Items[i].ToString() == "O Rh-")
                    {
                        lstdonöradı.Items.Add(lstbkisiler.Items[i]);
                        lstdonörkangrubu.Items.Add(lstkangrubu.Items[i]);
                    }
                }
            }
            
        }

    }
}
