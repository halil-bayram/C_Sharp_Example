namespace birimhesaplama
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
            this.txtüst = new System.Windows.Forms.TextBox();
            this.txttaban = new System.Windows.Forms.TextBox();
            this.btncevir = new System.Windows.Forms.Button();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtüst
            // 
            this.txtüst.Location = new System.Drawing.Point(214, 38);
            this.txtüst.Name = "txtüst";
            this.txtüst.Size = new System.Drawing.Size(110, 20);
            this.txtüst.TabIndex = 0;
            // 
            // txttaban
            // 
            this.txttaban.Location = new System.Drawing.Point(214, 12);
            this.txttaban.Name = "txttaban";
            this.txttaban.Size = new System.Drawing.Size(110, 20);
            this.txttaban.TabIndex = 1;
            // 
            // btncevir
            // 
            this.btncevir.Location = new System.Drawing.Point(214, 123);
            this.btncevir.Name = "btncevir";
            this.btncevir.Size = new System.Drawing.Size(103, 30);
            this.btncevir.TabIndex = 3;
            this.btncevir.Text = "ÇEVİR";
            this.btncevir.UseVisualStyleBackColor = true;
            this.btncevir.Click += new System.EventHandler(this.btncevir_Click);
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(214, 81);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(116, 20);
            this.txtsonuc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TABAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ÜST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SONUC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.btncevir);
            this.Controls.Add(this.txttaban);
            this.Controls.Add(this.txtüst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtüst;
        private System.Windows.Forms.TextBox txttaban;
        private System.Windows.Forms.Button btncevir;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

