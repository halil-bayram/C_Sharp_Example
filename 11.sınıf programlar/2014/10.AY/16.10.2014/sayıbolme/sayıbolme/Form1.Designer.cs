namespace sayıbolme
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
            this.lstsayılar = new System.Windows.Forms.ListBox();
            this.lstbolünenler = new System.Windows.Forms.ListBox();
            this.chk3ebölünen = new System.Windows.Forms.CheckBox();
            this.chk4ebölünen = new System.Windows.Forms.CheckBox();
            this.chk5ebölünen = new System.Windows.Forms.CheckBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstsayılar
            // 
            this.lstsayılar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstsayılar.ForeColor = System.Drawing.Color.Lime;
            this.lstsayılar.FormattingEnabled = true;
            this.lstsayılar.Location = new System.Drawing.Point(23, 43);
            this.lstsayılar.Name = "lstsayılar";
            this.lstsayılar.Size = new System.Drawing.Size(129, 251);
            this.lstsayılar.TabIndex = 0;
            // 
            // lstbolünenler
            // 
            this.lstbolünenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstbolünenler.ForeColor = System.Drawing.Color.Lime;
            this.lstbolünenler.FormattingEnabled = true;
            this.lstbolünenler.Location = new System.Drawing.Point(321, 43);
            this.lstbolünenler.Name = "lstbolünenler";
            this.lstbolünenler.Size = new System.Drawing.Size(129, 251);
            this.lstbolünenler.TabIndex = 1;
            // 
            // chk3ebölünen
            // 
            this.chk3ebölünen.AutoSize = true;
            this.chk3ebölünen.Location = new System.Drawing.Point(191, 88);
            this.chk3ebölünen.Name = "chk3ebölünen";
            this.chk3ebölünen.Size = new System.Drawing.Size(93, 17);
            this.chk3ebölünen.TabIndex = 2;
            this.chk3ebölünen.Text = "3`e bölünenler";
            this.chk3ebölünen.UseVisualStyleBackColor = true;
            // 
            // chk4ebölünen
            // 
            this.chk4ebölünen.AutoSize = true;
            this.chk4ebölünen.Location = new System.Drawing.Point(191, 111);
            this.chk4ebölünen.Name = "chk4ebölünen";
            this.chk4ebölünen.Size = new System.Drawing.Size(93, 17);
            this.chk4ebölünen.TabIndex = 3;
            this.chk4ebölünen.Text = "4`e bölünenler";
            this.chk4ebölünen.UseVisualStyleBackColor = true;
            // 
            // chk5ebölünen
            // 
            this.chk5ebölünen.AutoSize = true;
            this.chk5ebölünen.Location = new System.Drawing.Point(191, 134);
            this.chk5ebölünen.Name = "chk5ebölünen";
            this.chk5ebölünen.Size = new System.Drawing.Size(93, 17);
            this.chk5ebölünen.TabIndex = 4;
            this.chk5ebölünen.Text = "5`e bölünenler";
            this.chk5ebölünen.UseVisualStyleBackColor = true;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(191, 232);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(93, 33);
            this.btnhesapla.TabIndex = 5;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 348);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.chk5ebölünen);
            this.Controls.Add(this.chk4ebölünen);
            this.Controls.Add(this.chk3ebölünen);
            this.Controls.Add(this.lstbolünenler);
            this.Controls.Add(this.lstsayılar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstsayılar;
        private System.Windows.Forms.ListBox lstbolünenler;
        private System.Windows.Forms.CheckBox chk3ebölünen;
        private System.Windows.Forms.CheckBox chk4ebölünen;
        private System.Windows.Forms.CheckBox chk5ebölünen;
        private System.Windows.Forms.Button btnhesapla;
    }
}

