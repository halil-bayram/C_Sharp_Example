namespace takımdagıtımı
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnoluştur = new System.Windows.Forms.Button();
            this.cbxcinsiyet = new System.Windows.Forms.ComboBox();
            this.cmxsınıfseviye = new System.Windows.Forms.ComboBox();
            this.cbxtakımlar = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.cbxtakımsayısı = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnoluştur);
            this.groupBox1.Controls.Add(this.cbxcinsiyet);
            this.groupBox1.Controls.Add(this.cmxsınıfseviye);
            this.groupBox1.Controls.Add(this.cbxtakımlar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takım Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınıf Seviyesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cinsiyet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spor Türü";
            // 
            // btnoluştur
            // 
            this.btnoluştur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnoluştur.Location = new System.Drawing.Point(321, 77);
            this.btnoluştur.Name = "btnoluştur";
            this.btnoluştur.Size = new System.Drawing.Size(75, 23);
            this.btnoluştur.TabIndex = 1;
            this.btnoluştur.Text = "Oluştur";
            this.btnoluştur.UseVisualStyleBackColor = false;
            this.btnoluştur.Click += new System.EventHandler(this.btnoluştur_Click);
            // 
            // cbxcinsiyet
            // 
            this.cbxcinsiyet.FormattingEnabled = true;
            this.cbxcinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.cbxcinsiyet.Location = new System.Drawing.Point(275, 38);
            this.cbxcinsiyet.Name = "cbxcinsiyet";
            this.cbxcinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cbxcinsiyet.TabIndex = 0;
            // 
            // cmxsınıfseviye
            // 
            this.cmxsınıfseviye.FormattingEnabled = true;
            this.cmxsınıfseviye.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmxsınıfseviye.Location = new System.Drawing.Point(148, 38);
            this.cmxsınıfseviye.Name = "cmxsınıfseviye";
            this.cmxsınıfseviye.Size = new System.Drawing.Size(121, 21);
            this.cmxsınıfseviye.TabIndex = 0;
            // 
            // cbxtakımlar
            // 
            this.cbxtakımlar.FormattingEnabled = true;
            this.cbxtakımlar.Items.AddRange(new object[] {
            "Voleybol",
            "Basketbol",
            "Futbol"});
            this.cbxtakımlar.Location = new System.Drawing.Point(21, 38);
            this.cbxtakımlar.Name = "cbxtakımlar";
            this.cbxtakımlar.Size = new System.Drawing.Size(121, 21);
            this.cbxtakımlar.TabIndex = 0;
            this.cbxtakımlar.SelectedIndexChanged += new System.EventHandler(this.cbxtakımlar_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Controls.Add(this.cbxtakımsayısı);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Takım Secimi";
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnlistele.Location = new System.Drawing.Point(321, 47);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // cbxtakımsayısı
            // 
            this.cbxtakımsayısı.FormattingEnabled = true;
            this.cbxtakımsayısı.Location = new System.Drawing.Point(21, 49);
            this.cbxtakımsayısı.Name = "cbxtakımsayısı";
            this.cbxtakımsayısı.Size = new System.Drawing.Size(121, 21);
            this.cbxtakımsayısı.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Takım Sayısı";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(450, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(576, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 225);
            this.listBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Soyad";
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(429, 293);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnoluştur;
        private System.Windows.Forms.ComboBox cbxcinsiyet;
        private System.Windows.Forms.ComboBox cmxsınıfseviye;
        private System.Windows.Forms.ComboBox cbxtakımlar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.ComboBox cbxtakımsayısı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmr1;
    }
}

