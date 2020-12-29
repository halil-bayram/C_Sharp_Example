namespace futbolkadro
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
            this.lsbkadro = new System.Windows.Forms.ListBox();
            this.lsbasılkadro = new System.Windows.Forms.ListBox();
            this.lsbyedek = new System.Windows.Forms.ListBox();
            this.btnilkbes = new System.Windows.Forms.Button();
            this.btnoyuncudegis = new System.Windows.Forms.Button();
            this.btnyedek = new System.Windows.Forms.Button();
            this.btnilkbestencıkar = new System.Windows.Forms.Button();
            this.btnyedekcıkar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbkadro
            // 
            this.lsbkadro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lsbkadro.FormattingEnabled = true;
            this.lsbkadro.Items.AddRange(new object[] {
            "veli",
            "hüseyin",
            "burak",
            "ismail",
            "fatih",
            "yunus",
            "emre",
            "murat",
            "ali",
            "can",
            "kemal",
            "mefta"});
            this.lsbkadro.Location = new System.Drawing.Point(29, 48);
            this.lsbkadro.Name = "lsbkadro";
            this.lsbkadro.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbkadro.Size = new System.Drawing.Size(106, 160);
            this.lsbkadro.TabIndex = 0;
            // 
            // lsbasılkadro
            // 
            this.lsbasılkadro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lsbasılkadro.FormattingEnabled = true;
            this.lsbasılkadro.Location = new System.Drawing.Point(285, 48);
            this.lsbasılkadro.Name = "lsbasılkadro";
            this.lsbasılkadro.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbasılkadro.Size = new System.Drawing.Size(106, 160);
            this.lsbasılkadro.TabIndex = 1;
            // 
            // lsbyedek
            // 
            this.lsbyedek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lsbyedek.FormattingEnabled = true;
            this.lsbyedek.Location = new System.Drawing.Point(157, 194);
            this.lsbyedek.Name = "lsbyedek";
            this.lsbyedek.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbyedek.Size = new System.Drawing.Size(106, 160);
            this.lsbyedek.TabIndex = 2;
            // 
            // btnilkbes
            // 
            this.btnilkbes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnilkbes.Location = new System.Drawing.Point(167, 34);
            this.btnilkbes.Name = "btnilkbes";
            this.btnilkbes.Size = new System.Drawing.Size(82, 35);
            this.btnilkbes.TabIndex = 3;
            this.btnilkbes.Text = "ilk beşi sec";
            this.btnilkbes.UseVisualStyleBackColor = false;
            this.btnilkbes.Click += new System.EventHandler(this.btnilkbes_Click);
            // 
            // btnoyuncudegis
            // 
            this.btnoyuncudegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnoyuncudegis.Location = new System.Drawing.Point(167, 153);
            this.btnoyuncudegis.Name = "btnoyuncudegis";
            this.btnoyuncudegis.Size = new System.Drawing.Size(82, 35);
            this.btnoyuncudegis.TabIndex = 4;
            this.btnoyuncudegis.Text = "oyuncu degişikligi";
            this.btnoyuncudegis.UseVisualStyleBackColor = false;
            this.btnoyuncudegis.Click += new System.EventHandler(this.btnoyuncudegis_Click);
            // 
            // btnyedek
            // 
            this.btnyedek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnyedek.Location = new System.Drawing.Point(167, 75);
            this.btnyedek.Name = "btnyedek";
            this.btnyedek.Size = new System.Drawing.Size(82, 35);
            this.btnyedek.TabIndex = 5;
            this.btnyedek.Text = "yedekler";
            this.btnyedek.UseVisualStyleBackColor = false;
            this.btnyedek.Click += new System.EventHandler(this.btnyedek_Click);
            // 
            // btnilkbestencıkar
            // 
            this.btnilkbestencıkar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnilkbestencıkar.Location = new System.Drawing.Point(295, 7);
            this.btnilkbestencıkar.Name = "btnilkbestencıkar";
            this.btnilkbestencıkar.Size = new System.Drawing.Size(87, 35);
            this.btnilkbestencıkar.TabIndex = 6;
            this.btnilkbestencıkar.Text = "ilk beşten cıkar";
            this.btnilkbestencıkar.UseVisualStyleBackColor = false;
            this.btnilkbestencıkar.Click += new System.EventHandler(this.btnilkbestencıkar_Click);
            // 
            // btnyedekcıkar
            // 
            this.btnyedekcıkar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnyedekcıkar.Location = new System.Drawing.Point(167, 360);
            this.btnyedekcıkar.Name = "btnyedekcıkar";
            this.btnyedekcıkar.Size = new System.Drawing.Size(87, 35);
            this.btnyedekcıkar.TabIndex = 7;
            this.btnyedekcıkar.Text = "yedekten cıkar";
            this.btnyedekcıkar.UseVisualStyleBackColor = false;
            this.btnyedekcıkar.Click += new System.EventHandler(this.btnyedekcıkar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(421, 408);
            this.Controls.Add(this.btnyedekcıkar);
            this.Controls.Add(this.btnilkbestencıkar);
            this.Controls.Add(this.btnyedek);
            this.Controls.Add(this.btnoyuncudegis);
            this.Controls.Add(this.btnilkbes);
            this.Controls.Add(this.lsbyedek);
            this.Controls.Add(this.lsbasılkadro);
            this.Controls.Add(this.lsbkadro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbkadro;
        private System.Windows.Forms.ListBox lsbasılkadro;
        private System.Windows.Forms.ListBox lsbyedek;
        private System.Windows.Forms.Button btnilkbes;
        private System.Windows.Forms.Button btnoyuncudegis;
        private System.Windows.Forms.Button btnyedek;
        private System.Windows.Forms.Button btnilkbestencıkar;
        private System.Windows.Forms.Button btnyedekcıkar;
    }
}

