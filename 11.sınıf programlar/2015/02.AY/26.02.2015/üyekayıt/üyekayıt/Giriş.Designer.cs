namespace üyekayıt
{
    partial class Giriş
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
            this.btngiriş = new System.Windows.Forms.Button();
            this.txtkullanıcıgiriş = new System.Windows.Forms.TextBox();
            this.txtşifregiriş = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.lklblşifreunuttum = new System.Windows.Forms.LinkLabel();
            this.lnklblüyeol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btngiriş
            // 
            this.btngiriş.Location = new System.Drawing.Point(79, 133);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(75, 23);
            this.btngiriş.TabIndex = 0;
            this.btngiriş.Text = "Giriş";
            this.btngiriş.UseVisualStyleBackColor = true;
            this.btngiriş.Click += new System.EventHandler(this.btngiriş_Click);
            // 
            // txtkullanıcıgiriş
            // 
            this.txtkullanıcıgiriş.Location = new System.Drawing.Point(94, 22);
            this.txtkullanıcıgiriş.Name = "txtkullanıcıgiriş";
            this.txtkullanıcıgiriş.Size = new System.Drawing.Size(100, 20);
            this.txtkullanıcıgiriş.TabIndex = 1;
            // 
            // txtşifregiriş
            // 
            this.txtşifregiriş.Location = new System.Drawing.Point(94, 48);
            this.txtşifregiriş.Name = "txtşifregiriş";
            this.txtşifregiriş.Size = new System.Drawing.Size(100, 20);
            this.txtşifregiriş.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Location = new System.Drawing.Point(15, 51);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(28, 13);
            this.lblŞifre.TabIndex = 4;
            this.lblŞifre.Text = "Şifre";
            // 
            // lklblşifreunuttum
            // 
            this.lklblşifreunuttum.AutoSize = true;
            this.lklblşifreunuttum.Location = new System.Drawing.Point(27, 96);
            this.lklblşifreunuttum.Name = "lklblşifreunuttum";
            this.lklblşifreunuttum.Size = new System.Drawing.Size(81, 13);
            this.lklblşifreunuttum.TabIndex = 5;
            this.lklblşifreunuttum.TabStop = true;
            this.lklblşifreunuttum.Text = "Şifremi Unuttum";
            this.lklblşifreunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblşifreunuttum_LinkClicked);
            // 
            // lnklblüyeol
            // 
            this.lnklblüyeol.AutoSize = true;
            this.lnklblüyeol.Location = new System.Drawing.Point(158, 96);
            this.lnklblüyeol.Name = "lnklblüyeol";
            this.lnklblüyeol.Size = new System.Drawing.Size(43, 13);
            this.lnklblüyeol.TabIndex = 6;
            this.lnklblüyeol.TabStop = true;
            this.lnklblüyeol.Text = "Kayıt Ol";
            this.lnklblüyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblüyeol_LinkClicked);
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 189);
            this.Controls.Add(this.lnklblüyeol);
            this.Controls.Add(this.lklblşifreunuttum);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtşifregiriş);
            this.Controls.Add(this.txtkullanıcıgiriş);
            this.Controls.Add(this.btngiriş);
            this.Name = "Giriş";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.TextBox txtkullanıcıgiriş;
        private System.Windows.Forms.TextBox txtşifregiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.LinkLabel lklblşifreunuttum;
        private System.Windows.Forms.LinkLabel lnklblüyeol;
    }
}