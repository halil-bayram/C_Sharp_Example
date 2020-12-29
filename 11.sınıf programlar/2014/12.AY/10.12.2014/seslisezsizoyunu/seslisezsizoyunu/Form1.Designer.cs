namespace seslisezsizoyunu
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
            this.panelsecilenkelime = new System.Windows.Forms.Panel();
            this.panelsesliharf = new System.Windows.Forms.Panel();
            this.panelsessizharf = new System.Windows.Forms.Panel();
            this.btnsesli = new System.Windows.Forms.Button();
            this.btntahmin = new System.Windows.Forms.Button();
            this.btnkelimegöster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grbxtahmin = new System.Windows.Forms.GroupBox();
            this.txttahmin = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.grbxtahmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsecilenkelime
            // 
            this.panelsecilenkelime.Enabled = false;
            this.panelsecilenkelime.Location = new System.Drawing.Point(139, 100);
            this.panelsecilenkelime.Name = "panelsecilenkelime";
            this.panelsecilenkelime.Size = new System.Drawing.Size(200, 37);
            this.panelsecilenkelime.TabIndex = 0;
            // 
            // panelsesliharf
            // 
            this.panelsesliharf.Location = new System.Drawing.Point(139, 239);
            this.panelsesliharf.Name = "panelsesliharf";
            this.panelsesliharf.Size = new System.Drawing.Size(200, 37);
            this.panelsesliharf.TabIndex = 0;
            this.panelsesliharf.Visible = false;
            // 
            // panelsessizharf
            // 
            this.panelsessizharf.Location = new System.Drawing.Point(139, 292);
            this.panelsessizharf.Name = "panelsessizharf";
            this.panelsessizharf.Size = new System.Drawing.Size(200, 100);
            this.panelsessizharf.TabIndex = 0;
            // 
            // btnsesli
            // 
            this.btnsesli.Location = new System.Drawing.Point(124, 191);
            this.btnsesli.Name = "btnsesli";
            this.btnsesli.Size = new System.Drawing.Size(90, 42);
            this.btnsesli.TabIndex = 1;
            this.btnsesli.Text = "Sesli Harf";
            this.btnsesli.UseVisualStyleBackColor = true;
            this.btnsesli.Click += new System.EventHandler(this.btnünlü_Click);
            // 
            // btntahmin
            // 
            this.btntahmin.Location = new System.Drawing.Point(220, 191);
            this.btntahmin.Name = "btntahmin";
            this.btntahmin.Size = new System.Drawing.Size(75, 42);
            this.btntahmin.TabIndex = 2;
            this.btntahmin.Text = "Tahmin Et";
            this.btntahmin.UseVisualStyleBackColor = true;
            this.btntahmin.Click += new System.EventHandler(this.btntahmin_Click);
            // 
            // btnkelimegöster
            // 
            this.btnkelimegöster.Location = new System.Drawing.Point(301, 191);
            this.btnkelimegöster.Name = "btnkelimegöster";
            this.btnkelimegöster.Size = new System.Drawing.Size(90, 42);
            this.btnkelimegöster.TabIndex = 3;
            this.btnkelimegöster.Text = "Kelime Göster";
            this.btnkelimegöster.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Toplam Puan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kalan Harf";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sesli Harf Hakkı";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 49);
            this.button4.TabIndex = 7;
            this.button4.Text = "Bonus Sessiz Harf";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // grbxtahmin
            // 
            this.grbxtahmin.Controls.Add(this.button6);
            this.grbxtahmin.Controls.Add(this.button5);
            this.grbxtahmin.Controls.Add(this.txttahmin);
            this.grbxtahmin.Location = new System.Drawing.Point(407, 191);
            this.grbxtahmin.Name = "grbxtahmin";
            this.grbxtahmin.Size = new System.Drawing.Size(273, 201);
            this.grbxtahmin.TabIndex = 8;
            this.grbxtahmin.TabStop = false;
            this.grbxtahmin.Text = "Tahmin Et";
            this.grbxtahmin.Visible = false;
            // 
            // txttahmin
            // 
            this.txttahmin.Location = new System.Drawing.Point(75, 43);
            this.txttahmin.Name = "txttahmin";
            this.txttahmin.Size = new System.Drawing.Size(100, 20);
            this.txttahmin.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Tahmin Et";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(130, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Tahmin Etme";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 562);
            this.Controls.Add(this.grbxtahmin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnkelimegöster);
            this.Controls.Add(this.btntahmin);
            this.Controls.Add(this.btnsesli);
            this.Controls.Add(this.panelsessizharf);
            this.Controls.Add(this.panelsesliharf);
            this.Controls.Add(this.panelsecilenkelime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbxtahmin.ResumeLayout(false);
            this.grbxtahmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsecilenkelime;
        private System.Windows.Forms.Panel panelsesliharf;
        private System.Windows.Forms.Panel panelsessizharf;
        private System.Windows.Forms.Button btnsesli;
        private System.Windows.Forms.Button btntahmin;
        private System.Windows.Forms.Button btnkelimegöster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grbxtahmin;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txttahmin;
    }
}

