using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cau15
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK; // Mặc định
            if (radOKCancel.Checked) btn = MessageBoxButtons.OKCancel;
            else if (radRetryCancel.Checked) btn = MessageBoxButtons.RetryCancel;
            else if (radYesNo.Checked) btn = MessageBoxButtons.YesNo;
            else if (radYesNoCancel.Checked) btn = MessageBoxButtons.YesNoCancel;

            // 2. Kiểm tra xem người dùng chọn loại Icon nào ở Tab 3
            MessageBoxIcon icon = MessageBoxIcon.Information; // Mặc định
            if (radError.Checked) icon = MessageBoxIcon.Error;
            else if (radQuestion.Checked) icon = MessageBoxIcon.Question;
            else if (radWarning.Checked) icon = MessageBoxIcon.Warning;
            else if (radNone.Checked) icon = MessageBoxIcon.None;

            // 3. Hiển thị hộp thoại với chữ lấy từ Tab 1, nút từ Tab 2, Icon từ Tab 3
            MessageBox.Show(txtMessage.Text, txtCaption.Text, btn, icon);
        }

        private void radTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radTop.Checked) tabControl1.Alignment = TabAlignment.Top;
        }

        private void radBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radBottom.Checked) tabControl1.Alignment = TabAlignment.Bottom;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radLeft.Checked) tabControl1.Alignment = TabAlignment.Left;
        }

        private void radRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radRight.Checked) tabControl1.Alignment = TabAlignment.Right;
        }
    }
}
