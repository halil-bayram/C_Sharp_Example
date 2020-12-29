namespace matsoyunu
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
            this.lblsayı1 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.lblsayı2 = new System.Windows.Forms.Label();
            this.lblesit = new System.Windows.Forms.Label();
            this.lblartı = new System.Windows.Forms.Label();
            this.btnd = new System.Windows.Forms.Button();
            this.btny = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblsayac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsayı1
            // 
            this.lblsayı1.AutoSize = true;
            this.lblsayı1.Location = new System.Drawing.Point(43, 78);
            this.lblsayı1.Name = "lblsayı1";
            this.lblsayı1.Size = new System.Drawing.Size(0, 13);
            this.lblsayı1.TabIndex = 0;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(234, 78);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 13);
            this.lblsonuc.TabIndex = 1;
            // 
            // lblsayı2
            // 
            this.lblsayı2.AutoSize = true;
            this.lblsayı2.Location = new System.Drawing.Point(130, 78);
            this.lblsayı2.Name = "lblsayı2";
            this.lblsayı2.Size = new System.Drawing.Size(0, 13);
            this.lblsayı2.TabIndex = 2;
            // 
            // lblesit
            // 
            this.lblesit.AutoSize = true;
            this.lblesit.Location = new System.Drawing.Point(171, 78);
            this.lblesit.Name = "lblesit";
            this.lblesit.Size = new System.Drawing.Size(13, 13);
            this.lblesit.TabIndex = 3;
            this.lblesit.Text = "=";
            // 
            // lblartı
            // 
            this.lblartı.AutoSize = true;
            this.lblartı.Location = new System.Drawing.Point(84, 78);
            this.lblartı.Name = "lblartı";
            this.lblartı.Size = new System.Drawing.Size(13, 13);
            this.lblartı.TabIndex = 4;
            this.lblartı.Text = "+";
            // 
            // btnd
            // 
            this.btnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnd.Location = new System.Drawing.Point(41, 200);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(56, 26);
            this.btnd.TabIndex = 5;
            this.btnd.Text = "Dogru";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btny
            // 
            this.btny.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btny.Location = new System.Drawing.Point(141, 200);
            this.btny.Name = "btny";
            this.btny.Size = new System.Drawing.Size(56, 26);
            this.btny.TabIndex = 6;
            this.btny.Text = "Yanlış";
            this.btny.UseVisualStyleBackColor = true;
            this.btny.Click += new System.EventHandler(this.btny_Click);
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblsayac
            // 
            this.lblsayac.AutoSize = true;
            this.lblsayac.Location = new System.Drawing.Point(208, 19);
            this.lblsayac.Name = "lblsayac";
            this.lblsayac.Size = new System.Drawing.Size(0, 13);
            this.lblsayac.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblsayac);
            this.Controls.Add(this.btny);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.lblartı);
            this.Controls.Add(this.lblesit);
            this.Controls.Add(this.lblsayı2);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.lblsayı1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsayı1;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label lblsayı2;
        private System.Windows.Forms.Label lblesit;
        private System.Windows.Forms.Label lblartı;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btny;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lblsayac;
    }
}

