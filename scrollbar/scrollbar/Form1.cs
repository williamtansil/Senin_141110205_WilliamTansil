using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrollbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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
    }
}
