using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sayıbolme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                lstsayılar.Items.Add(rnd.Next(1, 100));
            }

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            lstbolünenler.Items.Clear();

            if (chk3ebölünen.Checked == true && chk4ebölünen.Checked == true && chk5ebölünen.Checked == false)
            {
                for (int i = 0; i < lstsayılar.Items.Count; i++)
                {
                    if (Convert.ToInt32(lstsayılar.Items[i]) % 3 == 0 && Convert.ToInt32(lstsayılar.Items[i]) % 4 == 0)
                    {
                        lstbolünenler.Items.Add(lstsayılar.Items[i]);
                    }
                }
            }
            else if (chk3ebölünen.Checked == true && chk5ebölünen.Checked == true && chk4ebölünen.Checked == false)
            {
                for (int i = 0; i < lstsayılar.Items.Count; i++)
                {
                    if (Convert.ToInt32(lstsayılar.Items[i]) % 3 == 0 && Convert.ToInt32(lstsayılar.Items[i]) % 5 == 0)
                    {
                        lstbolünenler.Items.Add(lstsayılar.Items[i]);
                    }
                }
            }
            else if (chk4ebölünen.Checked == true && chk5ebölünen.Checked == true && chk3ebölünen.Checked == false)
            {
                for (int i = 0; i < lstsayılar.Items.Count; i++)
                {
                    if (Convert.ToInt32(lstsayılar.Items[i]) % 4 == 0 && Convert.ToInt32(lstsayılar.Items[i]) % 5 == 0)
                    {
                        lstbolünenler.Items.Add(lstsayılar.Items[i]);
                    }
                }
            }
            else if (chk3ebölünen.Checked == true && chk5ebölünen.Checked == true && chk4ebölünen.Checked == true)
            {
                for (int i = 0; i < lstsayılar.Items.Count; i++)
                {
                    if (Convert.ToInt32(lstsayılar.Items[i]) % 3 == 0 && Convert.ToInt32(lstsayılar.Items[i]) % 5 == 0 && Convert.ToInt32(lstsayılar.Items[i]) % 4 == 0)
                    {
                        lstbolünenler.Items.Add(lstsayılar.Items[i]);
                    }
                }
            }
            else if (chk3ebölünen.Checked == true)
            {
                for (int i = 0; i < lstsayılar.Items.Count; i++)
                {
                    if (Convert.ToInt32(lstsayılar.Items[i]) % 3 == 0)
                    {
                        lstbolünenler.Items.Add(lstsayılar.Items[i]);
                    }
                }

            }

            else if (chk4ebölünen.Checked == true)
            {
                for (int i = 0; i < lstsayılar.Items.Count; i++)
                {
                    if (Convert.ToInt32(lstsayılar.Items[i]) % 4 == 0)
                    {
                        lstbolünenler.Items.Add(lstsayılar.Items[i]);
                    }
                }

            }
            else if (chk5ebölünen.Checked == true)
            {
                for (int i = 0; i < lstsayılar.Items.Count; i++)
                {
                    if (Convert.ToInt32(lstsayılar.Items[i]) % 5 == 0)
                    {
                        lstbolünenler.Items.Add(lstsayılar.Items[i]);
                    }
                }

            }

        }


    }
}
