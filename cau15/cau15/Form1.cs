namespace cau15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            // Đổi màu chữ của Label theo tên màu được chọn
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void nudSize_ValueChanged_1(object sender, EventArgs e)
        {
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }
    }
}

