namespace sınıflasifreoluşturma
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
            this.txtşifreuzunlugu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbharf = new System.Windows.Forms.RadioButton();
            this.rdbrakam = new System.Windows.Forms.RadioButton();
            this.rdbkarışık = new System.Windows.Forms.RadioButton();
            this.chkbxözelkarakter = new System.Windows.Forms.CheckBox();
            this.btnoluştur = new System.Windows.Forms.Button();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtşifreuzunlugu
            // 
            this.txtşifreuzunlugu.Location = new System.Drawing.Point(93, 12);
            this.txtşifreuzunlugu.Name = "txtşifreuzunlugu";
            this.txtşifreuzunlugu.Size = new System.Drawing.Size(117, 20);
            this.txtşifreuzunlugu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifre Uzunlugu";
            // 
            // rdbharf
            // 
            this.rdbharf.AutoSize = true;
            this.rdbharf.Location = new System.Drawing.Point(93, 51);
            this.rdbharf.Name = "rdbharf";
            this.rdbharf.Size = new System.Drawing.Size(85, 17);
            this.rdbharf.TabIndex = 2;
            this.rdbharf.TabStop = true;
            this.rdbharf.Text = "Sadece Harf";
            this.rdbharf.UseVisualStyleBackColor = true;
            // 
            // rdbrakam
            // 
            this.rdbrakam.AutoSize = true;
            this.rdbrakam.Location = new System.Drawing.Point(93, 74);
            this.rdbrakam.Name = "rdbrakam";
            this.rdbrakam.Size = new System.Drawing.Size(99, 17);
            this.rdbrakam.TabIndex = 3;
            this.rdbrakam.TabStop = true;
            this.rdbrakam.Text = "Sadece Rakam";
            this.rdbrakam.UseVisualStyleBackColor = true;
            // 
            // rdbkarışık
            // 
            this.rdbkarışık.AutoSize = true;
            this.rdbkarışık.Location = new System.Drawing.Point(93, 97);
            this.rdbkarışık.Name = "rdbkarışık";
            this.rdbkarışık.Size = new System.Drawing.Size(56, 17);
            this.rdbkarışık.TabIndex = 4;
            this.rdbkarışık.TabStop = true;
            this.rdbkarışık.Text = "Karışık";
            this.rdbkarışık.UseVisualStyleBackColor = true;
            // 
            // chkbxözelkarakter
            // 
            this.chkbxözelkarakter.AutoSize = true;
            this.chkbxözelkarakter.Location = new System.Drawing.Point(108, 120);
            this.chkbxözelkarakter.Name = "chkbxözelkarakter";
            this.chkbxözelkarakter.Size = new System.Drawing.Size(87, 17);
            this.chkbxözelkarakter.TabIndex = 5;
            this.chkbxözelkarakter.Text = "Özel Karakte";
            this.chkbxözelkarakter.UseVisualStyleBackColor = true;
            // 
            // btnoluştur
            // 
            this.btnoluştur.Location = new System.Drawing.Point(93, 143);
            this.btnoluştur.Name = "btnoluştur";
            this.btnoluştur.Size = new System.Drawing.Size(117, 23);
            this.btnoluştur.TabIndex = 6;
            this.btnoluştur.Text = "Oluştur";
            this.btnoluştur.UseVisualStyleBackColor = true;
            this.btnoluştur.Click += new System.EventHandler(this.btnoluştur_Click);
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(57, 172);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(186, 20);
            this.txtsonuc.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 217);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.btnoluştur);
            this.Controls.Add(this.chkbxözelkarakter);
            this.Controls.Add(this.rdbkarışık);
            this.Controls.Add(this.rdbrakam);
            this.Controls.Add(this.rdbharf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtşifreuzunlugu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtşifreuzunlugu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbharf;
        private System.Windows.Forms.RadioButton rdbrakam;
        private System.Windows.Forms.RadioButton rdbkarışık;
        private System.Windows.Forms.CheckBox chkbxözelkarakter;
        private System.Windows.Forms.Button btnoluştur;
        private System.Windows.Forms.TextBox txtsonuc;
    }
}

