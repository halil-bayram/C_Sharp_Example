namespace tarihnöbetci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkbxbölümgünleri = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpbaşlangıc = new System.Windows.Forms.DateTimePicker();
            this.dtpbitiş = new System.Windows.Forms.DateTimePicker();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.lxbsonuclar = new System.Windows.Forms.ListBox();
            this.lxtkişiler = new System.Windows.Forms.ListBox();
            this.btnkişiekle = new System.Windows.Forms.Button();
            this.txtkişiekle = new System.Windows.Forms.TextBox();
            this.btnyenile = new System.Windows.Forms.Button();
            this.grbxdersseçme = new System.Windows.Forms.GroupBox();
            this.grbxsonuc = new System.Windows.Forms.GroupBox();
            this.grbxisimekle = new System.Windows.Forms.GroupBox();
            this.btnkişiekleme = new System.Windows.Forms.Button();
            this.grbxtarih = new System.Windows.Forms.GroupBox();
            this.grbxdersseçme.SuspendLayout();
            this.grbxsonuc.SuspendLayout();
            this.grbxisimekle.SuspendLayout();
            this.grbxtarih.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbxbölümgünleri
            // 
            this.chkbxbölümgünleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkbxbölümgünleri.CheckOnClick = true;
            this.chkbxbölümgünleri.FormattingEnabled = true;
            this.chkbxbölümgünleri.Items.AddRange(new object[] {
            "pazartesi",
            "salı",
            "çarşamba",
            "perşembe",
            "cuma"});
            this.chkbxbölümgünleri.Location = new System.Drawing.Point(7, 36);
            this.chkbxbölümgünleri.Name = "chkbxbölümgünleri";
            this.chkbxbölümgünleri.Size = new System.Drawing.Size(120, 105);
            this.chkbxbölümgünleri.TabIndex = 0;
            this.chkbxbölümgünleri.SelectedIndexChanged += new System.EventHandler(this.chkbxbölümgünleri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "bölüm dersi günler";
            // 
            // dtpbaşlangıc
            // 
            this.dtpbaşlangıc.Location = new System.Drawing.Point(26, 19);
            this.dtpbaşlangıc.Name = "dtpbaşlangıc";
            this.dtpbaşlangıc.Size = new System.Drawing.Size(200, 20);
            this.dtpbaşlangıc.TabIndex = 2;
            // 
            // dtpbitiş
            // 
            this.dtpbitiş.Location = new System.Drawing.Point(26, 45);
            this.dtpbitiş.Name = "dtpbitiş";
            this.dtpbitiş.Size = new System.Drawing.Size(200, 20);
            this.dtpbitiş.TabIndex = 3;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(177, 95);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(281, 42);
            this.btnhesapla.TabIndex = 4;
            this.btnhesapla.Text = "hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // lxbsonuclar
            // 
            this.lxbsonuclar.FormattingEnabled = true;
            this.lxbsonuclar.Location = new System.Drawing.Point(6, 22);
            this.lxbsonuclar.Name = "lxbsonuclar";
            this.lxbsonuclar.Size = new System.Drawing.Size(257, 147);
            this.lxbsonuclar.TabIndex = 5;
            // 
            // lxtkişiler
            // 
            this.lxtkişiler.FormattingEnabled = true;
            this.lxtkişiler.Location = new System.Drawing.Point(10, 16);
            this.lxtkişiler.Name = "lxtkişiler";
            this.lxtkişiler.Size = new System.Drawing.Size(117, 147);
            this.lxtkişiler.TabIndex = 6;
            // 
            // btnkişiekle
            // 
            this.btnkişiekle.Location = new System.Drawing.Point(10, 195);
            this.btnkişiekle.Name = "btnkişiekle";
            this.btnkişiekle.Size = new System.Drawing.Size(117, 23);
            this.btnkişiekle.TabIndex = 8;
            this.btnkişiekle.Text = "Kişi ekle";
            this.btnkişiekle.UseVisualStyleBackColor = true;
            this.btnkişiekle.Click += new System.EventHandler(this.btnkişiekle_Click);
            // 
            // txtkişiekle
            // 
            this.txtkişiekle.Location = new System.Drawing.Point(10, 169);
            this.txtkişiekle.Name = "txtkişiekle";
            this.txtkişiekle.Size = new System.Drawing.Size(117, 20);
            this.txtkişiekle.TabIndex = 9;
            // 
            // btnyenile
            // 
            this.btnyenile.Location = new System.Drawing.Point(177, 143);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(281, 39);
            this.btnyenile.TabIndex = 10;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = true;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // grbxdersseçme
            // 
            this.grbxdersseçme.Controls.Add(this.label1);
            this.grbxdersseçme.Controls.Add(this.chkbxbölümgünleri);
            this.grbxdersseçme.Location = new System.Drawing.Point(12, 12);
            this.grbxdersseçme.Name = "grbxdersseçme";
            this.grbxdersseçme.Size = new System.Drawing.Size(142, 162);
            this.grbxdersseçme.TabIndex = 11;
            this.grbxdersseçme.TabStop = false;
            // 
            // grbxsonuc
            // 
            this.grbxsonuc.Controls.Add(this.lxbsonuclar);
            this.grbxsonuc.Location = new System.Drawing.Point(177, 188);
            this.grbxsonuc.Name = "grbxsonuc";
            this.grbxsonuc.Size = new System.Drawing.Size(281, 175);
            this.grbxsonuc.TabIndex = 12;
            this.grbxsonuc.TabStop = false;
            // 
            // grbxisimekle
            // 
            this.grbxisimekle.Controls.Add(this.btnkişiekleme);
            this.grbxisimekle.Controls.Add(this.txtkişiekle);
            this.grbxisimekle.Controls.Add(this.lxtkişiler);
            this.grbxisimekle.Controls.Add(this.btnkişiekle);
            this.grbxisimekle.Location = new System.Drawing.Point(12, 180);
            this.grbxisimekle.Name = "grbxisimekle";
            this.grbxisimekle.Size = new System.Drawing.Size(142, 264);
            this.grbxisimekle.TabIndex = 13;
            this.grbxisimekle.TabStop = false;
            // 
            // btnkişiekleme
            // 
            this.btnkişiekleme.Location = new System.Drawing.Point(10, 224);
            this.btnkişiekleme.Name = "btnkişiekleme";
            this.btnkişiekleme.Size = new System.Drawing.Size(117, 23);
            this.btnkişiekleme.TabIndex = 10;
            this.btnkişiekleme.Text = "DEVAM";
            this.btnkişiekleme.UseVisualStyleBackColor = true;
            this.btnkişiekleme.Click += new System.EventHandler(this.btnkişiekleme_Click);
            // 
            // grbxtarih
            // 
            this.grbxtarih.Controls.Add(this.dtpbitiş);
            this.grbxtarih.Controls.Add(this.dtpbaşlangıc);
            this.grbxtarih.Location = new System.Drawing.Point(177, 20);
            this.grbxtarih.Name = "grbxtarih";
            this.grbxtarih.Size = new System.Drawing.Size(281, 69);
            this.grbxtarih.TabIndex = 14;
            this.grbxtarih.TabStop = false;
            this.grbxtarih.Enter += new System.EventHandler(this.grbxtarih_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(488, 486);
            this.Controls.Add(this.grbxtarih);
            this.Controls.Add(this.grbxisimekle);
            this.Controls.Add(this.grbxsonuc);
            this.Controls.Add(this.grbxdersseçme);
            this.Controls.Add(this.btnyenile);
            this.Controls.Add(this.btnhesapla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbxdersseçme.ResumeLayout(false);
            this.grbxdersseçme.PerformLayout();
            this.grbxsonuc.ResumeLayout(false);
            this.grbxisimekle.ResumeLayout(false);
            this.grbxisimekle.PerformLayout();
            this.grbxtarih.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkbxbölümgünleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpbaşlangıc;
        private System.Windows.Forms.DateTimePicker dtpbitiş;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.ListBox lxbsonuclar;
        private System.Windows.Forms.ListBox lxtkişiler;
        private System.Windows.Forms.Button btnkişiekle;
        private System.Windows.Forms.TextBox txtkişiekle;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.GroupBox grbxdersseçme;
        private System.Windows.Forms.GroupBox grbxsonuc;
        private System.Windows.Forms.GroupBox grbxisimekle;
        private System.Windows.Forms.GroupBox grbxtarih;
        private System.Windows.Forms.Button btnkişiekleme;
    }
}

