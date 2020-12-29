namespace kangrubu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbadsoyad = new System.Windows.Forms.TextBox();
            this.cbxkangrubu = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.grpbxverigirişi = new System.Windows.Forms.GroupBox();
            this.lstbkisiler = new System.Windows.Forms.ListBox();
            this.lstkangrubu = new System.Windows.Forms.ListBox();
            this.lstdonöradı = new System.Windows.Forms.ListBox();
            this.lstdonörkangrubu = new System.Windows.Forms.ListBox();
            this.lblkişiler = new System.Windows.Forms.Label();
            this.lblkangurup = new System.Windows.Forms.Label();
            this.cbxdonörkangrubu = new System.Windows.Forms.ComboBox();
            this.lbldonörara = new System.Windows.Forms.Label();
            this.grpbxverigirişi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI SOYADI";
            // 
            // txtbadsoyad
            // 
            this.txtbadsoyad.Location = new System.Drawing.Point(21, 54);
            this.txtbadsoyad.Name = "txtbadsoyad";
            this.txtbadsoyad.Size = new System.Drawing.Size(172, 20);
            this.txtbadsoyad.TabIndex = 1;
            // 
            // cbxkangrubu
            // 
            this.cbxkangrubu.FormattingEnabled = true;
            this.cbxkangrubu.Items.AddRange(new object[] {
            "AB Rh+",
            "AB Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "O Rh+",
            "O Rh-"});
            this.cbxkangrubu.Location = new System.Drawing.Point(21, 80);
            this.cbxkangrubu.Name = "cbxkangrubu";
            this.cbxkangrubu.Size = new System.Drawing.Size(97, 21);
            this.cbxkangrubu.TabIndex = 2;
            this.cbxkangrubu.Text = "Kan Grubu";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(21, 107);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(73, 30);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // grpbxverigirişi
            // 
            this.grpbxverigirişi.Controls.Add(this.txtbadsoyad);
            this.grpbxverigirişi.Controls.Add(this.btnkaydet);
            this.grpbxverigirişi.Controls.Add(this.label1);
            this.grpbxverigirişi.Controls.Add(this.cbxkangrubu);
            this.grpbxverigirişi.Location = new System.Drawing.Point(12, 12);
            this.grpbxverigirişi.Name = "grpbxverigirişi";
            this.grpbxverigirişi.Size = new System.Drawing.Size(222, 165);
            this.grpbxverigirişi.TabIndex = 4;
            this.grpbxverigirişi.TabStop = false;
            this.grpbxverigirişi.Text = "Veri Girişi";
            // 
            // lstbkisiler
            // 
            this.lstbkisiler.FormattingEnabled = true;
            this.lstbkisiler.Location = new System.Drawing.Point(330, 38);
            this.lstbkisiler.Name = "lstbkisiler";
            this.lstbkisiler.Size = new System.Drawing.Size(107, 238);
            this.lstbkisiler.TabIndex = 5;
            // 
            // lstkangrubu
            // 
            this.lstkangrubu.FormattingEnabled = true;
            this.lstkangrubu.Location = new System.Drawing.Point(461, 38);
            this.lstkangrubu.Name = "lstkangrubu";
            this.lstkangrubu.Size = new System.Drawing.Size(107, 238);
            this.lstkangrubu.TabIndex = 6;
            // 
            // lstdonöradı
            // 
            this.lstdonöradı.FormattingEnabled = true;
            this.lstdonöradı.Location = new System.Drawing.Point(12, 274);
            this.lstdonöradı.Name = "lstdonöradı";
            this.lstdonöradı.Size = new System.Drawing.Size(107, 238);
            this.lstdonöradı.TabIndex = 7;
            // 
            // lstdonörkangrubu
            // 
            this.lstdonörkangrubu.FormattingEnabled = true;
            this.lstdonörkangrubu.Location = new System.Drawing.Point(127, 274);
            this.lstdonörkangrubu.Name = "lstdonörkangrubu";
            this.lstdonörkangrubu.Size = new System.Drawing.Size(107, 238);
            this.lstdonörkangrubu.TabIndex = 8;
            // 
            // lblkişiler
            // 
            this.lblkişiler.AutoSize = true;
            this.lblkişiler.Location = new System.Drawing.Point(327, 22);
            this.lblkişiler.Name = "lblkişiler";
            this.lblkişiler.Size = new System.Drawing.Size(34, 13);
            this.lblkişiler.TabIndex = 9;
            this.lblkişiler.Text = "Kişiler";
            // 
            // lblkangurup
            // 
            this.lblkangurup.AutoSize = true;
            this.lblkangurup.Location = new System.Drawing.Point(458, 22);
            this.lblkangurup.Name = "lblkangurup";
            this.lblkangurup.Size = new System.Drawing.Size(58, 13);
            this.lblkangurup.TabIndex = 10;
            this.lblkangurup.Text = "Kan Grubu";
            // 
            // cbxdonörkangrubu
            // 
            this.cbxdonörkangrubu.FormattingEnabled = true;
            this.cbxdonörkangrubu.Items.AddRange(new object[] {
            "AB Rh+",
            "AB Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "O Rh+",
            "O Rh-"});
            this.cbxdonörkangrubu.Location = new System.Drawing.Point(12, 247);
            this.cbxdonörkangrubu.Name = "cbxdonörkangrubu";
            this.cbxdonörkangrubu.Size = new System.Drawing.Size(97, 21);
            this.cbxdonörkangrubu.TabIndex = 11;
            this.cbxdonörkangrubu.Text = "Kan Grubu";
            this.cbxdonörkangrubu.SelectedIndexChanged += new System.EventHandler(this.cbxdonörkangrubu_SelectedIndexChanged);
            // 
            // lbldonörara
            // 
            this.lbldonörara.AutoSize = true;
            this.lbldonörara.Location = new System.Drawing.Point(12, 231);
            this.lbldonörara.Name = "lbldonörara";
            this.lbldonörara.Size = new System.Drawing.Size(55, 13);
            this.lbldonörara.TabIndex = 12;
            this.lbldonörara.Text = "Donör Ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 579);
            this.Controls.Add(this.lbldonörara);
            this.Controls.Add(this.cbxdonörkangrubu);
            this.Controls.Add(this.lblkangurup);
            this.Controls.Add(this.lblkişiler);
            this.Controls.Add(this.lstdonörkangrubu);
            this.Controls.Add(this.lstdonöradı);
            this.Controls.Add(this.lstkangrubu);
            this.Controls.Add(this.lstbkisiler);
            this.Controls.Add(this.grpbxverigirişi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxverigirişi.ResumeLayout(false);
            this.grpbxverigirişi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbadsoyad;
        private System.Windows.Forms.ComboBox cbxkangrubu;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.GroupBox grpbxverigirişi;
        private System.Windows.Forms.ListBox lstbkisiler;
        private System.Windows.Forms.ListBox lstkangrubu;
        private System.Windows.Forms.ListBox lstdonöradı;
        private System.Windows.Forms.ListBox lstdonörkangrubu;
        private System.Windows.Forms.Label lblkişiler;
        private System.Windows.Forms.Label lblkangurup;
        private System.Windows.Forms.ComboBox cbxdonörkangrubu;
        private System.Windows.Forms.Label lbldonörara;
    }
}

