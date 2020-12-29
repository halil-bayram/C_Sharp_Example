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
        string yol = Application.StartupPath;
        private void marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            marka.Text="marka seçiniz";
            model.Items.Clear();
            if (marka.SelectedIndex==0)
            {
                model.Items.Add("audi tt rs");
                model.Items.Add("audi Q7");
            }
            if (marka.SelectedIndex == 1)
            {
                model.Items.Add("bmw x6");
                model.Items.Add("bmw 520");
            }
            if (marka.SelectedIndex == 2)
            {
                model.Items.Add("honda civic");
                model.Items.Add("honda jazz");
            }
            if (marka.SelectedIndex == 3)
            {
                model.Items.Add("nissan qaskqai");
                model.Items.Add("nissan skyline");
            } 
            if (marka.SelectedIndex == 4)
            {
                model.Items.Add("volkswagen golf");
                model.Items.Add("volkswagen beetle");
            }
            if (marka.SelectedIndex == 5)
            {
                model.Items.Add("renault clio");
                model.Items.Add("renault floence");
            }
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Text = "model seçiniz";
            if (marka.SelectedIndex == 0)
            {
                if (model.SelectedIndex==0)
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\audi\\"+ "2.jpg");
                }
                else
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\audi\\" + "1.jpg");
                }
            }
            if (marka.SelectedIndex == 1)
            {
                if (model.SelectedIndex == 0)
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\bmw\\" + "1.jpg");
                }
                else
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\bmw\\" + "2.jpg");
                }
            }
            if (marka.SelectedIndex == 2)
            {
                if (model.SelectedIndex == 0)
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\honda\\" + "1.jpg");
                }
                else
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\honda\\" + "2.jpg");
                }
            }
            if (marka.SelectedIndex == 3)
            {
                if (model.SelectedIndex == 0)
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\nissan\\" + "1.jpg");
                }
                else
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\nissan\\" + "2.jpg");
                }
            }
            if (marka.SelectedIndex == 4)
            {
                if (model.SelectedIndex == 0)
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\volkswagen\\" + "1.jpg");
                }
                else
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\volkswagen\\" + "2.jpg");
                }
            }
            if (marka.SelectedIndex == 5)
            {
                if (model.SelectedIndex == 0)
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\reno\\" + "1.jpg");
                }
                else
                {
                    foto.Image = Image.FromFile(yol + "\\araba\\reno\\" + "2.jpg");
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            marka.Text = "marka seçiniz";
            model.Text = "model seçiniz";
        }
        private void tam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            groupBox1.Dock = DockStyle.Left;
            groupBox2.Dock = DockStyle.Fill;
        }
        private void eski_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            groupBox1.Dock = DockStyle.None;
            groupBox2.Dock = DockStyle.None;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        
    }
}
