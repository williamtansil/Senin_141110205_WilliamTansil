using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace scrollbar
{
    public partial class Form_1_1 : Form
    {
        bool mousedown;
        int mouseX, mouseY;

        public Form_1_1()
        {
            mousedown = false;
            mouseX = 0;
            mouseY = 0;
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void scrollbar1(object sender, ScrollEventArgs e)
        {
            if (vscrollbar1.Value < vscrollbar2.Value)
            {
                min.Text = vscrollbar1.Value.ToString();
                max.Text = vscrollbar2.Value.ToString();
            }
            else 
            {
                min.Text = vscrollbar2.Value.ToString();
                max.Text = vscrollbar1.Value.ToString();
            }

            DateTime _temp = new DateTime();
            _temp = new DateTime(DateTime.Today.Year + Math.Abs(vscrollbar1.Value - vscrollbar2.Value), DateTime.Today.Month, DateTime.Today.Day);
            calender.MinDate = DateTime.Today.Date;
            calender.MaxDate = _temp;

            test.Text = Convert.ToString(DateTime.Today.Year + Math.Abs(vscrollbar1.Value - vscrollbar2.Value));
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown) 
            {
                mouseX = MousePosition.X - 140;
                mouseY = MousePosition.Y - 12;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            for (int _i = 240; _i > 50; _i-=10)
            {
                menuStrip1.BackColor = Color.FromArgb(_i, _i, _i);
                Thread.Sleep(2);
                menuStrip1.Refresh();
            }
            menuStrip1.ForeColor = Color.Snow;
            
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            for (int _i = 50; _i < 240; _i+=10)
            {
                menuStrip1.BackColor = Color.FromArgb(_i, _i, _i);
                Thread.Sleep(1);
                menuStrip1.Refresh();
            }
            menuStrip1.ForeColor = Color.Black;
        } 
    }
}
