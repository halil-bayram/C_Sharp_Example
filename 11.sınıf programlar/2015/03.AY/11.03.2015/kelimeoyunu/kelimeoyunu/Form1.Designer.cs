namespace kelimeoyunu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtkelime = new System.Windows.Forms.TextBox();
            this.btnonayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsüre = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 109);
            this.panel1.TabIndex = 0;
            // 
            // txtkelime
            // 
            this.txtkelime.Location = new System.Drawing.Point(254, 16);
            this.txtkelime.Name = "txtkelime";
            this.txtkelime.Size = new System.Drawing.Size(100, 20);
            this.txtkelime.TabIndex = 1;
            this.txtkelime.TextChanged += new System.EventHandler(this.txtkelime_TextChanged);
            // 
            // btnonayla
            // 
            this.btnonayla.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnonayla.Location = new System.Drawing.Point(220, 42);
            this.btnonayla.Name = "btnonayla";
            this.btnonayla.Size = new System.Drawing.Size(75, 23);
            this.btnonayla.TabIndex = 2;
            this.btnonayla.Text = "Onayla";
            this.btnonayla.UseVisualStyleBackColor = true;
            this.btnonayla.Click += new System.EventHandler(this.btnonayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kelime Giriniz:";
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsüre.ForeColor = System.Drawing.Color.Yellow;
            this.lblsüre.Location = new System.Drawing.Point(135, 46);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(45, 19);
            this.lblsüre.TabIndex = 4;
            this.lblsüre.Text = "Süre:";
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(365, 142);
            this.Controls.Add(this.lblsüre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnonayla);
            this.Controls.Add(this.txtkelime);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kelime Bul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtkelime;
        private System.Windows.Forms.Button btnonayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.Timer tmr1;
    }
}

