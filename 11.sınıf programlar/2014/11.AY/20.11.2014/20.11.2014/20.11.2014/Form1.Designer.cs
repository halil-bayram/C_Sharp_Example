namespace _20._11._2014
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
            this.dtpbaşlangıc = new System.Windows.Forms.DateTimePicker();
            this.dtpbitiş = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpbaşlangıc
            // 
            this.dtpbaşlangıc.Location = new System.Drawing.Point(114, 12);
            this.dtpbaşlangıc.Name = "dtpbaşlangıc";
            this.dtpbaşlangıc.Size = new System.Drawing.Size(200, 20);
            this.dtpbaşlangıc.TabIndex = 0;
            // 
            // dtpbitiş
            // 
            this.dtpbitiş.Location = new System.Drawing.Point(114, 60);
            this.dtpbitiş.Name = "dtpbitiş";
            this.dtpbitiş.Size = new System.Drawing.Size(200, 20);
            this.dtpbitiş.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(163, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 134);
            this.listBox1.TabIndex = 2;
            //this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(28, 123);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(81, 31);
            this.btnhesapla.TabIndex = 3;
            this.btnhesapla.Text = "hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "başlangı degeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "bitiş degeri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dtpbitiş);
            this.Controls.Add(this.dtpbaşlangıc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpbaşlangıc;
        private System.Windows.Forms.DateTimePicker dtpbitiş;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

