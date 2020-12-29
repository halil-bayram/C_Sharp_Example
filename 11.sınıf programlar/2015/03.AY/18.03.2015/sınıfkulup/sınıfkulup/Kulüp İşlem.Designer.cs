namespace sınıfkulup
{
    partial class Kulübeögrenciata
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnkuluple = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cbmsınıf = new System.Windows.Forms.ComboBox();
            this.cbmokulturu = new System.Windows.Forms.ComboBox();
            this.btnomayan = new System.Windows.Forms.Button();
            this.btnkulüpsıfırla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkuluple
            // 
            this.btnkuluple.Location = new System.Drawing.Point(12, 37);
            this.btnkuluple.Name = "btnkuluple";
            this.btnkuluple.Size = new System.Drawing.Size(551, 21);
            this.btnkuluple.TabIndex = 7;
            this.btnkuluple.Text = "Kulüpleri Göster";
            this.btnkuluple.UseVisualStyleBackColor = true;
            this.btnkuluple.Click += new System.EventHandler(this.btnkuluple_Click);
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.GridColor = System.Drawing.Color.Tan;
            this.dgv1.Location = new System.Drawing.Point(12, 64);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(551, 219);
            this.dgv1.TabIndex = 6;
            // 
            // cbmsınıf
            // 
            this.cbmsınıf.FormattingEnabled = true;
            this.cbmsınıf.Location = new System.Drawing.Point(161, 10);
            this.cbmsınıf.Name = "cbmsınıf";
            this.cbmsınıf.Size = new System.Drawing.Size(143, 21);
            this.cbmsınıf.TabIndex = 5;
            this.cbmsınıf.SelectedIndexChanged += new System.EventHandler(this.cbmsınıf_SelectedIndexChanged);
            // 
            // cbmokulturu
            // 
            this.cbmokulturu.FormattingEnabled = true;
            this.cbmokulturu.Location = new System.Drawing.Point(12, 10);
            this.cbmokulturu.Name = "cbmokulturu";
            this.cbmokulturu.Size = new System.Drawing.Size(143, 21);
            this.cbmokulturu.TabIndex = 4;
            this.cbmokulturu.SelectedIndexChanged += new System.EventHandler(this.cbmokulturu_SelectedIndexChanged);
            // 
            // btnomayan
            // 
            this.btnomayan.Location = new System.Drawing.Point(325, 8);
            this.btnomayan.Name = "btnomayan";
            this.btnomayan.Size = new System.Drawing.Size(116, 23);
            this.btnomayan.TabIndex = 8;
            this.btnomayan.Text = "Kulüpsüzler";
            this.btnomayan.UseVisualStyleBackColor = true;
            this.btnomayan.Click += new System.EventHandler(this.btnomayan_Click);
            // 
            // btnkulüpsıfırla
            // 
            this.btnkulüpsıfırla.Location = new System.Drawing.Point(447, 8);
            this.btnkulüpsıfırla.Name = "btnkulüpsıfırla";
            this.btnkulüpsıfırla.Size = new System.Drawing.Size(116, 23);
            this.btnkulüpsıfırla.TabIndex = 9;
            this.btnkulüpsıfırla.Text = "Kulüpleri Sıfırla";
            this.btnkulüpsıfırla.UseVisualStyleBackColor = true;
            this.btnkulüpsıfırla.Click += new System.EventHandler(this.btnkulüpsıfırla_Click);
            // 
            // Kulübeögrenciata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 295);
            this.Controls.Add(this.btnkulüpsıfırla);
            this.Controls.Add(this.btnomayan);
            this.Controls.Add(this.btnkuluple);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cbmsınıf);
            this.Controls.Add(this.cbmokulturu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kulübeögrenciata";
            this.Text = "Kulübe Ögrenci Ata";
            this.Load += new System.EventHandler(this.Kulübeögrenciata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkuluple;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox cbmsınıf;
        private System.Windows.Forms.ComboBox cbmokulturu;
        private System.Windows.Forms.Button btnomayan;
        private System.Windows.Forms.Button btnkulüpsıfırla;
    }
}