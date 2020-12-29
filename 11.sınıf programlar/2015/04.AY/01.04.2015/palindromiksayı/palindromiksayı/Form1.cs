using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace palindromiksayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı;
        string sayınıntersi="", stringsayı , topla;
        private void btntamm_Click(object sender, EventArgs e)
        {
            sayınıntersi = "";
            listBox1.Items.Clear();
            Random rnd = new Random();
            sayı = rnd.Next(10,100);
            txtüretilensayı.Text = sayı.ToString(); 
            sayıyıterscevir(sayı);
            sayıhesapla();

        }
        void sayıhesapla()
        {
            do
            {
                 topla=(sayı + int.Parse(sayınıntersi)).ToString();
                 listBox1.Items.Add(sayı + "+" + int.Parse(sayınıntersi)+"="+topla );
                 sayı = int.Parse(topla);
                 sayıyıterscevir(sayı);
            } while (sayı.ToString()!=sayınıntersi);   
        }
        void sayıyıterscevir(int sayıne)
        {
             stringsayı = sayıne.ToString();
             sayınıntersi = "";
            for (int i = stringsayı.Length; i > 0; i--)
            {
                 sayınıntersi += stringsayı[i-1];
            }
            
        }
    }
}
