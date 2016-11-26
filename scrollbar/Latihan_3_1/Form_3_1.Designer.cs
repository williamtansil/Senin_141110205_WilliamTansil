namespace Latihan_3_1
{
    partial class Form_3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_3_1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tstextbox = new System.Windows.Forms.RichTextBox();
            this.cmbboxClr = new System.Windows.Forms.ComboBox();
            this.tsbold = new System.Windows.Forms.ToolStripButton();
            this.tsitalic = new System.Windows.Forms.ToolStripButton();
            this.tsunderline = new System.Windows.Forms.ToolStripButton();
            this.tsfontsize = new System.Windows.Forms.ToolStripComboBox();
            this.tsfontstyle = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(516, 54);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 412);
            this.vScrollBar1.TabIndex = 8;
            // 
            // tstextbox
            // 
            this.tstextbox.Location = new System.Drawing.Point(-1, 52);
            this.tstextbox.Name = "tstextbox";
            this.tstextbox.Size = new System.Drawing.Size(516, 414);
            this.tstextbox.TabIndex = 11;
            this.tstextbox.Text = "";
            // 
            // cmbboxClr
            // 
            this.cmbboxClr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbboxClr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxClr.DropDownWidth = 200;
            this.cmbboxClr.FormattingEnabled = true;
            this.cmbboxClr.ItemHeight = 20;
            this.cmbboxClr.Location = new System.Drawing.Point(288, 24);
            this.cmbboxClr.Name = "cmbboxClr";
            this.cmbboxClr.Size = new System.Drawing.Size(110, 26);
            this.cmbboxClr.TabIndex = 14;
            this.cmbboxClr.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbboxClr_DrawItem);
            // 
            // tsbold
            // 
            this.tsbold.BackColor = System.Drawing.SystemColors.Control;
            this.tsbold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbold.Name = "tsbold";
            this.tsbold.Size = new System.Drawing.Size(23, 22);
            this.tsbold.Text = "B";
            this.tsbold.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbold.ToolTipText = "bold";
            this.tsbold.Click += new System.EventHandler(this.tsbold_Click);
            // 
            // tsitalic
            // 
            this.tsitalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.tsitalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsitalic.Name = "tsitalic";
            this.tsitalic.Size = new System.Drawing.Size(23, 22);
            this.tsitalic.Text = "I";
            this.tsitalic.ToolTipText = "Italic";
            // 
            // tsunderline
            // 
            this.tsunderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.tsunderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsunderline.Name = "tsunderline";
            this.tsunderline.Size = new System.Drawing.Size(23, 22);
            this.tsunderline.Text = "U";
            this.tsunderline.ToolTipText = "Underline";
            // 
            // tsfontsize
            // 
            this.tsfontsize.DropDownHeight = 250;
            this.tsfontsize.IntegralHeight = false;
            this.tsfontsize.MaxDropDownItems = 5;
            this.tsfontsize.Name = "tsfontsize";
            this.tsfontsize.Size = new System.Drawing.Size(75, 25);
            this.tsfontsize.Text = "8";
            this.tsfontsize.SelectedIndexChanged += new System.EventHandler(this.tsfontsize_SelectedIndexChanged);
            // 
            // tsfontstyle
            // 
            this.tsfontstyle.DropDownHeight = 250;
            this.tsfontstyle.IntegralHeight = false;
            this.tsfontstyle.MaxDropDownItems = 5;
            this.tsfontstyle.Name = "tsfontstyle";
            this.tsfontstyle.Size = new System.Drawing.Size(121, 25);
            this.tsfontstyle.Text = "Microsoft Sans Serif";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbold,
            this.tsitalic,
            this.tsunderline,
            this.tsfontsize,
            this.tsfontstyle,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(535, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form_3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 465);
            this.Controls.Add(this.tstextbox);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.cmbboxClr);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_3_1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_3_1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.RichTextBox tstextbox;
        private System.Windows.Forms.ComboBox cmbboxClr;
        private System.Windows.Forms.ToolStripButton tsbold;
        private System.Windows.Forms.ToolStripButton tsitalic;
        private System.Windows.Forms.ToolStripButton tsunderline;
        private System.Windows.Forms.ToolStripComboBox tsfontsize;
        private System.Windows.Forms.ToolStripComboBox tsfontstyle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

