namespace butonyönoyunu
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
            this.rdbsol = new System.Windows.Forms.RadioButton();
            this.rdbsag = new System.Windows.Forms.RadioButton();
            this.rdbasagı = new System.Windows.Forms.RadioButton();
            this.rdbyukarı = new System.Windows.Forms.RadioButton();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.grb3 = new System.Windows.Forms.GroupBox();
            this.rdbyukarı1 = new System.Windows.Forms.RadioButton();
            this.rdbsol1 = new System.Windows.Forms.RadioButton();
            this.rdbsag1 = new System.Windows.Forms.RadioButton();
            this.rdbasagı1 = new System.Windows.Forms.RadioButton();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.grb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbsol
            // 
            this.rdbsol.AutoSize = true;
            this.rdbsol.Location = new System.Drawing.Point(8, 53);
            this.rdbsol.Name = "rdbsol";
            this.rdbsol.Size = new System.Drawing.Size(38, 17);
            this.rdbsol.TabIndex = 0;
            this.rdbsol.Text = "sol";
            this.rdbsol.UseVisualStyleBackColor = true;
            this.rdbsol.CheckedChanged += new System.EventHandler(this.rdbsol_CheckedChanged);
            // 
            // rdbsag
            // 
            this.rdbsag.AutoSize = true;
            this.rdbsag.Location = new System.Drawing.Point(161, 53);
            this.rdbsag.Name = "rdbsag";
            this.rdbsag.Size = new System.Drawing.Size(42, 17);
            this.rdbsag.TabIndex = 1;
            this.rdbsag.Text = "sağ";
            this.rdbsag.UseVisualStyleBackColor = true;
            this.rdbsag.CheckedChanged += new System.EventHandler(this.rdbsag_CheckedChanged);
            // 
            // rdbasagı
            // 
            this.rdbasagı.AutoSize = true;
            this.rdbasagı.Location = new System.Drawing.Point(81, 76);
            this.rdbasagı.Name = "rdbasagı";
            this.rdbasagı.Size = new System.Drawing.Size(50, 17);
            this.rdbasagı.TabIndex = 2;
            this.rdbasagı.Text = "asagı";
            this.rdbasagı.UseVisualStyleBackColor = true;
            this.rdbasagı.CheckedChanged += new System.EventHandler(this.rdbasagı_CheckedChanged);
            // 
            // rdbyukarı
            // 
            this.rdbyukarı.AutoSize = true;
            this.rdbyukarı.Location = new System.Drawing.Point(81, 30);
            this.rdbyukarı.Name = "rdbyukarı";
            this.rdbyukarı.Size = new System.Drawing.Size(53, 17);
            this.rdbyukarı.TabIndex = 3;
            this.rdbyukarı.Text = "yukarı";
            this.rdbyukarı.UseVisualStyleBackColor = true;
            this.rdbyukarı.CheckedChanged += new System.EventHandler(this.rdbyukarı_CheckedChanged);
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grb1.Controls.Add(this.btn1);
            this.grb1.Location = new System.Drawing.Point(25, 145);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(930, 579);
            this.grb1.TabIndex = 4;
            this.grb1.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Lime;
            this.btn1.Location = new System.Drawing.Point(303, 180);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 54);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.rdbyukarı);
            this.grb2.Controls.Add(this.rdbsol);
            this.grb2.Controls.Add(this.rdbsag);
            this.grb2.Controls.Add(this.rdbasagı);
            this.grb2.Location = new System.Drawing.Point(44, 22);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(212, 117);
            this.grb2.TabIndex = 5;
            this.grb2.TabStop = false;
            this.grb2.Enter += new System.EventHandler(this.grb2_Enter);
            // 
            // grb3
            // 
            this.grb3.Controls.Add(this.rdbyukarı1);
            this.grb3.Controls.Add(this.rdbsol1);
            this.grb3.Controls.Add(this.rdbsag1);
            this.grb3.Controls.Add(this.rdbasagı1);
            this.grb3.Location = new System.Drawing.Point(367, 22);
            this.grb3.Name = "grb3";
            this.grb3.Size = new System.Drawing.Size(212, 117);
            this.grb3.TabIndex = 6;
            this.grb3.TabStop = false;
            // 
            // rdbyukarı1
            // 
            this.rdbyukarı1.AutoSize = true;
            this.rdbyukarı1.Location = new System.Drawing.Point(81, 30);
            this.rdbyukarı1.Name = "rdbyukarı1";
            this.rdbyukarı1.Size = new System.Drawing.Size(53, 17);
            this.rdbyukarı1.TabIndex = 3;
            this.rdbyukarı1.Text = "yukarı";
            this.rdbyukarı1.UseVisualStyleBackColor = true;
            // 
            // rdbsol1
            // 
            this.rdbsol1.AutoSize = true;
            this.rdbsol1.Location = new System.Drawing.Point(8, 53);
            this.rdbsol1.Name = "rdbsol1";
            this.rdbsol1.Size = new System.Drawing.Size(38, 17);
            this.rdbsol1.TabIndex = 0;
            this.rdbsol1.Text = "sol";
            this.rdbsol1.UseVisualStyleBackColor = true;
            // 
            // rdbsag1
            // 
            this.rdbsag1.AutoSize = true;
            this.rdbsag1.Location = new System.Drawing.Point(161, 53);
            this.rdbsag1.Name = "rdbsag1";
            this.rdbsag1.Size = new System.Drawing.Size(42, 17);
            this.rdbsag1.TabIndex = 1;
            this.rdbsag1.Text = "sağ";
            this.rdbsag1.UseVisualStyleBackColor = true;
            // 
            // rdbasagı1
            // 
            this.rdbasagı1.AutoSize = true;
            this.rdbasagı1.Location = new System.Drawing.Point(81, 76);
            this.rdbasagı1.Name = "rdbasagı1";
            this.rdbasagı1.Size = new System.Drawing.Size(50, 17);
            this.rdbasagı1.TabIndex = 2;
            this.rdbasagı1.Text = "asagı";
            this.rdbasagı1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 735);
            this.Controls.Add(this.grb3);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb1.ResumeLayout(false);
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.grb3.ResumeLayout(false);
            this.grb3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbsol;
        private System.Windows.Forms.RadioButton rdbsag;
        private System.Windows.Forms.RadioButton rdbasagı;
        private System.Windows.Forms.RadioButton rdbyukarı;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.GroupBox grb3;
        private System.Windows.Forms.RadioButton rdbyukarı1;
        private System.Windows.Forms.RadioButton rdbsol1;
        private System.Windows.Forms.RadioButton rdbsag1;
        private System.Windows.Forms.RadioButton rdbasagı1;
    }
}

