namespace volleyball_problem
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(12, 30);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(53, 20);
            this.Txt1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // BtnHitung
            // 
            this.BtnHitung.Location = new System.Drawing.Point(89, 24);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(92, 26);
            this.BtnHitung.TabIndex = 2;
            this.BtnHitung.Text = "Hitung";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(12, 77);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(53, 20);
            this.Txt2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // TxtHasil
            // 
            this.TxtHasil.Enabled = false;
            this.TxtHasil.Location = new System.Drawing.Point(89, 79);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.Size = new System.Drawing.Size(92, 20);
            this.TxtHasil.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 111);
            this.Controls.Add(this.BtnHitung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Volley";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHitung;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHasil;
        private System.Windows.Forms.Label label3;
    }
}

