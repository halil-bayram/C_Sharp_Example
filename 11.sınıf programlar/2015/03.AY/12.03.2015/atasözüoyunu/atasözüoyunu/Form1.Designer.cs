namespace atasözüoyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblkullanıcı = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblsüre = new System.Windows.Forms.Label();
            this.lblatasözü = new System.Windows.Forms.Label();
            this.btna = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.btnpas = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.lblkullanıcı);
            this.panel1.Controls.Add(this.lblpuan);
            this.panel1.Controls.Add(this.lblsüre);
            this.panel1.Controls.Add(this.lblatasözü);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 142);
            this.panel1.TabIndex = 0;
            // 
            // lblkullanıcı
            // 
            this.lblkullanıcı.AutoSize = true;
            this.lblkullanıcı.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanıcı.ForeColor = System.Drawing.Color.Lime;
            this.lblkullanıcı.Location = new System.Drawing.Point(15, 4);
            this.lblkullanıcı.Name = "lblkullanıcı";
            this.lblkullanıcı.Size = new System.Drawing.Size(0, 24);
            this.lblkullanıcı.TabIndex = 3;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.ForeColor = System.Drawing.Color.Lime;
            this.lblpuan.Location = new System.Drawing.Point(289, 4);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(65, 24);
            this.lblpuan.TabIndex = 2;
            this.lblpuan.Text = "Puan:";
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsüre.ForeColor = System.Drawing.Color.Lime;
            this.lblsüre.Location = new System.Drawing.Point(373, 4);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(51, 24);
            this.lblsüre.TabIndex = 1;
            this.lblsüre.Text = "Süre";
            // 
            // lblatasözü
            // 
            this.lblatasözü.AutoSize = true;
            this.lblatasözü.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblatasözü.ForeColor = System.Drawing.Color.Lime;
            this.lblatasözü.Location = new System.Drawing.Point(50, 52);
            this.lblatasözü.Name = "lblatasözü";
            this.lblatasözü.Size = new System.Drawing.Size(0, 24);
            this.lblatasözü.TabIndex = 0;
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.Color.Orange;
            this.btna.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btna.Location = new System.Drawing.Point(13, 200);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(109, 27);
            this.btna.TabIndex = 1;
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnb
            // 
            this.btnb.BackColor = System.Drawing.Color.Orange;
            this.btnb.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnb.Location = new System.Drawing.Point(128, 200);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(109, 27);
            this.btnb.TabIndex = 1;
            this.btnb.UseVisualStyleBackColor = false;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.Orange;
            this.btnc.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnc.Location = new System.Drawing.Point(243, 200);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(109, 27);
            this.btnc.TabIndex = 1;
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnd
            // 
            this.btnd.BackColor = System.Drawing.Color.Orange;
            this.btnd.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnd.Location = new System.Drawing.Point(358, 200);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(109, 27);
            this.btnd.TabIndex = 1;
            this.btnd.UseVisualStyleBackColor = false;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btnpas
            // 
            this.btnpas.BackColor = System.Drawing.Color.Orange;
            this.btnpas.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpas.Location = new System.Drawing.Point(192, 12);
            this.btnpas.Name = "btnpas";
            this.btnpas.Size = new System.Drawing.Size(75, 34);
            this.btnpas.TabIndex = 2;
            this.btnpas.Text = "Pas";
            this.btnpas.UseVisualStyleBackColor = false;
            this.btnpas.Click += new System.EventHandler(this.btnpas_Click);
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1500;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 239);
            this.Controls.Add(this.btnpas);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblatasözü;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btnpas;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblkullanıcı;
    }
}

