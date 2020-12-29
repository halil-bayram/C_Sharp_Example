namespace arabalar
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
            this.foto = new System.Windows.Forms.PictureBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.model = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(214, 12);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(302, 201);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // marka
            // 
            this.marka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.marka.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marka.ForeColor = System.Drawing.Color.Red;
            this.marka.FormattingEnabled = true;
            this.marka.Items.AddRange(new object[] {
            "AUDİ",
            "BMW",
            "HONDA",
            "NİSSAN",
            "VOLKSWAGEN",
            "RENAULT"});
            this.marka.Location = new System.Drawing.Point(39, 73);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(121, 29);
            this.marka.TabIndex = 1;
            this.marka.SelectedIndexChanged += new System.EventHandler(this.marka_SelectedIndexChanged);
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.model.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.ForeColor = System.Drawing.Color.Red;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(39, 116);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(121, 29);
            this.model.TabIndex = 2;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 225);
            this.Controls.Add(this.model);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Tl11-a Galerisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.ComboBox model;
    }
}

