namespace adamasmaca
{
    partial class t
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
            this.lblkelime = new System.Windows.Forms.Label();
            this.lblipucu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbaşlat = new System.Windows.Forms.Button();
            this.btnharf = new System.Windows.Forms.Button();
            this.btntahmin = new System.Windows.Forms.Button();
            this.txtgirilenkelime = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.prgrsbrzaman = new System.Windows.Forms.ProgressBar();
            this.lblsorupuan = new System.Windows.Forms.Label();
            this.lbltoplampuan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkelime
            // 
            this.lblkelime.AutoSize = true;
            this.lblkelime.Location = new System.Drawing.Point(15, 20);
            this.lblkelime.Name = "lblkelime";
            this.lblkelime.Size = new System.Drawing.Size(40, 13);
            this.lblkelime.TabIndex = 0;
            this.lblkelime.Text = "kelime:";
            // 
            // lblipucu
            // 
            this.lblipucu.AutoSize = true;
            this.lblipucu.Location = new System.Drawing.Point(15, 49);
            this.lblipucu.Name = "lblipucu";
            this.lblipucu.Size = new System.Drawing.Size(33, 13);
            this.lblipucu.TabIndex = 1;
            this.lblipucu.Text = "ipucu";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblipucu);
            this.panel1.Controls.Add(this.lblkelime);
            this.panel1.Location = new System.Drawing.Point(58, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 115);
            this.panel1.TabIndex = 2;
            // 
            // btnbaşlat
            // 
            this.btnbaşlat.Location = new System.Drawing.Point(58, 194);
            this.btnbaşlat.Name = "btnbaşlat";
            this.btnbaşlat.Size = new System.Drawing.Size(78, 31);
            this.btnbaşlat.TabIndex = 3;
            this.btnbaşlat.Text = "Başlat";
            this.btnbaşlat.UseVisualStyleBackColor = true;
            this.btnbaşlat.Click += new System.EventHandler(this.btnbaşlat_Click);
            // 
            // btnharf
            // 
            this.btnharf.Location = new System.Drawing.Point(58, 286);
            this.btnharf.Name = "btnharf";
            this.btnharf.Size = new System.Drawing.Size(78, 31);
            this.btnharf.TabIndex = 4;
            this.btnharf.Text = "Harf";
            this.btnharf.UseVisualStyleBackColor = true;
            this.btnharf.Click += new System.EventHandler(this.btnharf_Click);
            // 
            // btntahmin
            // 
            this.btntahmin.Location = new System.Drawing.Point(58, 323);
            this.btntahmin.Name = "btntahmin";
            this.btntahmin.Size = new System.Drawing.Size(78, 31);
            this.btntahmin.TabIndex = 5;
            this.btntahmin.Text = "Tahmin";
            this.btntahmin.UseVisualStyleBackColor = true;
            this.btntahmin.Click += new System.EventHandler(this.btntahmin_Click);
            // 
            // txtgirilenkelime
            // 
            this.txtgirilenkelime.Location = new System.Drawing.Point(58, 247);
            this.txtgirilenkelime.MaxLength = 1;
            this.txtgirilenkelime.Name = "txtgirilenkelime";
            this.txtgirilenkelime.Size = new System.Drawing.Size(90, 20);
            this.txtgirilenkelime.TabIndex = 6;
            this.txtgirilenkelime.TextChanged += new System.EventHandler(this.txtgirilenkelime_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(370, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tmr1
            // 
            this.tmr1.Interval = 800;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // prgrsbrzaman
            // 
            this.prgrsbrzaman.Location = new System.Drawing.Point(271, 388);
            this.prgrsbrzaman.Name = "prgrsbrzaman";
            this.prgrsbrzaman.Size = new System.Drawing.Size(280, 30);
            this.prgrsbrzaman.TabIndex = 8;
            // 
            // lblsorupuan
            // 
            this.lblsorupuan.AutoSize = true;
            this.lblsorupuan.Location = new System.Drawing.Point(257, 195);
            this.lblsorupuan.Name = "lblsorupuan";
            this.lblsorupuan.Size = new System.Drawing.Size(54, 13);
            this.lblsorupuan.TabIndex = 9;
            this.lblsorupuan.Text = "sorupuan;";
            // 
            // lbltoplampuan
            // 
            this.lbltoplampuan.AutoSize = true;
            this.lbltoplampuan.Location = new System.Drawing.Point(261, 223);
            this.lbltoplampuan.Name = "lbltoplampuan";
            this.lbltoplampuan.Size = new System.Drawing.Size(68, 13);
            this.lbltoplampuan.TabIndex = 10;
            this.lbltoplampuan.Text = "toplam puan:";
            // 
            // t
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 480);
            this.Controls.Add(this.lbltoplampuan);
            this.Controls.Add(this.lblsorupuan);
            this.Controls.Add(this.prgrsbrzaman);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtgirilenkelime);
            this.Controls.Add(this.btntahmin);
            this.Controls.Add(this.btnharf);
            this.Controls.Add(this.btnbaşlat);
            this.Controls.Add(this.panel1);
            this.Name = "t";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.t_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkelime;
        private System.Windows.Forms.Label lblipucu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnbaşlat;
        private System.Windows.Forms.Button btnharf;
        private System.Windows.Forms.Button btntahmin;
        private System.Windows.Forms.TextBox txtgirilenkelime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.ProgressBar prgrsbrzaman;
        private System.Windows.Forms.Label lblsorupuan;
        private System.Windows.Forms.Label lbltoplampuan;
    }
}

