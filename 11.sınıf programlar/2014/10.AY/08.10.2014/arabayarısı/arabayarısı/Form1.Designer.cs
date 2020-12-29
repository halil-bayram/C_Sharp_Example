namespace arabayarısı
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
            this.btnaraba = new System.Windows.Forms.Button();
            this.süre = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnaraba
            // 
            this.btnaraba.AutoEllipsis = true;
            this.btnaraba.BackgroundImage = global::arabayarısı.Properties.Resources.Aston_Martin_Virage_;
            this.btnaraba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaraba.Location = new System.Drawing.Point(3, 3);
            this.btnaraba.Name = "btnaraba";
            this.btnaraba.Size = new System.Drawing.Size(84, 31);
            this.btnaraba.TabIndex = 0;
            this.btnaraba.UseVisualStyleBackColor = true;
            // 
            // süre
            // 
            this.süre.Tick += new System.EventHandler(this.süre_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 309);
            this.Controls.Add(this.btnaraba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaraba;
        private System.Windows.Forms.Timer süre;
    }
}

