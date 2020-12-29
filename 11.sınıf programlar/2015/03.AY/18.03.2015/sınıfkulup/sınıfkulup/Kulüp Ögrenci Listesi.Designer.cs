namespace sınıfkulup
{
    partial class Kulüp_Ögrenci_Listesi
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
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.cbmkulupler = new System.Windows.Forms.ComboBox();
            this.lsbx1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv2.GridColor = System.Drawing.Color.Tan;
            this.dgv2.Location = new System.Drawing.Point(12, 57);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(551, 240);
            this.dgv2.TabIndex = 7;
            // 
            // cbmkulupler
            // 
            this.cbmkulupler.FormattingEnabled = true;
            this.cbmkulupler.Location = new System.Drawing.Point(12, 12);
            this.cbmkulupler.Name = "cbmkulupler";
            this.cbmkulupler.Size = new System.Drawing.Size(171, 21);
            this.cbmkulupler.TabIndex = 6;
            this.cbmkulupler.SelectedIndexChanged += new System.EventHandler(this.cbmkulupler_SelectedIndexChanged);
            // 
            // lsbx1
            // 
            this.lsbx1.FormattingEnabled = true;
            this.lsbx1.Location = new System.Drawing.Point(569, 57);
            this.lsbx1.Name = "lsbx1";
            this.lsbx1.Size = new System.Drawing.Size(139, 238);
            this.lsbx1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ögrencisiz Kulüpler";
            // 
            // Kulüp_Ögrenci_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbx1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.cbmkulupler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kulüp_Ögrenci_Listesi";
            this.Text = "Kulüp_Ögrenci_Listesi";
            this.Load += new System.EventHandler(this.Kulüp_Ögrenci_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.ComboBox cbmkulupler;
        private System.Windows.Forms.ListBox lsbx1;
        private System.Windows.Forms.Label label1;
    }
}