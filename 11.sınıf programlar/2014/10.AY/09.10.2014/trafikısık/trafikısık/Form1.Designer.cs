namespace trafikısık
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
            this.btnkırmızı = new System.Windows.Forms.Button();
            this.btnyesil = new System.Windows.Forms.Button();
            this.btnsarı = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsarı1 = new System.Windows.Forms.Button();
            this.btnkırmızı1 = new System.Windows.Forms.Button();
            this.btnyesil1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnkırmızı
            // 
            this.btnkırmızı.Location = new System.Drawing.Point(20, 28);
            this.btnkırmızı.Name = "btnkırmızı";
            this.btnkırmızı.Size = new System.Drawing.Size(49, 43);
            this.btnkırmızı.TabIndex = 0;
            this.btnkırmızı.UseVisualStyleBackColor = true;
            // 
            // btnyesil
            // 
            this.btnyesil.Location = new System.Drawing.Point(20, 130);
            this.btnyesil.Name = "btnyesil";
            this.btnyesil.Size = new System.Drawing.Size(49, 43);
            this.btnyesil.TabIndex = 1;
            this.btnyesil.UseVisualStyleBackColor = true;
            // 
            // btnsarı
            // 
            this.btnsarı.Location = new System.Drawing.Point(20, 79);
            this.btnsarı.Name = "btnsarı";
            this.btnsarı.Size = new System.Drawing.Size(49, 43);
            this.btnsarı.TabIndex = 2;
            this.btnsarı.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btnsarı);
            this.groupBox1.Controls.Add(this.btnkırmızı);
            this.groupBox1.Controls.Add(this.btnyesil);
            this.groupBox1.Location = new System.Drawing.Point(98, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.btnsarı1);
            this.groupBox2.Controls.Add(this.btnkırmızı1);
            this.groupBox2.Controls.Add(this.btnyesil1);
            this.groupBox2.Location = new System.Drawing.Point(289, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnsarı1
            // 
            this.btnsarı1.Location = new System.Drawing.Point(20, 81);
            this.btnsarı1.Name = "btnsarı1";
            this.btnsarı1.Size = new System.Drawing.Size(49, 43);
            this.btnsarı1.TabIndex = 2;
            this.btnsarı1.UseVisualStyleBackColor = true;
            // 
            // btnkırmızı1
            // 
            this.btnkırmızı1.Location = new System.Drawing.Point(20, 28);
            this.btnkırmızı1.Name = "btnkırmızı1";
            this.btnkırmızı1.Size = new System.Drawing.Size(49, 43);
            this.btnkırmızı1.TabIndex = 0;
            this.btnkırmızı1.UseVisualStyleBackColor = true;
            // 
            // btnyesil1
            // 
            this.btnyesil1.Location = new System.Drawing.Point(20, 130);
            this.btnyesil1.Name = "btnyesil1";
            this.btnyesil1.Size = new System.Drawing.Size(49, 43);
            this.btnyesil1.TabIndex = 1;
            this.btnyesil1.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(218, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 25);
            this.lbl1.TabIndex = 6;
            this.lbl1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 262);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkırmızı;
        private System.Windows.Forms.Button btnyesil;
        private System.Windows.Forms.Button btnsarı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsarı1;
        private System.Windows.Forms.Button btnkırmızı1;
        private System.Windows.Forms.Button btnyesil1;
        private System.Windows.Forms.Button lbl1;
    }
}

