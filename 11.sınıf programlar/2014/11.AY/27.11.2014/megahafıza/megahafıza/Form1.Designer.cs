namespace megahafıza
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
            this.components = new System.ComponentModel.Container();
            this.grbsüre = new System.Windows.Forms.GroupBox();
            this.grbsıradkisayı = new System.Windows.Forms.GroupBox();
            this.grbeklenecekpuan = new System.Windows.Forms.GroupBox();
            this.grbpuan = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsüre = new System.Windows.Forms.Label();
            this.lblsıradaklisayı = new System.Windows.Forms.Label();
            this.lbleklenecekpuan = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.grbsüre.SuspendLayout();
            this.grbsıradkisayı.SuspendLayout();
            this.grbeklenecekpuan.SuspendLayout();
            this.grbpuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbsüre
            // 
            this.grbsüre.Controls.Add(this.lblsüre);
            this.grbsüre.Location = new System.Drawing.Point(383, 12);
            this.grbsüre.Name = "grbsüre";
            this.grbsüre.Size = new System.Drawing.Size(200, 100);
            this.grbsüre.TabIndex = 0;
            this.grbsüre.TabStop = false;
            this.grbsüre.Text = "Süre";
            // 
            // grbsıradkisayı
            // 
            this.grbsıradkisayı.Controls.Add(this.lblsıradaklisayı);
            this.grbsıradkisayı.Location = new System.Drawing.Point(383, 118);
            this.grbsıradkisayı.Name = "grbsıradkisayı";
            this.grbsıradkisayı.Size = new System.Drawing.Size(200, 100);
            this.grbsıradkisayı.TabIndex = 1;
            this.grbsıradkisayı.TabStop = false;
            this.grbsıradkisayı.Text = "Sıradaki Sayı";
            // 
            // grbeklenecekpuan
            // 
            this.grbeklenecekpuan.Controls.Add(this.lbleklenecekpuan);
            this.grbeklenecekpuan.Location = new System.Drawing.Point(383, 224);
            this.grbeklenecekpuan.Name = "grbeklenecekpuan";
            this.grbeklenecekpuan.Size = new System.Drawing.Size(200, 100);
            this.grbeklenecekpuan.TabIndex = 2;
            this.grbeklenecekpuan.TabStop = false;
            this.grbeklenecekpuan.Text = "Eklenecek Puan";
            // 
            // grbpuan
            // 
            this.grbpuan.Controls.Add(this.lblpuan);
            this.grbpuan.Location = new System.Drawing.Point(383, 330);
            this.grbpuan.Name = "grbpuan";
            this.grbpuan.Size = new System.Drawing.Size(200, 100);
            this.grbpuan.TabIndex = 3;
            this.grbpuan.TabStop = false;
            this.grbpuan.Text = "Puan";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 417);
            this.panel1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Location = new System.Drawing.Point(81, 47);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(0, 13);
            this.lblsüre.TabIndex = 0;
            // 
            // lblsıradaklisayı
            // 
            this.lblsıradaklisayı.AutoSize = true;
            this.lblsıradaklisayı.Location = new System.Drawing.Point(81, 48);
            this.lblsıradaklisayı.Name = "lblsıradaklisayı";
            this.lblsıradaklisayı.Size = new System.Drawing.Size(0, 13);
            this.lblsıradaklisayı.TabIndex = 0;
            // 
            // lbleklenecekpuan
            // 
            this.lbleklenecekpuan.AutoSize = true;
            this.lbleklenecekpuan.Location = new System.Drawing.Point(81, 53);
            this.lbleklenecekpuan.Name = "lbleklenecekpuan";
            this.lbleklenecekpuan.Size = new System.Drawing.Size(0, 13);
            this.lbleklenecekpuan.TabIndex = 0;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Location = new System.Drawing.Point(81, 50);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(0, 13);
            this.lblpuan.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbpuan);
            this.Controls.Add(this.grbeklenecekpuan);
            this.Controls.Add(this.grbsıradkisayı);
            this.Controls.Add(this.grbsüre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbsüre.ResumeLayout(false);
            this.grbsüre.PerformLayout();
            this.grbsıradkisayı.ResumeLayout(false);
            this.grbsıradkisayı.PerformLayout();
            this.grbeklenecekpuan.ResumeLayout(false);
            this.grbeklenecekpuan.PerformLayout();
            this.grbpuan.ResumeLayout(false);
            this.grbpuan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbsüre;
        private System.Windows.Forms.GroupBox grbsıradkisayı;
        private System.Windows.Forms.GroupBox grbeklenecekpuan;
        private System.Windows.Forms.GroupBox grbpuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.Label lblsıradaklisayı;
        private System.Windows.Forms.Label lbleklenecekpuan;
        private System.Windows.Forms.Label lblpuan;
    }
}

