using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cau15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStartDate.Text = "Start Date:\n" + monthCalendar1.SelectionStart.ToShortDateString();
            lblEndDate.Text = "End Date:\n" + monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radLongDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radLongDate.Checked == true)
            {
                // Chuyển ô ngày tháng sang kiểu dài (Ví dụ: Saturday, June 08, 2002)
                dtpLaunchDate.Format = DateTimePickerFormat.Long;
            }
        }

        private void radShortDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radShortDate.Checked == true)
            {
                // Chuyển ô ngày tháng sang kiểu ngắn (Ví dụ: 6/8/2002)
                dtpLaunchDate.Format = DateTimePickerFormat.Short;
            }
        }
    }
}
