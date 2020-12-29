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
            this.marka = new System.Windows.Forms.ComboBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.tam = new System.Windows.Forms.Button();
            this.eski = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.foto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
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
            this.marka.Location = new System.Drawing.Point(24, 70);
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
            this.model.Location = new System.Drawing.Point(24, 113);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(121, 29);
            this.model.TabIndex = 2;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // tam
            // 
            this.tam.Location = new System.Drawing.Point(24, 9);
            this.tam.Name = "tam";
            this.tam.Size = new System.Drawing.Size(120, 39);
            this.tam.TabIndex = 3;
            this.tam.Text = "Tam Ekran";
            this.tam.UseVisualStyleBackColor = true;
            this.tam.Click += new System.EventHandler(this.tam_Click);
            // 
            // eski
            // 
            this.eski.Location = new System.Drawing.Point(24, 161);
            this.eski.Name = "eski";
            this.eski.Size = new System.Drawing.Size(120, 39);
            this.eski.TabIndex = 4;
            this.eski.Text = "Tam Ekrandan Çık";
            this.eski.UseVisualStyleBackColor = true;
            this.eski.Click += new System.EventHandler(this.eski_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eski);
            this.groupBox1.Controls.Add(this.marka);
            this.groupBox1.Controls.Add(this.tam);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.foto);
            this.groupBox2.Location = new System.Drawing.Point(245, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // foto
            // 
            this.foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foto.Location = new System.Drawing.Point(3, 16);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(296, 178);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Tl11-a Galerisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.Button tam;
        private System.Windows.Forms.Button eski;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox foto;
    }
}

