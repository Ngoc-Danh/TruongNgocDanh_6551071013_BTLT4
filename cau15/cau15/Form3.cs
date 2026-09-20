using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cau15
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1; // Mỗi lần nhích lên 1 xíu
            }
            else
            {
                progressBar1.Value = 0; // Nếu đầy 100% rồi thì quay lại vạch xuất phát
            }

            // Cập nhật dòng chữ hiển thị phần trăm
            lblPhanTram.Text = "Percentage Complete: " + progressBar1.Value.ToString() + "%";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / trackBar1.Value;
        }
    }
}
