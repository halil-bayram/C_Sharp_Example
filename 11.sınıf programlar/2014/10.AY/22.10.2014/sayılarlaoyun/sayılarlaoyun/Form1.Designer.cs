namespace sayılarlaoyun
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
            this.txtbsayı1 = new System.Windows.Forms.TextBox();
            this.txtbsayı2 = new System.Windows.Forms.TextBox();
            this.lblsayı1 = new System.Windows.Forms.Label();
            this.lblsayı2 = new System.Windows.Forms.Label();
            this.cmbtercih = new System.Windows.Forms.ComboBox();
            this.lstsayılar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtbsayı1
            // 
            this.txtbsayı1.Location = new System.Drawing.Point(53, 36);
            this.txtbsayı1.Name = "txtbsayı1";
            this.txtbsayı1.Size = new System.Drawing.Size(110, 20);
            this.txtbsayı1.TabIndex = 0;
            // 
            // txtbsayı2
            // 
            this.txtbsayı2.Location = new System.Drawing.Point(53, 62);
            this.txtbsayı2.Name = "txtbsayı2";
            this.txtbsayı2.Size = new System.Drawing.Size(110, 20);
            this.txtbsayı2.TabIndex = 1;
            //this.txtbsayı2.TextChanged += new System.EventHandler(this.txtbsayı2_TextChanged);
            // 
            // lblsayı1
            // 
            this.lblsayı1.AutoSize = true;
            this.lblsayı1.Location = new System.Drawing.Point(12, 36);
            this.lblsayı1.Name = "lblsayı1";
            this.lblsayı1.Size = new System.Drawing.Size(34, 13);
            this.lblsayı1.TabIndex = 2;
            this.lblsayı1.Text = "1.sayı";
            // 
            // lblsayı2
            // 
            this.lblsayı2.AutoSize = true;
            this.lblsayı2.Location = new System.Drawing.Point(12, 65);
            this.lblsayı2.Name = "lblsayı2";
            this.lblsayı2.Size = new System.Drawing.Size(34, 13);
            this.lblsayı2.TabIndex = 3;
            this.lblsayı2.Text = "2.sayı";
            // 
            // cmbtercih
            // 
            this.cmbtercih.FormattingEnabled = true;
            this.cmbtercih.Items.AddRange(new object[] {
            "OBEB",
            "OKEK",
            "ASAL SAYILAR",
            "PALİDROMİK SAYILAR",
            "MÜKEMMEL SAYILAR"});
            this.cmbtercih.Location = new System.Drawing.Point(107, 110);
            this.cmbtercih.Name = "cmbtercih";
            this.cmbtercih.Size = new System.Drawing.Size(160, 21);
            this.cmbtercih.TabIndex = 4;
            this.cmbtercih.SelectedIndexChanged += new System.EventHandler(this.cmbtercih_SelectedIndexChanged);
            // 
            // lstsayılar
            // 
            this.lstsayılar.FormattingEnabled = true;
            this.lstsayılar.Location = new System.Drawing.Point(121, 150);
            this.lstsayılar.Name = "lstsayılar";
            this.lstsayılar.Size = new System.Drawing.Size(146, 134);
            this.lstsayılar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 304);
            this.Controls.Add(this.lstsayılar);
            this.Controls.Add(this.cmbtercih);
            this.Controls.Add(this.lblsayı2);
            this.Controls.Add(this.lblsayı1);
            this.Controls.Add(this.txtbsayı2);
            this.Controls.Add(this.txtbsayı1);
            this.Name = "Form1";
            this.Text = "LLL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbsayı1;
        private System.Windows.Forms.TextBox txtbsayı2;
        private System.Windows.Forms.Label lblsayı1;
        private System.Windows.Forms.Label lblsayı2;
        private System.Windows.Forms.ComboBox cmbtercih;
        private System.Windows.Forms.ListBox lstsayılar;
    }
}

