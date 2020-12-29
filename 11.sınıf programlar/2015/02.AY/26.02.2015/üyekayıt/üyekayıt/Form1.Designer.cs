namespace üyekayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkullanıcıadı = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtşifretekrar = new System.Windows.Forms.TextBox();
            this.txtadı = new System.Windows.Forms.TextBox();
            this.txtsoyadı = new System.Windows.Forms.TextBox();
            this.txtgüvenliksorusucevabı = new System.Windows.Forms.TextBox();
            this.rdberkek = new System.Windows.Forms.RadioButton();
            this.rdbkız = new System.Windows.Forms.RadioButton();
            this.dtpdtarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbil = new System.Windows.Forms.ComboBox();
            this.cbilce = new System.Windows.Forms.ComboBox();
            this.cbgüvenliksorusu = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lnklblgiriş = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "İl:";
            // 
            // txtkullanıcıadı
            // 
            this.txtkullanıcıadı.Location = new System.Drawing.Point(149, 23);
            this.txtkullanıcıadı.Name = "txtkullanıcıadı";
            this.txtkullanıcıadı.Size = new System.Drawing.Size(176, 20);
            this.txtkullanıcıadı.TabIndex = 1;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(149, 49);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(176, 20);
            this.txtsifre.TabIndex = 1;
            // 
            // txtşifretekrar
            // 
            this.txtşifretekrar.Location = new System.Drawing.Point(149, 75);
            this.txtşifretekrar.Name = "txtşifretekrar";
            this.txtşifretekrar.Size = new System.Drawing.Size(176, 20);
            this.txtşifretekrar.TabIndex = 1;
            // 
            // txtadı
            // 
            this.txtadı.Location = new System.Drawing.Point(149, 101);
            this.txtadı.Name = "txtadı";
            this.txtadı.Size = new System.Drawing.Size(176, 20);
            this.txtadı.TabIndex = 1;
            this.txtadı.TextChanged += new System.EventHandler(this.txtadı_TextChanged);
            // 
            // txtsoyadı
            // 
            this.txtsoyadı.Location = new System.Drawing.Point(149, 127);
            this.txtsoyadı.Name = "txtsoyadı";
            this.txtsoyadı.Size = new System.Drawing.Size(176, 20);
            this.txtsoyadı.TabIndex = 1;
            // 
            // txtgüvenliksorusucevabı
            // 
            this.txtgüvenliksorusucevabı.Location = new System.Drawing.Point(149, 319);
            this.txtgüvenliksorusucevabı.Name = "txtgüvenliksorusucevabı";
            this.txtgüvenliksorusucevabı.Size = new System.Drawing.Size(176, 20);
            this.txtgüvenliksorusucevabı.TabIndex = 1;
            // 
            // rdberkek
            // 
            this.rdberkek.AutoSize = true;
            this.rdberkek.Location = new System.Drawing.Point(149, 153);
            this.rdberkek.Name = "rdberkek";
            this.rdberkek.Size = new System.Drawing.Size(53, 17);
            this.rdberkek.TabIndex = 2;
            this.rdberkek.TabStop = true;
            this.rdberkek.Text = "Erkek";
            this.rdberkek.UseVisualStyleBackColor = true;
            // 
            // rdbkız
            // 
            this.rdbkız.AutoSize = true;
            this.rdbkız.Location = new System.Drawing.Point(240, 153);
            this.rdbkız.Name = "rdbkız";
            this.rdbkız.Size = new System.Drawing.Size(39, 17);
            this.rdbkız.TabIndex = 2;
            this.rdbkız.TabStop = true;
            this.rdbkız.Text = "Kız";
            this.rdbkız.UseVisualStyleBackColor = true;
            // 
            // dtpdtarih
            // 
            this.dtpdtarih.Location = new System.Drawing.Point(149, 185);
            this.dtpdtarih.Name = "dtpdtarih";
            this.dtpdtarih.Size = new System.Drawing.Size(176, 20);
            this.dtpdtarih.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "İlçe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Güvenlik Sorusu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Güvenlik Sorusu Cevabı:";
            // 
            // cbil
            // 
            this.cbil.FormattingEnabled = true;
            this.cbil.Location = new System.Drawing.Point(149, 214);
            this.cbil.Name = "cbil";
            this.cbil.Size = new System.Drawing.Size(176, 21);
            this.cbil.TabIndex = 5;
            this.cbil.SelectedIndexChanged += new System.EventHandler(this.cbil_SelectedIndexChanged);
            // 
            // cbilce
            // 
            this.cbilce.FormattingEnabled = true;
            this.cbilce.Location = new System.Drawing.Point(149, 241);
            this.cbilce.Name = "cbilce";
            this.cbilce.Size = new System.Drawing.Size(176, 21);
            this.cbilce.TabIndex = 5;
            // 
            // cbgüvenliksorusu
            // 
            this.cbgüvenliksorusu.FormattingEnabled = true;
            this.cbgüvenliksorusu.Items.AddRange(new object[] {
            "Çocukluk arkadaşın",
            "En sevdigin Hayvan",
            "En Sevdigin Arkadaşın"});
            this.cbgüvenliksorusu.Location = new System.Drawing.Point(149, 288);
            this.cbgüvenliksorusu.Name = "cbgüvenliksorusu";
            this.cbgüvenliksorusu.Size = new System.Drawing.Size(176, 21);
            this.cbgüvenliksorusu.TabIndex = 5;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(149, 369);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lnklblgiriş
            // 
            this.lnklblgiriş.AutoSize = true;
            this.lnklblgiriş.Location = new System.Drawing.Point(340, 379);
            this.lnklblgiriş.Name = "lnklblgiriş";
            this.lnklblgiriş.Size = new System.Drawing.Size(49, 13);
            this.lnklblgiriş.TabIndex = 7;
            this.lnklblgiriş.TabStop = true;
            this.lnklblgiriş.Text = "Giriş Yap";
            this.lnklblgiriş.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblgiriş_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 421);
            this.Controls.Add(this.lnklblgiriş);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.cbgüvenliksorusu);
            this.Controls.Add(this.cbilce);
            this.Controls.Add(this.cbil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpdtarih);
            this.Controls.Add(this.rdbkız);
            this.Controls.Add(this.rdberkek);
            this.Controls.Add(this.txtgüvenliksorusucevabı);
            this.Controls.Add(this.txtsoyadı);
            this.Controls.Add(this.txtadı);
            this.Controls.Add(this.txtşifretekrar);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanıcıadı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkullanıcıadı;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtşifretekrar;
        private System.Windows.Forms.TextBox txtadı;
        private System.Windows.Forms.TextBox txtsoyadı;
        private System.Windows.Forms.TextBox txtgüvenliksorusucevabı;
        private System.Windows.Forms.RadioButton rdberkek;
        private System.Windows.Forms.RadioButton rdbkız;
        private System.Windows.Forms.DateTimePicker dtpdtarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbil;
        private System.Windows.Forms.ComboBox cbilce;
        private System.Windows.Forms.ComboBox cbgüvenliksorusu;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.LinkLabel lnklblgiriş;
    }
}

