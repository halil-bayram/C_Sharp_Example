namespace DAKIKALIOYUN
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lblsüre = new System.Windows.Forms.Label();
            this.lbltıklama = new System.Windows.Forms.Label();
            this.tmrsüre = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(85, 77);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(128, 48);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "beni yakala";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Location = new System.Drawing.Point(21, 14);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(35, 13);
            this.lblsüre.TabIndex = 1;
            this.lblsüre.Text = "label1";
            // 
            // lbltıklama
            // 
            this.lbltıklama.AutoSize = true;
            this.lbltıklama.Location = new System.Drawing.Point(110, 15);
            this.lbltıklama.Name = "lbltıklama";
            this.lbltıklama.Size = new System.Drawing.Size(35, 13);
            this.lbltıklama.TabIndex = 2;
            this.lbltıklama.Text = "label2";
            // 
            // tmrsüre
            // 
            this.tmrsüre.Interval = 1000;
            this.tmrsüre.Tick += new System.EventHandler(this.tmrsüre_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 31);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(167, 17);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbltıklama);
            this.Controls.Add(this.lblsüre);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.Label lbltıklama;
        private System.Windows.Forms.Timer tmrsüre;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

