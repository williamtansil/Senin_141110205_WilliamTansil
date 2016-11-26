using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;

namespace Latihan_3_1
{
    public partial class Form_3_1 : Form
    {
        public Form_3_1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "S") MessageBox.Show(tstextbox.SelectedText.ToString());
        }

        private void Form_3_1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily _x in FontFamily.Families) tsfontstyle.Items.Add(_x.Name.ToString());
            //foreach (Color _x in new ColorConverter().GetStandardValues()) tsforecolor.Items.Add(_x.Name.ToString());
            for (var _i = 6; _i <= 72; _i++) tsfontsize.Items.Add((double)_i);
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList) this.cmbboxClr.Items.Add(c.Name);
        }

        private void tsfontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbboxClr_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void cmbboxClr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tsbold_Click(object sender, EventArgs e)
        {
            Label _temptext = new Label();

            for (int _i = tstextbox.SelectionStart; _i < tstextbox.SelectionStart + tstextbox.SelectionLength; _i++)
            {
                if (_i == tstextbox.SelectionStart)
                {
                    if (sender == tsbold)
                        tstextbox.SelectionFont = tstextbox.SelectionFont.Bold ?
                            new Font(tsfontstyle.Text, Convert.ToSingle(tsfontsize.Text), FontStyle.Regular | ) :
                            new Font(tsfontstyle.Text, Convert.ToSingle(tsfontsize.Text), FontStyle.Bold);
                }
                //tstextbox.Text.ToCharArray()[_i] = tstextbox.Text.ToCharArray()[_i];
            }
        }
    }
}
