namespace tekçiftsayıüret
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
            this.chkteksayı = new System.Windows.Forms.CheckBox();
            this.chkçiftsayı = new System.Windows.Forms.CheckBox();
            this.lblsonuç = new System.Windows.Forms.Label();
            this.btnhesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkteksayı
            // 
            this.chkteksayı.AutoSize = true;
            this.chkteksayı.Location = new System.Drawing.Point(87, 28);
            this.chkteksayı.Name = "chkteksayı";
            this.chkteksayı.Size = new System.Drawing.Size(79, 17);
            this.chkteksayı.TabIndex = 0;
            this.chkteksayı.Text = "Tek Sayılar";
            this.chkteksayı.UseVisualStyleBackColor = true;
            // 
            // chkçiftsayı
            // 
            this.chkçiftsayı.AutoSize = true;
            this.chkçiftsayı.Location = new System.Drawing.Point(87, 51);
            this.chkçiftsayı.Name = "chkçiftsayı";
            this.chkçiftsayı.Size = new System.Drawing.Size(75, 17);
            this.chkçiftsayı.TabIndex = 1;
            this.chkçiftsayı.Text = "Çift Sayılar";
            this.chkçiftsayı.UseVisualStyleBackColor = true;
            // 
            // lblsonuç
            // 
            this.lblsonuç.AutoSize = true;
            this.lblsonuç.Location = new System.Drawing.Point(84, 160);
            this.lblsonuç.Name = "lblsonuç";
            this.lblsonuç.Size = new System.Drawing.Size(0, 13);
            this.lblsonuç.TabIndex = 2;
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(87, 83);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(69, 27);
            this.btnhesap.TabIndex = 3;
            this.btnhesap.Text = "hesapla";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.lblsonuç);
            this.Controls.Add(this.chkçiftsayı);
            this.Controls.Add(this.chkteksayı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkteksayı;
        private System.Windows.Forms.CheckBox chkçiftsayı;
        private System.Windows.Forms.Label lblsonuç;
        private System.Windows.Forms.Button btnhesap;
    }
}

