namespace Bai_17
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpAToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpBToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            xóaDanhSáchLớpAToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpBToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            kếtThúcToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtTen = new TextBox();
            labelLopA = new Label();
            lopA = new ListBox();
            labelLopB = new Label();
            lopB = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                cậpNhậtToolStripMenuItem,
                hệThốngToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                cậpNhậtLớpAToolStripMenuItem,
                cậpNhậtLớpBToolStripMenuItem,
                toolStripSeparator1,
                chuyểnPhầnTửChọnSangLớpBToolStripMenuItem,
                chuyểnPhầnTửChọnSangLớpAToolStripMenuItem,
                chuyểnHếtDanhSáchSangLớpBToolStripMenuItem,
                chuyểnHếtDanhSáchSangLớpAToolStripMenuItem,
                toolStripSeparator2,
                xóaDanhSáchLớpAToolStripMenuItem,
                xóaDanhSáchLớpBToolStripMenuItem
            });
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(82, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // cậpNhậtLớpAToolStripMenuItem
            // 
            cậpNhậtLớpAToolStripMenuItem.Name = "cậpNhậtLớpAToolStripMenuItem";
            cậpNhậtLớpAToolStripMenuItem.Size = new Size(310, 26);
            cậpNhậtLớpAToolStripMenuItem.Text = "Cập nhật lớp A";
            cậpNhậtLớpAToolStripMenuItem.Click += cậpNhậtLớpAToolStripMenuItem_Click;
            // 
            // cậpNhậtLớpBToolStripMenuItem
            // 
            cậpNhậtLớpBToolStripMenuItem.Name = "cậpNhậtLớpBToolStripMenuItem";
            cậpNhậtLớpBToolStripMenuItem.Size = new Size(310, 26);
            cậpNhậtLớpBToolStripMenuItem.Text = "Cập nhật lớp B";
            cậpNhậtLớpBToolStripMenuItem.Click += cậpNhậtLớpBToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(307, 6);
            // 
            // chuyểnPhầnTửChọnSangLớpBToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpBToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Size = new Size(310, 26);
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp B";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click;
            // 
            // chuyểnPhầnTửChọnSangLớpAToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpAToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Size = new Size(310, 26);
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp A";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click;
            // 
            // chuyểnHếtDanhSáchSangLớpBToolStripMenuItem
            // 
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Name = "chuyểnHếtDanhSáchSangLớpBToolStripMenuItem";
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Size = new Size(310, 26);
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Text = "Chuyển hết danh sách sang lớp B";
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Click += chuyểnHếtDanhSáchSangLớpBToolStripMenuItem_Click;
            // 
            // chuyểnHếtDanhSáchSangLớpAToolStripMenuItem
            // 
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem.Name = "chuyểnHếtDanhSáchSangLớpAToolStripMenuItem";
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem.Size = new Size(310, 26);
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem.Text = "Chuyển hết danh sách sang lớp A";
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem.Click += chuyểnHếtDanhSáchSangLớpAToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(307, 6);
            // 
            // xóaDanhSáchLớpAToolStripMenuItem
            // 
            xóaDanhSáchLớpAToolStripMenuItem.Name = "xóaDanhSáchLớpAToolStripMenuItem";
            xóaDanhSáchLớpAToolStripMenuItem.Size = new Size(310, 26);
            xóaDanhSáchLớpAToolStripMenuItem.Text = "Xóa danh sách lớp A";
            xóaDanhSáchLớpAToolStripMenuItem.Click += xóaDanhSáchLớpAToolStripMenuItem_Click;
            // 
            // xóaDanhSáchLớpBToolStripMenuItem
            // 
            xóaDanhSáchLớpBToolStripMenuItem.Name = "xóaDanhSáchLớpBToolStripMenuItem";
            xóaDanhSáchLớpBToolStripMenuItem.Size = new Size(310, 26);
            xóaDanhSáchLớpBToolStripMenuItem.Text = "Xóa danh sách lớp B";
            xóaDanhSáchLớpBToolStripMenuItem.Click += xóaDanhSáchLớpBToolStripMenuItem_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                thôngTinToolStripMenuItem,
                kếtThúcToolStripMenuItem
            });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(224, 26);
            thôngTinToolStripMenuItem.Text = "Thông tin ";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click;
            // 
            // kếtThúcToolStripMenuItem
            // 
            kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            kếtThúcToolStripMenuItem.Size = new Size(224, 26);
            kếtThúcToolStripMenuItem.Text = "Kết thúc";
            kếtThúcToolStripMenuItem.Click += kếtThúcToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(80, 52);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên SV";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(160, 49);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(560, 27);
            txtTen.TabIndex = 2;
            // 
            // labelLopA
            // 
            labelLopA.AutoSize = true;
            labelLopA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelLopA.Location = new Point(80, 105);
            labelLopA.Name = "labelLopA";
            labelLopA.Size = new Size(52, 20);
            labelLopA.TabIndex = 3;
            labelLopA.Text = "Lớp A";
            // 
            // lopA
            // 
            lopA.FormattingEnabled = true;
            lopA.Location = new Point(80, 130);
            lopA.Name = "lopA";
            lopA.SelectionMode = SelectionMode.MultiExtended;
            lopA.Size = new Size(300, 244);
            lopA.TabIndex = 4;
            // 
            // labelLopB
            // 
            labelLopB.AutoSize = true;
            labelLopB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelLopB.Location = new Point(420, 105);
            labelLopB.Name = "labelLopB";
            labelLopB.Size = new Size(51, 20);
            labelLopB.TabIndex = 5;
            labelLopB.Text = "Lớp B";
            // 
            // lopB
            // 
            lopB.FormattingEnabled = true;
            lopB.Location = new Point(420, 130);
            lopB.Name = "lopB";
            lopB.SelectionMode = SelectionMode.MultiExtended;
            lopB.Size = new Size(300, 244);
            lopB.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(labelLopA);
            Controls.Add(lopA);
            Controls.Add(labelLopB);
            Controls.Add(lopB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 17 - Quản lý sinh viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpAToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpBToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDanhSáchSangLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDanhSáchSangLớpAToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem xóaDanhSáchLớpAToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpBToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem kếtThúcToolStripMenuItem;
        private Label label1;
        private TextBox txtTen;
        private Label labelLopA;
        private ListBox lopA;
        private Label labelLopB;
        private ListBox lopB;
    }
}
