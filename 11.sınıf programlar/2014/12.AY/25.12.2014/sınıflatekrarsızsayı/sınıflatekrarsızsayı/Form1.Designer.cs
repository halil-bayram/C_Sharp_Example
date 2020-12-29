namespace sınıflatekrarsızsayı
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
            this.txtadet = new System.Windows.Forms.TextBox();
            this.txtküçüksayı = new System.Windows.Forms.TextBox();
            this.txtbüyüksayı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbçift = new System.Windows.Forms.RadioButton();
            this.rdbtek = new System.Windows.Forms.RadioButton();
            this.cbxkatları = new System.Windows.Forms.ComboBox();
            this.btnoluştur = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(134, 126);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(100, 20);
            this.txtadet.TabIndex = 0;
            // 
            // txtküçüksayı
            // 
            this.txtküçüksayı.Location = new System.Drawing.Point(134, 161);
            this.txtküçüksayı.Name = "txtküçüksayı";
            this.txtküçüksayı.Size = new System.Drawing.Size(100, 20);
            this.txtküçüksayı.TabIndex = 1;
            // 
            // txtbüyüksayı
            // 
            this.txtbüyüksayı.Location = new System.Drawing.Point(134, 198);
            this.txtbüyüksayı.Name = "txtbüyüksayı";
            this.txtbüyüksayı.Size = new System.Drawing.Size(100, 20);
            this.txtbüyüksayı.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Küçük sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Büyük Sayı";
            // 
            // rdbçift
            // 
            this.rdbçift.AutoSize = true;
            this.rdbçift.Location = new System.Drawing.Point(79, 241);
            this.rdbçift.Name = "rdbçift";
            this.rdbçift.Size = new System.Drawing.Size(74, 17);
            this.rdbçift.TabIndex = 6;
            this.rdbçift.TabStop = true;
            this.rdbçift.Text = "Çift Sayılar";
            this.rdbçift.UseVisualStyleBackColor = true;
            this.rdbçift.CheckedChanged += new System.EventHandler(this.rdbçift_CheckedChanged);
            // 
            // rdbtek
            // 
            this.rdbtek.AutoSize = true;
            this.rdbtek.Location = new System.Drawing.Point(149, 241);
            this.rdbtek.Name = "rdbtek";
            this.rdbtek.Size = new System.Drawing.Size(78, 17);
            this.rdbtek.TabIndex = 7;
            this.rdbtek.TabStop = true;
            this.rdbtek.Text = "Tek Sayılar";
            this.rdbtek.UseVisualStyleBackColor = true;
            this.rdbtek.CheckedChanged += new System.EventHandler(this.rdbtek_CheckedChanged);
            // 
            // cbxkatları
            // 
            this.cbxkatları.FormattingEnabled = true;
            this.cbxkatları.Items.AddRange(new object[] {
            "Katları boş",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxkatları.Location = new System.Drawing.Point(134, 284);
            this.cbxkatları.Name = "cbxkatları";
            this.cbxkatları.Size = new System.Drawing.Size(100, 21);
            this.cbxkatları.TabIndex = 8;
            this.cbxkatları.SelectedIndexChanged += new System.EventHandler(this.cbxkatları_SelectedIndexChanged);
            // 
            // btnoluştur
            // 
            this.btnoluştur.Location = new System.Drawing.Point(149, 337);
            this.btnoluştur.Name = "btnoluştur";
            this.btnoluştur.Size = new System.Drawing.Size(75, 23);
            this.btnoluştur.TabIndex = 9;
            this.btnoluştur.Text = "Oluştur";
            this.btnoluştur.UseVisualStyleBackColor = true;
            this.btnoluştur.Click += new System.EventHandler(this.btnoluştur_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(281, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 277);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 449);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnoluştur);
            this.Controls.Add(this.cbxkatları);
            this.Controls.Add(this.rdbtek);
            this.Controls.Add(this.rdbçift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbüyüksayı);
            this.Controls.Add(this.txtküçüksayı);
            this.Controls.Add(this.txtadet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.TextBox txtküçüksayı;
        private System.Windows.Forms.TextBox txtbüyüksayı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbçift;
        private System.Windows.Forms.RadioButton rdbtek;
        private System.Windows.Forms.ComboBox cbxkatları;
        private System.Windows.Forms.Button btnoluştur;
        private System.Windows.Forms.ListBox listBox1;
    }
}

