using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notdefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kayıtyeri;
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaac = new OpenFileDialog();
            dosyaac.Title = "Dosya Ac";
            dosyaac.Filter = "text dosyası|*.txt";
            dosyaac.FilterIndex = 1;
            if (dosyaac.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(dosyaac.FileName, RichTextBoxStreamType.UnicodePlainText);
                kayıtyeri = dosyaac.FileName;
            }
            else
            {
                MessageBox.Show("Bir metin giriniz!!!");
            }


        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kayıtyeri == null)
            {
                farklıKaydetToolStripMenuItem_Click(sender, e);
            }
            if (kayıtyeri != null)
            {
                richTextBox1.SaveFile(kayıtyeri, RichTextBoxStreamType.UnicodePlainText);
            }


        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontlar = new FontDialog();
            if (fontlar.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontlar.Font;
            }

        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog yazırengi = new ColorDialog();

            if (yazırengi.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText.Length > 0)
                {
                    richTextBox1.SelectionColor = yazırengi.Color;
                }
                else
                {
                    richTextBox1.ForeColor = yazırengi.Color;
                }

            }
        }
        private void durumÇubuguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (durumÇubuguToolStripMenuItem.Checked)
            {
                statusStrip1.Visible = true;
                DateTime tarih = DateTime.Now;
                string dtarih = tarih.ToLongDateString();
                toolStripStatusLabel1.Text = "tarih:" + dtarih;


            }
            if (!durumÇubuguToolStripMenuItem.Checked)
            {
                statusStrip1.Visible = false;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            statusStrip1.Visible = false;
        }
        int harfsayısı = 1, satırsayısı = 1;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            string[] kelimeler = richTextBox1.Text.Split(' ');

            harfsayısı++;

            toolStripStatusLabel2.Text = "Süt Sayısı: " + harfsayısı.ToString();
            toolStripStatusLabel3.Text = "Kelime Sayısı:  " + kelimeler.Length.ToString();
            toolStripStatusLabel4.Text = " Sat Sayısı:  " + satırsayısı.ToString();

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength == 0)
            {
                richTextBox1.Text = "";

            }
            else if (richTextBox1.TextLength != 0)
            {
                if (MessageBox.Show("işlemlerinizi kaydetmek istermisiniz", " Uyarı!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    kaydetToolStripMenuItem_Click(sender, e);
                    richTextBox1.Text = "";

                }
                else
                {
                    richTextBox1.Text = "";
                }
            }
        }
        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        List<string> satircümle = new List<string>();
        private void richTextBox1_KeyDown(object sender, KeyEventArgs tuş)
        {
            if (tuş.KeyCode == Keys.Return)
            {
                if (richTextBox1.Lines.Count() != 0 && harfsayısı != 0)
                {
                    satircümle.Add(richTextBox1.Lines[satırsayısı - 1]);
                }
                satırsayısı++;
                harfsayısı = 0;
            }
            if (tuş.KeyCode == Keys.Back && richTextBox1.Text.Length > 0)
            {

                harfsayısı -= 2;
                if (harfsayısı < 0)
                {
                    satırsayısı--;
                    harfsayısı = satircümle[satırsayısı - 1].Length;
                }

            }
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void ileriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyafarklıkaydet = new SaveFileDialog();
            dosyafarklıkaydet.ShowDialog();
            dosyafarklıkaydet.Filter = "text dosyası|*.txt";
            dosyafarklıkaydet.FilterIndex = 1;
            if (dosyafarklıkaydet.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(dosyafarklıkaydet.FileName, RichTextBoxStreamType.UnicodePlainText);
                kayıtyeri = dosyafarklıkaydet.FileName;
            }
            else
            {
                MessageBox.Show("Bir Metin Giriniz!!!!!");
            }

        }

        private void tümünüAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yardım frmyardım = new yardım();
            frmyardım.ShowDialog();

        }

        private void arkaPilanResmiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog arkaplanresmi = new ColorDialog();
            if (arkaplanresmi.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = arkaplanresmi.Color;
            }
        }

        private void vurguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog vurgu = new ColorDialog();
            if (vurgu.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = vurgu.Color;
            }
        }
    }
}
