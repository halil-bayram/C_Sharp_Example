namespace sinemarandevu
{
    partial class Giriş
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
            this.btnfilmekle = new System.Windows.Forms.Button();
            this.btnsatış = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfilmekle
            // 
            this.btnfilmekle.Location = new System.Drawing.Point(52, 12);
            this.btnfilmekle.Name = "btnfilmekle";
            this.btnfilmekle.Size = new System.Drawing.Size(133, 67);
            this.btnfilmekle.TabIndex = 0;
            this.btnfilmekle.Text = "Film Ekle";
            this.btnfilmekle.UseVisualStyleBackColor = true;
            this.btnfilmekle.Click += new System.EventHandler(this.btnfilmekle_Click);
            // 
            // btnsatış
            // 
            this.btnsatış.Location = new System.Drawing.Point(52, 96);
            this.btnsatış.Name = "btnsatış";
            this.btnsatış.Size = new System.Drawing.Size(133, 67);
            this.btnsatış.TabIndex = 0;
            this.btnsatış.Text = "Bilet satış";
            this.btnsatış.UseVisualStyleBackColor = true;
            this.btnsatış.Click += new System.EventHandler(this.btnsatış_Click);
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 215);
            this.Controls.Add(this.btnsatış);
            this.Controls.Add(this.btnfilmekle);
            this.Name = "Giriş";
            this.Text = "Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfilmekle;
        private System.Windows.Forms.Button btnsatış;
    }
}