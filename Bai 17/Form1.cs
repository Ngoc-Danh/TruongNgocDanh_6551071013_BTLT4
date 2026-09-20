namespace Bai_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Helper Methods

        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    var item = lst1.Items[i];
                    if (item != null)
                    {
                        lst2.Items.Add(item);
                        lst1.Items.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }
        }

        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                var item = lst1.Items[0];
                if (item != null)
                {
                    lst2.Items.Add(item);
                }
                lst1.Items.RemoveAt(0);
            }
        }

        void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        #endregion

        #region MenuStrip Events
        private void cậpNhậtLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show(
                    "Bạn không được phép nhập dữ liệu rỗng!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text.Trim();
                lopA.Items.Add(strDuLieu);
                txtTen.Clear();
                txtTen.Focus();
            }
        }
        private void cậpNhậtLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show(
                    "Bạn không được phép nhập dữ liệu rỗng!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text.Trim();
                lopB.Items.Add(strDuLieu);
                txtTen.Clear();
                txtTen.Focus();
            }
        }
        private void chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopA.Items.Count > 0)
            {
                if (lopA.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn phần tử cần chuyển!", "Chú ý");
                    return;
                }

                DialogResult hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lopA, lopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopB.Items.Count > 0)
            {
                if (lopB.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn phần tử cần chuyển!", "Chú ý");
                    return;
                }

                DialogResult hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lopB, lopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void chuyểnHếtDanhSáchSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopA.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển toàn bộ dữ liệu không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lopA, lopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void chuyểnHếtDanhSáchSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopB.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển toàn bộ dữ liệu không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lopB, lopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void xóaDanhSáchLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopA.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiXoa == DialogResult.Yes)
                {
                    if (lopA.SelectedIndices.Count > 0)
                    {
                        xoaDuLieu(lopA);
                    }
                    else
                    {
                        lopA.Items.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        
        private void xóaDanhSáchLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopB.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (hoiXoa == DialogResult.Yes)
                {
                    if (lopB.SelectedIndices.Count > 0)
                    {
                        xoaDuLieu(lopB);
                    }
                    else
                    {
                        lopB.Items.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Người thiết kế: Trương Ngọc Danh\n" +
                "MSSV: 6551071013\n" +
                "Lớp: CNTT K65",
                "Thông tin người thiết kế",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
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

        #endregion
    }
}