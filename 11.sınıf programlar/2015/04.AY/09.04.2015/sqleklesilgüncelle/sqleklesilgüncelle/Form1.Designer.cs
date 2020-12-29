namespace sqleklesilgüncelle
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsbyenikayıt = new System.Windows.Forms.ToolStripButton();
            this.tlsbKaydet = new System.Windows.Forms.ToolStripButton();
            this.tlsbgüncelle = new System.Windows.Forms.ToolStripButton();
            this.tlsbsil = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtvki = new System.Windows.Forms.TextBox();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.txtboy = new System.Windows.Forms.TextBox();
            this.txtcinsiyet = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdeger = new System.Windows.Forms.TextBox();
            this.txtve = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.cmbxkriter = new System.Windows.Forms.ComboBox();
            this.cmbxalan = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbyenikayıt,
            this.tlsbKaydet,
            this.tlsbgüncelle,
            this.tlsbsil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsbyenikayıt
            // 
            this.tlsbyenikayıt.BackColor = System.Drawing.Color.Gray;
            this.tlsbyenikayıt.ForeColor = System.Drawing.Color.White;
            this.tlsbyenikayıt.Image = ((System.Drawing.Image)(resources.GetObject("tlsbyenikayıt.Image")));
            this.tlsbyenikayıt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbyenikayıt.Name = "tlsbyenikayıt";
            this.tlsbyenikayıt.Size = new System.Drawing.Size(79, 22);
            this.tlsbyenikayıt.Text = "Yeni Kayıt";
            this.tlsbyenikayıt.Click += new System.EventHandler(this.tlsbyenikayıt_Click);
            // 
            // tlsbKaydet
            // 
            this.tlsbKaydet.BackColor = System.Drawing.Color.Gray;
            this.tlsbKaydet.ForeColor = System.Drawing.Color.White;
            this.tlsbKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tlsbKaydet.Image")));
            this.tlsbKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbKaydet.Name = "tlsbKaydet";
            this.tlsbKaydet.Size = new System.Drawing.Size(63, 22);
            this.tlsbKaydet.Text = "Kaydet";
            this.tlsbKaydet.Click += new System.EventHandler(this.tlsbKaydet_Click);
            // 
            // tlsbgüncelle
            // 
            this.tlsbgüncelle.BackColor = System.Drawing.Color.Gray;
            this.tlsbgüncelle.ForeColor = System.Drawing.Color.White;
            this.tlsbgüncelle.Image = ((System.Drawing.Image)(resources.GetObject("tlsbgüncelle.Image")));
            this.tlsbgüncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbgüncelle.Name = "tlsbgüncelle";
            this.tlsbgüncelle.Size = new System.Drawing.Size(73, 22);
            this.tlsbgüncelle.Text = "Güncelle";
            this.tlsbgüncelle.Click += new System.EventHandler(this.tlsbgüncelle_Click);
            // 
            // tlsbsil
            // 
            this.tlsbsil.BackColor = System.Drawing.Color.Gray;
            this.tlsbsil.ForeColor = System.Drawing.Color.White;
            this.tlsbsil.Image = ((System.Drawing.Image)(resources.GetObject("tlsbsil.Image")));
            this.tlsbsil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbsil.Name = "tlsbsil";
            this.tlsbsil.Size = new System.Drawing.Size(39, 22);
            this.tlsbsil.Text = "Sil";
            this.tlsbsil.Click += new System.EventHandler(this.tlsbsil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtvki);
            this.groupBox1.Controls.Add(this.txtkilo);
            this.groupBox1.Controls.Add(this.txtboy);
            this.groupBox1.Controls.Add(this.txtcinsiyet);
            this.groupBox1.Controls.Add(this.txtadsoyad);
            this.groupBox1.Controls.Add(this.txtno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ögrenci Bilgileri";
            // 
            // txtvki
            // 
            this.txtvki.BackColor = System.Drawing.Color.Beige;
            this.txtvki.Enabled = false;
            this.txtvki.Location = new System.Drawing.Point(216, 65);
            this.txtvki.Name = "txtvki";
            this.txtvki.Size = new System.Drawing.Size(100, 20);
            this.txtvki.TabIndex = 11;
            // 
            // txtkilo
            // 
            this.txtkilo.BackColor = System.Drawing.Color.Beige;
            this.txtkilo.Location = new System.Drawing.Point(215, 13);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(100, 20);
            this.txtkilo.TabIndex = 10;
            // 
            // txtboy
            // 
            this.txtboy.BackColor = System.Drawing.Color.Beige;
            this.txtboy.Location = new System.Drawing.Point(215, 39);
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(100, 20);
            this.txtboy.TabIndex = 9;
            // 
            // txtcinsiyet
            // 
            this.txtcinsiyet.BackColor = System.Drawing.Color.Beige;
            this.txtcinsiyet.Location = new System.Drawing.Point(76, 65);
            this.txtcinsiyet.Name = "txtcinsiyet";
            this.txtcinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtcinsiyet.TabIndex = 8;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.BackColor = System.Drawing.Color.Beige;
            this.txtadsoyad.Location = new System.Drawing.Point(76, 39);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtadsoyad.TabIndex = 7;
            // 
            // txtno
            // 
            this.txtno.BackColor = System.Drawing.Color.Beige;
            this.txtno.Location = new System.Drawing.Point(76, 13);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vki:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Boy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ögrenci No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 130);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Alan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kriter:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ve:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Değer:";
            // 
            // txtdeger
            // 
            this.txtdeger.BackColor = System.Drawing.Color.Beige;
            this.txtdeger.Location = new System.Drawing.Point(59, 50);
            this.txtdeger.Name = "txtdeger";
            this.txtdeger.Size = new System.Drawing.Size(100, 20);
            this.txtdeger.TabIndex = 8;
            // 
            // txtve
            // 
            this.txtve.BackColor = System.Drawing.Color.Beige;
            this.txtve.Location = new System.Drawing.Point(205, 47);
            this.txtve.Name = "txtve";
            this.txtve.Size = new System.Drawing.Size(100, 20);
            this.txtve.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnbul);
            this.groupBox2.Controls.Add(this.cmbxkriter);
            this.groupBox2.Controls.Add(this.cmbxalan);
            this.groupBox2.Controls.Add(this.txtve);
            this.groupBox2.Controls.Add(this.txtdeger);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(346, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // btnbul
            // 
            this.btnbul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbul.ForeColor = System.Drawing.Color.White;
            this.btnbul.Location = new System.Drawing.Point(230, 73);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(75, 23);
            this.btnbul.TabIndex = 13;
            this.btnbul.Text = "Bul";
            this.btnbul.UseVisualStyleBackColor = false;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // cmbxkriter
            // 
            this.cmbxkriter.BackColor = System.Drawing.Color.Beige;
            this.cmbxkriter.FormattingEnabled = true;
            this.cmbxkriter.Location = new System.Drawing.Point(205, 23);
            this.cmbxkriter.Name = "cmbxkriter";
            this.cmbxkriter.Size = new System.Drawing.Size(100, 21);
            this.cmbxkriter.TabIndex = 12;
            // 
            // cmbxalan
            // 
            this.cmbxalan.BackColor = System.Drawing.Color.Beige;
            this.cmbxalan.FormattingEnabled = true;
            this.cmbxalan.Location = new System.Drawing.Point(59, 23);
            this.cmbxalan.Name = "cmbxalan";
            this.cmbxalan.Size = new System.Drawing.Size(100, 21);
            this.cmbxalan.TabIndex = 11;
            this.cmbxalan.SelectedIndexChanged += new System.EventHandler(this.cmbxalan_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(681, 283);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsbyenikayıt;
        private System.Windows.Forms.ToolStripButton tlsbKaydet;
        private System.Windows.Forms.ToolStripButton tlsbgüncelle;
        private System.Windows.Forms.ToolStripButton tlsbsil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtvki;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.TextBox txtboy;
        private System.Windows.Forms.TextBox txtcinsiyet;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdeger;
        private System.Windows.Forms.TextBox txtve;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.ComboBox cmbxkriter;
        private System.Windows.Forms.ComboBox cmbxalan;
    }
}

