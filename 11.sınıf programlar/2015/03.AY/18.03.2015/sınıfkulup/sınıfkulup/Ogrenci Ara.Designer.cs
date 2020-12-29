namespace sınıfkulup
{
    partial class Ogrenci_Ara
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
            this.cmbxaramkriteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaranacak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxaramkriteri
            // 
            this.cmbxaramkriteri.FormattingEnabled = true;
            this.cmbxaramkriteri.Items.AddRange(new object[] {
            "Okul Numarasına Göre Ara",
            "Ada Göre Ara",
            "Soyada Ara"});
            this.cmbxaramkriteri.Location = new System.Drawing.Point(15, 25);
            this.cmbxaramkriteri.Name = "cmbxaramkriteri";
            this.cmbxaramkriteri.Size = new System.Drawing.Size(121, 21);
            this.cmbxaramkriteri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Kriteri";
            // 
            // txtaranacak
            // 
            this.txtaranacak.Location = new System.Drawing.Point(15, 65);
            this.txtaranacak.Name = "txtaranacak";
            this.txtaranacak.Size = new System.Drawing.Size(100, 20);
            this.txtaranacak.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aranacak Değer";
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(144, 65);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 4;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 243);
            this.dataGridView1.TabIndex = 5;
            // 
            // Ogrenci_Ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaranacak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxaramkriteri);
            this.Name = "Ogrenci_Ara";
            this.Text = "Ogrenci_Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxaramkriteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaranacak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}