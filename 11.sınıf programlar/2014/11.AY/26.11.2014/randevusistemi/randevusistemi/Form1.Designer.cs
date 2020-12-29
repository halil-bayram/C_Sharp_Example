namespace randevusistemi
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
            this.dtpgün = new System.Windows.Forms.DateTimePicker();
            this.lxtrandevusonuc = new System.Windows.Forms.ListBox();
            this.cmbbaşlangıc = new System.Windows.Forms.ComboBox();
            this.cmbaralık = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpgün
            // 
            this.dtpgün.Location = new System.Drawing.Point(154, 42);
            this.dtpgün.Name = "dtpgün";
            this.dtpgün.Size = new System.Drawing.Size(200, 20);
            this.dtpgün.TabIndex = 0;
            // 
            // lxtrandevusonuc
            // 
            this.lxtrandevusonuc.FormattingEnabled = true;
            this.lxtrandevusonuc.Location = new System.Drawing.Point(154, 216);
            this.lxtrandevusonuc.Name = "lxtrandevusonuc";
            this.lxtrandevusonuc.Size = new System.Drawing.Size(200, 134);
            this.lxtrandevusonuc.TabIndex = 1;
            // 
            // cmbbaşlangıc
            // 
            this.cmbbaşlangıc.FormattingEnabled = true;
            this.cmbbaşlangıc.Location = new System.Drawing.Point(175, 89);
            this.cmbbaşlangıc.Name = "cmbbaşlangıc";
            this.cmbbaşlangıc.Size = new System.Drawing.Size(121, 21);
            this.cmbbaşlangıc.TabIndex = 2;
            // 
            // cmbaralık
            // 
            this.cmbaralık.FormattingEnabled = true;
            this.cmbaralık.Location = new System.Drawing.Point(175, 140);
            this.cmbaralık.Name = "cmbaralık";
            this.cmbaralık.Size = new System.Drawing.Size(121, 21);
            this.cmbaralık.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Başlangıc Saatini Seciniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aralık Seciniz";
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(221, 177);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(75, 23);
            this.btnhesapla.TabIndex = 6;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 386);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbaralık);
            this.Controls.Add(this.cmbbaşlangıc);
            this.Controls.Add(this.lxtrandevusonuc);
            this.Controls.Add(this.dtpgün);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpgün;
        private System.Windows.Forms.ListBox lxtrandevusonuc;
        private System.Windows.Forms.ComboBox cmbbaşlangıc;
        private System.Windows.Forms.ComboBox cmbaralık;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhesapla;
    }
}

