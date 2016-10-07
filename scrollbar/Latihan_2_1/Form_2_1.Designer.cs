namespace Latihan_2_1
{
    partial class Form_2_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.month = new System.Windows.Forms.DomainUpDown();
            this.addbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.day = new System.Windows.Forms.DomainUpDown();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // menusToolStripMenuItem
            // 
            this.menusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menusToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // calender
            // 
            this.calender.BackColor = System.Drawing.SystemColors.Info;
            this.calender.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calender.Location = new System.Drawing.Point(18, 71);
            this.calender.Name = "calender";
            this.calender.TabIndex = 3;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(89, 39);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(74, 20);
            this.month.TabIndex = 4;
            this.month.Text = "Month";
            this.month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(169, 36);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(52, 23);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(227, 36);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(52, 23);
            this.delbutton.TabIndex = 6;
            this.delbutton.Text = "Del";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(25, 39);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(58, 20);
            this.day.TabIndex = 5;
            this.day.Text = "Day";
            this.day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_2_1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_2_1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.DomainUpDown month;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.DomainUpDown day;
    }
}

