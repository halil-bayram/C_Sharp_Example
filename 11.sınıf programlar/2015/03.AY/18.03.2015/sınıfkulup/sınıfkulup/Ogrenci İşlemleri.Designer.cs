namespace sınıfkulup
{
    partial class Ogrenci_İşlemleri
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdberkek = new System.Windows.Forms.RadioButton();
            this.rdbkız = new System.Windows.Forms.RadioButton();
            this.txtsoyadı = new System.Windows.Forms.TextBox();
            this.txtadı = new System.Windows.Forms.TextBox();
            this.cmbokulno = new System.Windows.Forms.ComboBox();
            this.cmbsınıf = new System.Windows.Forms.ComboBox();
            this.cmbokultürü = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combx2sınıf = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbx2okultürü = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(9, 222);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btngüncelle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdberkek);
            this.groupBox1.Controls.Add(this.rdbkız);
            this.groupBox1.Controls.Add(this.txtsoyadı);
            this.groupBox1.Controls.Add(this.txtadı);
            this.groupBox1.Controls.Add(this.cmbokulno);
            this.groupBox1.Controls.Add(this.cmbsınıf);
            this.groupBox1.Controls.Add(this.cmbokultürü);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ögrenci İşlemleri";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(171, 222);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(90, 222);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 23);
            this.btngüncelle.TabIndex = 6;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Okul No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sınıf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Okul Türü";
            // 
            // rdberkek
            // 
            this.rdberkek.AutoSize = true;
            this.rdberkek.Location = new System.Drawing.Point(131, 155);
            this.rdberkek.Name = "rdberkek";
            this.rdberkek.Size = new System.Drawing.Size(53, 17);
            this.rdberkek.TabIndex = 4;
            this.rdberkek.TabStop = true;
            this.rdberkek.Text = "Erkek";
            this.rdberkek.UseVisualStyleBackColor = true;
            this.rdberkek.CheckedChanged += new System.EventHandler(this.rdberkek_CheckedChanged);
            // 
            // rdbkız
            // 
            this.rdbkız.AutoSize = true;
            this.rdbkız.Location = new System.Drawing.Point(63, 157);
            this.rdbkız.Name = "rdbkız";
            this.rdbkız.Size = new System.Drawing.Size(39, 17);
            this.rdbkız.TabIndex = 3;
            this.rdbkız.TabStop = true;
            this.rdbkız.Text = "Kız";
            this.rdbkız.UseVisualStyleBackColor = true;
            this.rdbkız.CheckedChanged += new System.EventHandler(this.rdbkız_CheckedChanged);
            // 
            // txtsoyadı
            // 
            this.txtsoyadı.Location = new System.Drawing.Point(63, 131);
            this.txtsoyadı.Name = "txtsoyadı";
            this.txtsoyadı.Size = new System.Drawing.Size(100, 20);
            this.txtsoyadı.TabIndex = 2;
            // 
            // txtadı
            // 
            this.txtadı.Location = new System.Drawing.Point(63, 105);
            this.txtadı.Name = "txtadı";
            this.txtadı.Size = new System.Drawing.Size(100, 20);
            this.txtadı.TabIndex = 2;
            // 
            // cmbokulno
            // 
            this.cmbokulno.FormattingEnabled = true;
            this.cmbokulno.Location = new System.Drawing.Point(63, 78);
            this.cmbokulno.Name = "cmbokulno";
            this.cmbokulno.Size = new System.Drawing.Size(121, 21);
            this.cmbokulno.TabIndex = 1;
            // 
            // cmbsınıf
            // 
            this.cmbsınıf.FormattingEnabled = true;
            this.cmbsınıf.Location = new System.Drawing.Point(63, 51);
            this.cmbsınıf.Name = "cmbsınıf";
            this.cmbsınıf.Size = new System.Drawing.Size(121, 21);
            this.cmbsınıf.TabIndex = 1;
            // 
            // cmbokultürü
            // 
            this.cmbokultürü.FormattingEnabled = true;
            this.cmbokultürü.Location = new System.Drawing.Point(63, 24);
            this.cmbokultürü.Name = "cmbokultürü";
            this.cmbokultürü.Size = new System.Drawing.Size(121, 21);
            this.cmbokultürü.TabIndex = 1;
            this.cmbokultürü.SelectedIndexChanged += new System.EventHandler(this.cmbokultürü_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.combx2sınıf);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbx2okultürü);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(316, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ögrenci Bilgilerini Görüntüle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sınıf";
            // 
            // combx2sınıf
            // 
            this.combx2sınıf.FormattingEnabled = true;
            this.combx2sınıf.Location = new System.Drawing.Point(282, 18);
            this.combx2sınıf.Name = "combx2sınıf";
            this.combx2sınıf.Size = new System.Drawing.Size(121, 21);
            this.combx2sınıf.TabIndex = 8;
            this.combx2sınıf.SelectedIndexChanged += new System.EventHandler(this.combx2sınıf_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Okul Türü";
            // 
            // cmbx2okultürü
            // 
            this.cmbx2okultürü.FormattingEnabled = true;
            this.cmbx2okultürü.Location = new System.Drawing.Point(75, 18);
            this.cmbx2okultürü.Name = "cmbx2okultürü";
            this.cmbx2okultürü.Size = new System.Drawing.Size(121, 21);
            this.cmbx2okultürü.TabIndex = 6;
            this.cmbx2okultürü.SelectedIndexChanged += new System.EventHandler(this.cmbx2okultürü_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ogrenci_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ogrenci_İşlemleri";
            this.Text = "Ogrenci_İşlemleri";
            this.Load += new System.EventHandler(this.Ogrenci_İşlemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdberkek;
        private System.Windows.Forms.RadioButton rdbkız;
        private System.Windows.Forms.TextBox txtsoyadı;
        private System.Windows.Forms.TextBox txtadı;
        private System.Windows.Forms.ComboBox cmbokulno;
        private System.Windows.Forms.ComboBox cmbsınıf;
        private System.Windows.Forms.ComboBox cmbokultürü;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combx2sınıf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbx2okultürü;
    }
}