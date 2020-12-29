using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace butonyönoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbsol.Checked = false;
            rdbsag.Checked = false;
            rdbasagı.Checked = false;
            rdbyukarı.Checked = false;

            rdbsol1.Enabled = false;
            rdbsag1.Enabled = false;
            rdbasagı1.Enabled = false;
            rdbyukarı1.Enabled = false;

        }
        private void rdbyukarı_CheckedChanged(object sender, EventArgs e)
        {
            rdbsag1.Enabled = true;
            rdbsol1.Enabled = true;
            rdbyukarı1.Enabled = true;
            rdbasagı1.Enabled = false;

            rdbyukarı1.Enabled = false;

            rdbsag1.Checked = false;
            rdbsol1.Checked = false;
            rdbasagı1.Checked = false;
            rdbyukarı1.Checked = false;
            tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (rdbyukarı.Checked)
            {
                
                if (btn1.Top <= 0)
                {
                    tmr1.Stop();
                }
                else
                {
                    btn1.Top -= 5;     
                }
            }
            if (rdbasagı.Checked)
            {
                
                if (btn1.Top > grb1.Height - btn1.Height)
                {
                    tmr1.Stop();
                }
                else
                {
                    btn1.Top += 5;
                }
            }
            if (rdbsol.Checked)
            {
                
                if (btn1.Left <= 0)
                {
                    tmr1.Stop();
                }
                else
                {
                        btn1.Left -= 5;
                }
            }
            if (rdbsag.Checked)
            {
               
                if (btn1.Left > grb1.Width - btn1.Width)
                {
                    tmr1.Stop();
                }
                else
                {
                         btn1.Left += 5;
                }
            }

            if (rdbyukarı.Checked && rdbsol1.Checked)
            {
                btn1.Top -= 5;
                btn1.Left -= 5;
                if (btn1.Left <= 0 || btn1.Top <= 0)
                {
                    tmr1.Stop();
                }
            }
            if (rdbyukarı.Checked && rdbsag1.Checked)
            {
                btn1.Top -= 5;
                btn1.Left += 5;
                if (btn1.Left > grb1.Width - btn1.Width || btn1.Top <= 0)
                {
                    tmr1.Stop();
                }
            }
            if (rdbasagı.Checked && rdbsol1.Checked)
            {
                btn1.Top += 5;
                btn1.Left -= 5;
                if (btn1.Top > grb1.Height - btn1.Height || btn1.Left <= 0)
                {
                    tmr1.Stop();
                }
            }
            if (rdbasagı.Checked && rdbsag1.Checked)
            {
                btn1.Top += 5;
                btn1.Left += 5;
                if (btn1.Top > grb1.Height - btn1.Height || btn1.Left > grb1.Width - btn1.Width)
                {
                    tmr1.Stop();
                }
            }
            if (rdbsol.Checked && rdbyukarı1.Checked)
            {
                btn1.Left -= 5;
                btn1.Top -= 5;
                if (btn1.Left <= 0 || btn1.Top <= 0)
                {
                    tmr1.Stop();
                }

            }
            if (rdbsol.Checked && rdbasagı1.Checked)
            {
                btn1.Left -= 5;
                btn1.Top += 5;
                if (btn1.Left <= 0 || btn1.Top > grb1.Height - btn1.Height)
                {
                    tmr1.Stop();
                }

            }
            if (rdbsag.Checked && rdbyukarı1.Checked)
            {
                btn1.Left += 5;
                btn1.Top -= 5;
                if (btn1.Top <= 0 || btn1.Left > grb1.Width - btn1.Width)
                {
                    tmr1.Stop();
                }
            }
            if (rdbsag.Checked && rdbasagı1.Checked)
            {
                btn1.Left += 5;
                btn1.Top += 5;
                if (btn1.Top > grb1.Height - btn1.Height || btn1.Left > grb1.Width - btn1.Width)
                {
                    tmr1.Stop();
                }
            }
        }

        private void rdbasagı_CheckedChanged(object sender, EventArgs e)
        {
            rdbsag1.Enabled = true;
            rdbsol1.Enabled = true;
            rdbasagı1.Enabled = true;
            rdbyukarı1.Enabled = false;

            rdbasagı1.Enabled = false;

            rdbsag1.Checked = false;
            rdbsol1.Checked = false;
            rdbasagı1.Checked = false;
            rdbyukarı1.Checked = false;
            tmr1.Start();
        }

        private void rdbsol_CheckedChanged(object sender, EventArgs e)
        {
            rdbyukarı1.Enabled = true;
            rdbasagı1.Enabled = true;
            rdbsol1.Enabled = true;
            rdbsag1.Enabled = false;

            rdbsol1.Enabled = false;

            rdbsag1.Checked = false;
            rdbsol1.Checked = false;
            rdbasagı1.Checked = false;
            rdbyukarı1.Checked = false;
            tmr1.Start();
        }

        private void rdbsag_CheckedChanged(object sender, EventArgs e)
        {
            rdbyukarı1.Enabled = true;
            rdbasagı1.Enabled = true;
            rdbsag1.Enabled = true;
            rdbsol1.Enabled = false;

            rdbsag1.Enabled = false;

            rdbsag1.Checked = false;
            rdbsol1.Checked = false;
            rdbasagı1.Checked = false;
            rdbyukarı1.Checked = false;
            tmr1.Start();
        }

        private void grb2_Enter(object sender, EventArgs e)
        {

        }








    }
}
