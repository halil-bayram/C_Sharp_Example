using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace adamasmaca
{
    public partial class t : Form
    {
        public t()
        {
            InitializeComponent();
        }
        List<string> kelimelr = new List<string>() { "elma","armut","masa","bilgisayar","program"};
        List<string> ıpucu = new List<string>() {"Agacta yetişir","Ayılar sever","dört ayaklı","Teknolojik bir alettir","bilgisayarda yazılır" };
        Random rnd = new Random();
        string secilenkelime,boskelime="";
        string yol = Application.StartupPath + "\\resimler\\";
        int sayac = 0,sorupuan=0,toplampuan=0;
        private void btnbaşlat_Click(object sender, EventArgs e)
        {
            tmr1.Start();
            txtgirilenkelime.Focus();
            btnbaşlat.Text = "Sonraki";
            btnbaşlat.Enabled = false;
            btnharf.Enabled = true;
            btntahmin.Enabled = true;
            pictureBox1.Image = Image.FromFile(yol + "0.png");
            lblkelime.Text = "kelime:";
            lblipucu.Text = "ipucu:";
            boskelime = "";
            int indeks = rnd.Next(0,kelimelr.Count);
            secilenkelime=kelimelr[indeks];
            prgrsbrzaman.Maximum = (secilenkelime.Length) * 2;
            prgrsbrzaman.Value = prgrsbrzaman.Maximum;
            sorupuan = (secilenkelime.Length) * 10;
            for (int i = 0; i < secilenkelime.Length; i++)
            {
                boskelime += "-";
            }
            for (int i = 0; i < boskelime.Length; i++)
            {
                lblkelime.Text += boskelime[i] + " ";
            }
            lblipucu.Text += ıpucu[indeks];
            kelimelr.RemoveAt(indeks);
            ıpucu.RemoveAt(indeks);
            if (kelimelr.Count==0)
            {
                btnbaşlat.Enabled = false;
            }
        }
        private void t_Load(object sender, EventArgs e)
        {
            
        }
        private void btnharf_Click(object sender, EventArgs e)
        {
            sorupuan-=10;
            lblsorupuan.Text = sorupuan.ToString();
            btnbaşlat.Enabled = true;
            string eskiboskelime;
            eskiboskelime = boskelime;
            boskelime = "";
            bool varmı=false;
            for (int i = 0; i < secilenkelime.Length; i++)
            {
                if (txtgirilenkelime.Text==secilenkelime[i].ToString())
                {
                    boskelime += secilenkelime[i];
                    varmı = true;
                }
                else
                {
                    boskelime += eskiboskelime[i];
                }
            }
            if (varmı==true)
            {
                lblkelime.Text = "Kelime:";
                for (int i = 0; i < boskelime.Length; i++)
                {
                    lblkelime.Text += boskelime[i] + " ";
                }
                btnbaşlat.Enabled = true;
            }
            else if (varmı==false)
            {
                sayac++;
                pictureBox1.Image = Image.FromFile(yol + sayac + ".png");
            }
            txtgirilenkelime.Text = "";
        }
        private void btntahmin_Click(object sender, EventArgs e)
        {
            tmr1.Stop();
            btnbaşlat.Enabled = true;
            txtgirilenkelime.MaxLength = secilenkelime.Length;
            if (secilenkelime.Length == txtgirilenkelime.Text.Length || boskelime == secilenkelime)
            {
                    toplampuan += sorupuan + sayac * 5;
                lbltoplampuan.Text = toplampuan.ToString();
                sayac = 0;
                for (int i = 0; i < secilenkelime.Length; i++)
                {
                    if (secilenkelime[i] == txtgirilenkelime.Text[i])
                    {
                        MessageBox.Show("aferin dogru cevap");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("yanlış cevap");
                    }
                }   
            }
            txtgirilenkelime.Text = "";          
        }
        private void txtgirilenkelime_TextChanged(object sender, EventArgs e)
        {
            btnbaşlat.Enabled = true;
        }
        private void tmr1_Tick(object sender, EventArgs e)
        {
            sayac++;
             prgrsbrzaman.Value--;    
            if (prgrsbrzaman.Value==0)
            {
                tmr1.Stop();
                MessageBox.Show("süreniz bitti");
            }   
        }
    }
}
