namespace sinemarandevu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtfilimadı = new System.Windows.Forms.TextBox();
            this.txtyönetmen = new System.Windows.Forms.TextBox();
            this.txtsüre = new System.Windows.Forms.TextBox();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngöster = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbturler = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbsalonsecimi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chklstseanslar = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfilimadı
            // 
            this.txtfilimadı.Location = new System.Drawing.Point(92, 12);
            this.txtfilimadı.Name = "txtfilimadı";
            this.txtfilimadı.Size = new System.Drawing.Size(100, 20);
            this.txtfilimadı.TabIndex = 0;
            // 
            // txtyönetmen
            // 
            this.txtyönetmen.Location = new System.Drawing.Point(92, 38);
            this.txtyönetmen.Name = "txtyönetmen";
            this.txtyönetmen.Size = new System.Drawing.Size(100, 20);
            this.txtyönetmen.TabIndex = 0;
            // 
            // txtsüre
            // 
            this.txtsüre.Location = new System.Drawing.Point(92, 90);
            this.txtsüre.Name = "txtsüre";
            this.txtsüre.Size = new System.Drawing.Size(100, 20);
            this.txtsüre.TabIndex = 0;
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(92, 116);
            this.txtkonu.Multiline = true;
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(185, 159);
            this.txtkonu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Konu";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(502, 252);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngöster
            // 
            this.btngöster.Location = new System.Drawing.Point(299, 252);
            this.btngöster.Name = "btngöster";
            this.btngöster.Size = new System.Drawing.Size(75, 23);
            this.btngöster.TabIndex = 5;
            this.btngöster.Text = "Göster";
            this.btngöster.UseVisualStyleBackColor = true;
            this.btngöster.Click += new System.EventHandler(this.btngöster_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(299, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbturler
            // 
            this.cmbturler.FormattingEnabled = true;
            this.cmbturler.Location = new System.Drawing.Point(92, 64);
            this.cmbturler.Name = "cmbturler";
            this.cmbturler.Size = new System.Drawing.Size(100, 21);
            this.cmbturler.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 291);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bilet Satışına Gec";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbsalonsecimi
            // 
            this.cmbsalonsecimi.FormattingEnabled = true;
            this.cmbsalonsecimi.Location = new System.Drawing.Point(502, 15);
            this.cmbsalonsecimi.Name = "cmbsalonsecimi";
            this.cmbsalonsecimi.Size = new System.Drawing.Size(121, 21);
            this.cmbsalonsecimi.TabIndex = 9;
            this.cmbsalonsecimi.SelectedIndexChanged += new System.EventHandler(this.cmbsalonsecimi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salon";
            // 
            // chklstseanslar
            // 
            this.chklstseanslar.CheckOnClick = true;
            this.chklstseanslar.FormattingEnabled = true;
            this.chklstseanslar.Location = new System.Drawing.Point(465, 58);
            this.chklstseanslar.MultiColumn = true;
            this.chklstseanslar.Name = "chklstseanslar";
            this.chklstseanslar.Size = new System.Drawing.Size(191, 184);
            this.chklstseanslar.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 319);
            this.Controls.Add(this.chklstseanslar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbsalonsecimi);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmbturler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btngöster);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.txtsüre);
            this.Controls.Add(this.txtyönetmen);
            this.Controls.Add(this.txtfilimadı);
            this.Name = "Form1";
            this.Text = "Film Ekle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfilimadı;
        private System.Windows.Forms.TextBox txtyönetmen;
        private System.Windows.Forms.TextBox txtsüre;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngöster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbturler;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbsalonsecimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox chklstseanslar;
    }
}

