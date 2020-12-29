namespace faturaödemetarihi
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
            this.dtptarih = new System.Windows.Forms.DateTimePicker();
            this.lblbaşlangıc = new System.Windows.Forms.Label();
            this.lblbitiştarihi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtptarih
            // 
            this.dtptarih.Location = new System.Drawing.Point(183, 40);
            this.dtptarih.Name = "dtptarih";
            this.dtptarih.Size = new System.Drawing.Size(200, 20);
            this.dtptarih.TabIndex = 0;
            // 
            // lblbaşlangıc
            // 
            this.lblbaşlangıc.AutoSize = true;
            this.lblbaşlangıc.Location = new System.Drawing.Point(58, 122);
            this.lblbaşlangıc.Name = "lblbaşlangıc";
            this.lblbaşlangıc.Size = new System.Drawing.Size(90, 13);
            this.lblbaşlangıc.TabIndex = 1;
            this.lblbaşlangıc.Text = "İlk Ödeme Tarihi: ";
            // 
            // lblbitiştarihi
            // 
            this.lblbitiştarihi.AutoSize = true;
            this.lblbitiştarihi.Location = new System.Drawing.Point(58, 164);
            this.lblbitiştarihi.Name = "lblbitiştarihi";
            this.lblbitiştarihi.Size = new System.Drawing.Size(98, 13);
            this.lblbitiştarihi.TabIndex = 1;
            this.lblbitiştarihi.Text = "Son Ödeme Tarihi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sayac Okuma Tarihi";
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(145, 83);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(109, 23);
            this.btnhesapla.TabIndex = 2;
            this.btnhesapla.Text = "Tarihi Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 391);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.lblbitiştarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblbaşlangıc);
            this.Controls.Add(this.dtptarih);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtptarih;
        private System.Windows.Forms.Label lblbaşlangıc;
        private System.Windows.Forms.Label lblbitiştarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhesapla;
    }
}

