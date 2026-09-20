namespace Bai_14
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn khong được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {

                string strDuLieu = txtTen.Text;
                lopA.Items.Add(strDuLieu);

                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LopA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LopB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lopB_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                    i++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko ? ", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lopA, lopB);
            }
            else
                MessageBox.Show("Danh sach hien đang rong!", "Chú ý");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn khong ? ", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lopA, lopB);
            }
            else
                MessageBox.Show("Danh sach hien đang rong!", "Chú ý");
        }
        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toan bộ dữ liệu đang chọn khong ? ", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lopA, lopB);
            }
            else
                MessageBox.Show("Danh sach hiện đang rỗng!", "Chú ý");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toan bộ dữ liệu đang chọn khong ? ", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lopA, lopB);
            }
            else
                MessageBox.Show("Danh sach hiện đang rỗng!", "Chú ý");
        }
        void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
                if (lst.GetSelected(i))
                    lst.Items.RemoveAt(i);
                else
                    i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;
            if (lopA.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử nay?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    xoaDuLieu(lopA);
            }
            else
                MessageBox.Show("Hiện danh sach đang rỗng!", "Chú ý");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;
            if (lopB.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử nay?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    xoaDuLieu(lopB);
            }
            else
                MessageBox.Show("Hiện danh sach đang rỗng!", "Chú ý");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Thông báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
