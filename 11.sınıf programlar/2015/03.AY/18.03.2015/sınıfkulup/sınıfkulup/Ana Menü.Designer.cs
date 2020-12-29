namespace sınıfkulup
{
    partial class Ana_Menü
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kulüpİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kulüpDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kulübeÖgrenciAtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kulüpÖğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ögrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kulüpİşlemleriToolStripMenuItem,
            this.ögrenciİşlemleriToolStripMenuItem,
            this.ogrenciAraToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // kulüpİşlemleriToolStripMenuItem
            // 
            this.kulüpİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kulüpDüzenleToolStripMenuItem,
            this.kulübeÖgrenciAtaToolStripMenuItem,
            this.kulüpÖğrenciListesiToolStripMenuItem});
            this.kulüpİşlemleriToolStripMenuItem.Name = "kulüpİşlemleriToolStripMenuItem";
            this.kulüpİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.kulüpİşlemleriToolStripMenuItem.Text = "Kulüp İşlemleri";
            // 
            // kulüpDüzenleToolStripMenuItem
            // 
            this.kulüpDüzenleToolStripMenuItem.Name = "kulüpDüzenleToolStripMenuItem";
            this.kulüpDüzenleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kulüpDüzenleToolStripMenuItem.Text = "Kulüp Düzenle";
            this.kulüpDüzenleToolStripMenuItem.Click += new System.EventHandler(this.kulüpDüzenleToolStripMenuItem_Click);
            // 
            // kulübeÖgrenciAtaToolStripMenuItem
            // 
            this.kulübeÖgrenciAtaToolStripMenuItem.Name = "kulübeÖgrenciAtaToolStripMenuItem";
            this.kulübeÖgrenciAtaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kulübeÖgrenciAtaToolStripMenuItem.Text = "Kulübe Ögrenci Ata";
            this.kulübeÖgrenciAtaToolStripMenuItem.Click += new System.EventHandler(this.kulübeÖgrenciAtaToolStripMenuItem_Click);
            // 
            // kulüpÖğrenciListesiToolStripMenuItem
            // 
            this.kulüpÖğrenciListesiToolStripMenuItem.Name = "kulüpÖğrenciListesiToolStripMenuItem";
            this.kulüpÖğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kulüpÖğrenciListesiToolStripMenuItem.Text = "Kulüp Öğrenci Listesi";
            this.kulüpÖğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.kulüpÖğrenciListesiToolStripMenuItem_Click);
            // 
            // ögrenciİşlemleriToolStripMenuItem
            // 
            this.ögrenciİşlemleriToolStripMenuItem.Name = "ögrenciİşlemleriToolStripMenuItem";
            this.ögrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ögrenciİşlemleriToolStripMenuItem.Text = "Ögrenci İşlemleri";
            this.ögrenciİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ögrenciİşlemleriToolStripMenuItem_Click);
            // 
            // ogrenciAraToolStripMenuItem
            // 
            this.ogrenciAraToolStripMenuItem.Name = "ogrenciAraToolStripMenuItem";
            this.ogrenciAraToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ogrenciAraToolStripMenuItem.Text = "Ogrenci Ara";
            this.ogrenciAraToolStripMenuItem.Click += new System.EventHandler(this.ogrenciAraToolStripMenuItem_Click);
            // 
            // Ana_Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(541, 420);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Ana_Menü";
            this.Text = "Ana_Menü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kulüpİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ögrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kulüpDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kulübeÖgrenciAtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kulüpÖğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciAraToolStripMenuItem;
    }
}