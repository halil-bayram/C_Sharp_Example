namespace hobisecme
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
            this.hobiler = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdberkek = new System.Windows.Forms.RadioButton();
            this.rdbkız = new System.Windows.Forms.RadioButton();
            this.btnhepsec = new System.Windows.Forms.Button();
            this.btnhepkaldır = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnhobiekle = new System.Windows.Forms.Button();
            this.txbhobi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hobiler
            // 
            this.hobiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hobiler.FormattingEnabled = true;
            this.hobiler.Location = new System.Drawing.Point(12, 69);
            this.hobiler.Name = "hobiler";
            this.hobiler.Size = new System.Drawing.Size(144, 214);
            this.hobiler.TabIndex = 0;
            this.hobiler.SelectedIndexChanged += new System.EventHandler(this.hobiler_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(371, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rdberkek
            // 
            this.rdberkek.AutoSize = true;
            this.rdberkek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rdberkek.Location = new System.Drawing.Point(12, 12);
            this.rdberkek.Name = "rdberkek";
            this.rdberkek.Size = new System.Drawing.Size(52, 17);
            this.rdberkek.TabIndex = 2;
            this.rdberkek.TabStop = true;
            this.rdberkek.Text = "erkek";
            this.rdberkek.UseVisualStyleBackColor = false;
            this.rdberkek.CheckedChanged += new System.EventHandler(this.rdberkek_CheckedChanged);
            // 
            // rdbkız
            // 
            this.rdbkız.AutoSize = true;
            this.rdbkız.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rdbkız.Location = new System.Drawing.Point(103, 12);
            this.rdbkız.Name = "rdbkız";
            this.rdbkız.Size = new System.Drawing.Size(38, 17);
            this.rdbkız.TabIndex = 3;
            this.rdbkız.TabStop = true;
            this.rdbkız.Text = "kız";
            this.rdbkız.UseVisualStyleBackColor = false;
            this.rdbkız.CheckedChanged += new System.EventHandler(this.rdbkız_CheckedChanged);
            // 
            // btnhepsec
            // 
            this.btnhepsec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhepsec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhepsec.Location = new System.Drawing.Point(12, 303);
            this.btnhepsec.Name = "btnhepsec";
            this.btnhepsec.Size = new System.Drawing.Size(100, 37);
            this.btnhepsec.TabIndex = 4;
            this.btnhepsec.Text = "Hepsini sec";
            this.btnhepsec.UseVisualStyleBackColor = false;
            this.btnhepsec.Click += new System.EventHandler(this.btnhepsec_Click);
            // 
            // btnhepkaldır
            // 
            this.btnhepkaldır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhepkaldır.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhepkaldır.Location = new System.Drawing.Point(12, 346);
            this.btnhepkaldır.Name = "btnhepkaldır";
            this.btnhepkaldır.Size = new System.Drawing.Size(100, 37);
            this.btnhepkaldır.TabIndex = 5;
            this.btnhepkaldır.Text = "hepsini kaldır";
            this.btnhepkaldır.UseVisualStyleBackColor = false;
            this.btnhepkaldır.Click += new System.EventHandler(this.btnhepkaldır_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnekle.Location = new System.Drawing.Point(214, 111);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 37);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnhobiekle
            // 
            this.btnhobiekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhobiekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhobiekle.Location = new System.Drawing.Point(414, 437);
            this.btnhobiekle.Name = "btnhobiekle";
            this.btnhobiekle.Size = new System.Drawing.Size(100, 37);
            this.btnhobiekle.TabIndex = 7;
            this.btnhobiekle.Text = "hobi ekle";
            this.btnhobiekle.UseVisualStyleBackColor = false;
            this.btnhobiekle.Click += new System.EventHandler(this.btnhobiekle_Click);
            // 
            // txbhobi
            // 
            this.txbhobi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txbhobi.Location = new System.Drawing.Point(411, 400);
            this.txbhobi.Name = "txbhobi";
            this.txbhobi.Size = new System.Drawing.Size(102, 20);
            this.txbhobi.TabIndex = 8;
            this.txbhobi.TextChanged += new System.EventHandler(this.txbhobi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 500);
            this.Controls.Add(this.txbhobi);
            this.Controls.Add(this.btnhobiekle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnhepkaldır);
            this.Controls.Add(this.btnhepsec);
            this.Controls.Add(this.rdbkız);
            this.Controls.Add(this.rdberkek);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hobiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox hobiler;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdberkek;
        private System.Windows.Forms.RadioButton rdbkız;
        private System.Windows.Forms.Button btnhepsec;
        private System.Windows.Forms.Button btnhepkaldır;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnhobiekle;
        private System.Windows.Forms.TextBox txbhobi;
    }
}

