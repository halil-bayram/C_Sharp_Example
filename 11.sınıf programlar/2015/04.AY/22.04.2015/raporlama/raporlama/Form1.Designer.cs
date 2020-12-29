namespace raporlama
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
            this.btnraporal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbokulturu = new System.Windows.Forms.ComboBox();
            this.cbsınıf = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbelge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnraporal
            // 
            this.btnraporal.Location = new System.Drawing.Point(348, 43);
            this.btnraporal.Name = "btnraporal";
            this.btnraporal.Size = new System.Drawing.Size(75, 23);
            this.btnraporal.TabIndex = 0;
            this.btnraporal.Text = "Rapor al";
            this.btnraporal.UseVisualStyleBackColor = true;
            this.btnraporal.Click += new System.EventHandler(this.btnraporal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Okul Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sınıf";
            // 
            // cbokulturu
            // 
            this.cbokulturu.FormattingEnabled = true;
            this.cbokulturu.Items.AddRange(new object[] {
            "ATL",
            "TL",
            "AML",
            "EML"});
            this.cbokulturu.Location = new System.Drawing.Point(24, 45);
            this.cbokulturu.Name = "cbokulturu";
            this.cbokulturu.Size = new System.Drawing.Size(121, 21);
            this.cbokulturu.TabIndex = 2;
            // 
            // cbsınıf
            // 
            this.cbsınıf.FormattingEnabled = true;
            this.cbsınıf.Items.AddRange(new object[] {
            "10A",
            "11A",
            "12A"});
            this.cbsınıf.Location = new System.Drawing.Point(197, 43);
            this.cbsınıf.Name = "cbsınıf";
            this.cbsınıf.Size = new System.Drawing.Size(121, 21);
            this.cbsınıf.TabIndex = 2;
            this.cbsınıf.SelectedIndexChanged += new System.EventHandler(this.cbsınıf_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 246);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnbelge
            // 
            this.btnbelge.Location = new System.Drawing.Point(429, 38);
            this.btnbelge.Name = "btnbelge";
            this.btnbelge.Size = new System.Drawing.Size(89, 28);
            this.btnbelge.TabIndex = 4;
            this.btnbelge.Text = "Öğrenci belgesi";
            this.btnbelge.UseVisualStyleBackColor = true;
            this.btnbelge.Click += new System.EventHandler(this.btnbelge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.btnbelge);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbsınıf);
            this.Controls.Add(this.cbokulturu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnraporal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnraporal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbokulturu;
        private System.Windows.Forms.ComboBox cbsınıf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbelge;
    }
}

