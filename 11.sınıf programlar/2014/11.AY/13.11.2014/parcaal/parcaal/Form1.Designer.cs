namespace parcaal
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
            this.txtgirilenmetin = new System.Windows.Forms.TextBox();
            this.txtparcalımetin = new System.Windows.Forms.TextBox();
            this.txtkaraktesayısı = new System.Windows.Forms.TextBox();
            this.txtbaslangıcsayısı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbbastan = new System.Windows.Forms.RadioButton();
            this.rdbortadan = new System.Windows.Forms.RadioButton();
            this.rdbsondan = new System.Windows.Forms.RadioButton();
            this.btnparcala = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtgirilenmetin
            // 
            this.txtgirilenmetin.Location = new System.Drawing.Point(28, 98);
            this.txtgirilenmetin.Multiline = true;
            this.txtgirilenmetin.Name = "txtgirilenmetin";
            this.txtgirilenmetin.Size = new System.Drawing.Size(265, 172);
            this.txtgirilenmetin.TabIndex = 0;
            this.txtgirilenmetin.TextChanged += new System.EventHandler(this.txtgirilenmetin_TextChanged);
            // 
            // txtparcalımetin
            // 
            this.txtparcalımetin.Location = new System.Drawing.Point(27, 27);
            this.txtparcalımetin.Multiline = true;
            this.txtparcalımetin.Name = "txtparcalımetin";
            this.txtparcalımetin.Size = new System.Drawing.Size(265, 147);
            this.txtparcalımetin.TabIndex = 1;
            // 
            // txtkaraktesayısı
            // 
            this.txtkaraktesayısı.Location = new System.Drawing.Point(419, 171);
            this.txtkaraktesayısı.Name = "txtkaraktesayısı";
            this.txtkaraktesayısı.Size = new System.Drawing.Size(164, 20);
            this.txtkaraktesayısı.TabIndex = 2;
            // 
            // txtbaslangıcsayısı
            // 
            this.txtbaslangıcsayısı.Location = new System.Drawing.Point(419, 206);
            this.txtbaslangıcsayısı.Name = "txtbaslangıcsayısı";
            this.txtbaslangıcsayısı.Size = new System.Drawing.Size(164, 20);
            this.txtbaslangıcsayısı.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "METİN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PARCALI METİN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "KARAKTER SAYISI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BAŞLANGIC SAYISI";
            // 
            // rdbbastan
            // 
            this.rdbbastan.AutoSize = true;
            this.rdbbastan.Location = new System.Drawing.Point(335, 94);
            this.rdbbastan.Name = "rdbbastan";
            this.rdbbastan.Size = new System.Drawing.Size(68, 17);
            this.rdbbastan.TabIndex = 8;
            this.rdbbastan.TabStop = true;
            this.rdbbastan.Text = "BAŞTAN";
            this.rdbbastan.UseVisualStyleBackColor = true;
            this.rdbbastan.CheckedChanged += new System.EventHandler(this.rdbbastan_CheckedChanged);
            // 
            // rdbortadan
            // 
            this.rdbortadan.AutoSize = true;
            this.rdbortadan.Location = new System.Drawing.Point(335, 117);
            this.rdbortadan.Name = "rdbortadan";
            this.rdbortadan.Size = new System.Drawing.Size(78, 17);
            this.rdbortadan.TabIndex = 9;
            this.rdbortadan.TabStop = true;
            this.rdbortadan.Text = "ORTADAN";
            this.rdbortadan.UseVisualStyleBackColor = true;
            this.rdbortadan.CheckedChanged += new System.EventHandler(this.rdbortadan_CheckedChanged);
            // 
            // rdbsondan
            // 
            this.rdbsondan.AutoSize = true;
            this.rdbsondan.Location = new System.Drawing.Point(335, 140);
            this.rdbsondan.Name = "rdbsondan";
            this.rdbsondan.Size = new System.Drawing.Size(71, 17);
            this.rdbsondan.TabIndex = 10;
            this.rdbsondan.TabStop = true;
            this.rdbsondan.Text = "SONDAN";
            this.rdbsondan.UseVisualStyleBackColor = true;
            this.rdbsondan.CheckedChanged += new System.EventHandler(this.rdbsondan_CheckedChanged);
            // 
            // btnparcala
            // 
            this.btnparcala.Location = new System.Drawing.Point(403, 232);
            this.btnparcala.Name = "btnparcala";
            this.btnparcala.Size = new System.Drawing.Size(115, 38);
            this.btnparcala.TabIndex = 11;
            this.btnparcala.Text = "PARCALA";
            this.btnparcala.UseVisualStyleBackColor = true;
            this.btnparcala.Click += new System.EventHandler(this.btnparcala_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtparcalımetin);
            this.groupBox1.Location = new System.Drawing.Point(141, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 188);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnparcala);
            this.Controls.Add(this.rdbsondan);
            this.Controls.Add(this.rdbortadan);
            this.Controls.Add(this.rdbbastan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbaslangıcsayısı);
            this.Controls.Add(this.txtkaraktesayısı);
            this.Controls.Add(this.txtgirilenmetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgirilenmetin;
        private System.Windows.Forms.TextBox txtparcalımetin;
        private System.Windows.Forms.TextBox txtkaraktesayısı;
        private System.Windows.Forms.TextBox txtbaslangıcsayısı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbbastan;
        private System.Windows.Forms.RadioButton rdbortadan;
        private System.Windows.Forms.RadioButton rdbsondan;
        private System.Windows.Forms.Button btnparcala;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

