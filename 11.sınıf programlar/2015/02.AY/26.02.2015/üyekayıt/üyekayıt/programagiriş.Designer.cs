namespace üyekayıt
{
    partial class programagiriş
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
            this.btncıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(225, 12);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(63, 46);
            this.btncıkıs.TabIndex = 0;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // programagiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 285);
            this.Controls.Add(this.btncıkıs);
            this.Name = "programagiriş";
            this.Text = "programagiriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncıkıs;
    }
}