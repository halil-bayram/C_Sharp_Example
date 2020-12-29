namespace sınıfkulup
{
    partial class Kulüp_Düzenle
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
            this.lstbxkulüp = new System.Windows.Forms.ListBox();
            this.rdbyenikulüpdüzenle = new System.Windows.Forms.RadioButton();
            this.rdbdüzenle = new System.Windows.Forms.RadioButton();
            this.rdbsil = new System.Windows.Forms.RadioButton();
            this.txtkulüp = new System.Windows.Forms.TextBox();
            this.btnnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxkulüp
            // 
            this.lstbxkulüp.FormattingEnabled = true;
            this.lstbxkulüp.Location = new System.Drawing.Point(12, 12);
            this.lstbxkulüp.Name = "lstbxkulüp";
            this.lstbxkulüp.Size = new System.Drawing.Size(120, 212);
            this.lstbxkulüp.TabIndex = 0;
            this.lstbxkulüp.SelectedIndexChanged += new System.EventHandler(this.lstbxkulüp_SelectedIndexChanged);
            // 
            // rdbyenikulüpdüzenle
            // 
            this.rdbyenikulüpdüzenle.AutoSize = true;
            this.rdbyenikulüpdüzenle.Location = new System.Drawing.Point(152, 15);
            this.rdbyenikulüpdüzenle.Name = "rdbyenikulüpdüzenle";
            this.rdbyenikulüpdüzenle.Size = new System.Drawing.Size(100, 17);
            this.rdbyenikulüpdüzenle.TabIndex = 1;
            this.rdbyenikulüpdüzenle.TabStop = true;
            this.rdbyenikulüpdüzenle.Text = "Yeni Kulüp Ekle";
            this.rdbyenikulüpdüzenle.UseVisualStyleBackColor = true;
            this.rdbyenikulüpdüzenle.CheckedChanged += new System.EventHandler(this.rdbkulüpdüzenle_CheckedChanged);
            // 
            // rdbdüzenle
            // 
            this.rdbdüzenle.AutoSize = true;
            this.rdbdüzenle.Location = new System.Drawing.Point(152, 38);
            this.rdbdüzenle.Name = "rdbdüzenle";
            this.rdbdüzenle.Size = new System.Drawing.Size(94, 17);
            this.rdbdüzenle.TabIndex = 1;
            this.rdbdüzenle.TabStop = true;
            this.rdbdüzenle.Text = "Kulüp Düzenle";
            this.rdbdüzenle.UseVisualStyleBackColor = true;
            this.rdbdüzenle.CheckedChanged += new System.EventHandler(this.rdbdüzenle_CheckedChanged);
            // 
            // rdbsil
            // 
            this.rdbsil.AutoSize = true;
            this.rdbsil.Location = new System.Drawing.Point(152, 61);
            this.rdbsil.Name = "rdbsil";
            this.rdbsil.Size = new System.Drawing.Size(66, 17);
            this.rdbsil.TabIndex = 1;
            this.rdbsil.TabStop = true;
            this.rdbsil.Text = "Kulüp Sil";
            this.rdbsil.UseVisualStyleBackColor = true;
            this.rdbsil.CheckedChanged += new System.EventHandler(this.rdbsil_CheckedChanged);
            // 
            // txtkulüp
            // 
            this.txtkulüp.Location = new System.Drawing.Point(152, 84);
            this.txtkulüp.Name = "txtkulüp";
            this.txtkulüp.Size = new System.Drawing.Size(100, 20);
            this.txtkulüp.TabIndex = 2;
            this.txtkulüp.Visible = false;
            // 
            // btnnayla
            // 
            this.btnnayla.Location = new System.Drawing.Point(152, 110);
            this.btnnayla.Name = "btnnayla";
            this.btnnayla.Size = new System.Drawing.Size(75, 23);
            this.btnnayla.TabIndex = 3;
            this.btnnayla.Text = "Onayla";
            this.btnnayla.UseVisualStyleBackColor = true;
            this.btnnayla.Click += new System.EventHandler(this.btnnayla_Click);
            // 
            // Kulüp_Düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 254);
            this.Controls.Add(this.btnnayla);
            this.Controls.Add(this.txtkulüp);
            this.Controls.Add(this.rdbsil);
            this.Controls.Add(this.rdbdüzenle);
            this.Controls.Add(this.rdbyenikulüpdüzenle);
            this.Controls.Add(this.lstbxkulüp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kulüp_Düzenle";
            this.Text = "Kulüp_Düzenle";
            this.Load += new System.EventHandler(this.Kulüp_Düzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxkulüp;
        private System.Windows.Forms.RadioButton rdbyenikulüpdüzenle;
        private System.Windows.Forms.RadioButton rdbdüzenle;
        private System.Windows.Forms.RadioButton rdbsil;
        private System.Windows.Forms.TextBox txtkulüp;
        private System.Windows.Forms.Button btnnayla;
    }
}