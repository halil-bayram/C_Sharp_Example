namespace sinemarandevu
{
    partial class satışekranı
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
            this.cmbfilimler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctrbxafiş = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.txtsüre = new System.Windows.Forms.TextBox();
            this.txtyönetmen = new System.Windows.Forms.TextBox();
            this.txttur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxsalon = new System.Windows.Forms.ComboBox();
            this.cmbxseans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnbiletal = new System.Windows.Forms.Button();
            this.rdbiptal = new System.Windows.Forms.RadioButton();
            this.btniptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxafiş)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbfilimler
            // 
            this.cmbfilimler.FormattingEnabled = true;
            this.cmbfilimler.Location = new System.Drawing.Point(81, 19);
            this.cmbfilimler.Name = "cmbfilimler";
            this.cmbfilimler.Size = new System.Drawing.Size(100, 21);
            this.cmbfilimler.TabIndex = 0;
            this.cmbfilimler.SelectedIndexChanged += new System.EventHandler(this.cmbfilimler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filmler";
            // 
            // pctrbxafiş
            // 
            this.pctrbxafiş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrbxafiş.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrbxafiş.Location = new System.Drawing.Point(187, 19);
            this.pctrbxafiş.Name = "pctrbxafiş";
            this.pctrbxafiş.Size = new System.Drawing.Size(142, 230);
            this.pctrbxafiş.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxafiş.TabIndex = 18;
            this.pctrbxafiş.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Konu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Süre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yönetmen";
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(81, 255);
            this.txtkonu.Multiline = true;
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(248, 159);
            this.txtkonu.TabIndex = 9;
            // 
            // txtsüre
            // 
            this.txtsüre.Location = new System.Drawing.Point(81, 130);
            this.txtsüre.Name = "txtsüre";
            this.txtsüre.Size = new System.Drawing.Size(100, 20);
            this.txtsüre.TabIndex = 8;
            // 
            // txtyönetmen
            // 
            this.txtyönetmen.Location = new System.Drawing.Point(81, 55);
            this.txtyönetmen.Name = "txtyönetmen";
            this.txtyönetmen.Size = new System.Drawing.Size(100, 20);
            this.txtyönetmen.TabIndex = 11;
            // 
            // txttur
            // 
            this.txttur.Location = new System.Drawing.Point(81, 90);
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(100, 20);
            this.txttur.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctrbxafiş);
            this.groupBox1.Controls.Add(this.cmbfilimler);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtyönetmen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsüre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttur);
            this.groupBox1.Controls.Add(this.txtkonu);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 439);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // cmbxsalon
            // 
            this.cmbxsalon.FormattingEnabled = true;
            this.cmbxsalon.Location = new System.Drawing.Point(445, 23);
            this.cmbxsalon.Name = "cmbxsalon";
            this.cmbxsalon.Size = new System.Drawing.Size(121, 21);
            this.cmbxsalon.TabIndex = 20;
            // 
            // cmbxseans
            // 
            this.cmbxseans.FormattingEnabled = true;
            this.cmbxseans.Location = new System.Drawing.Point(445, 50);
            this.cmbxseans.Name = "cmbxseans";
            this.cmbxseans.Size = new System.Drawing.Size(121, 21);
            this.cmbxseans.TabIndex = 20;
            this.cmbxseans.SelectedIndexChanged += new System.EventHandler(this.cmbxseans_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Seans:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Salon:";
            // 
            // pnl1
            // 
            this.pnl1.AutoSize = true;
            this.pnl1.Location = new System.Drawing.Point(394, 83);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(247, 354);
            this.pnl1.TabIndex = 22;
            // 
            // btnbiletal
            // 
            this.btnbiletal.Location = new System.Drawing.Point(22, 457);
            this.btnbiletal.Name = "btnbiletal";
            this.btnbiletal.Size = new System.Drawing.Size(350, 48);
            this.btnbiletal.TabIndex = 23;
            this.btnbiletal.Text = "Bilet Al";
            this.btnbiletal.UseVisualStyleBackColor = true;
            this.btnbiletal.Click += new System.EventHandler(this.btnrandevu_Click);
            // 
            // rdbiptal
            // 
            this.rdbiptal.AutoSize = true;
            this.rdbiptal.Location = new System.Drawing.Point(561, 526);
            this.rdbiptal.Name = "rdbiptal";
            this.rdbiptal.Size = new System.Drawing.Size(45, 17);
            this.rdbiptal.TabIndex = 24;
            this.rdbiptal.TabStop = true;
            this.rdbiptal.Text = "İptal";
            this.rdbiptal.UseVisualStyleBackColor = true;
            this.rdbiptal.CheckedChanged += new System.EventHandler(this.rdbiptal_CheckedChanged);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(516, 549);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(150, 48);
            this.btniptal.TabIndex = 25;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // satışekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(806, 637);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.rdbiptal);
            this.Controls.Add(this.btnbiletal);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxseans);
            this.Controls.Add(this.cmbxsalon);
            this.Controls.Add(this.groupBox1);
            this.Name = "satışekranı";
            this.Text = "satışekranı";
            this.Load += new System.EventHandler(this.satışekranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxafiş)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbfilimler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctrbxafiş;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.TextBox txtsüre;
        private System.Windows.Forms.TextBox txtyönetmen;
        private System.Windows.Forms.TextBox txttur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxsalon;
        private System.Windows.Forms.ComboBox cmbxseans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnbiletal;
        private System.Windows.Forms.RadioButton rdbiptal;
        private System.Windows.Forms.Button btniptal;
    }
}