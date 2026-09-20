namespace cau15
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            monthCalendar1 = new MonthCalendar();
            dtpLaunchDate = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            radLongDate = new RadioButton();
            radShortDate = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(36, 67);
            monthCalendar1.MaxSelectionCount = 14;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // dtpLaunchDate
            // 
            dtpLaunchDate.Location = new Point(57, 338);
            dtpLaunchDate.Name = "dtpLaunchDate";
            dtpLaunchDate.Size = new Size(250, 27);
            dtpLaunchDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(376, 67);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(72, 20);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "StartDate";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(378, 169);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(70, 20);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 315);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 6;
            label2.Text = "Product Launch Date";
            // 
            // radLongDate
            // 
            radLongDate.AutoSize = true;
            radLongDate.Checked = true;
            radLongDate.Location = new Point(105, 397);
            radLongDate.Name = "radLongDate";
            radLongDate.Size = new Size(99, 24);
            radLongDate.TabIndex = 7;
            radLongDate.Text = "Long Date";
            radLongDate.UseVisualStyleBackColor = false;
            radLongDate.CheckedChanged += radLongDate_CheckedChanged;
            // 
            // radShortDate
            // 
            radShortDate.AutoSize = true;
            radShortDate.Location = new Point(319, 397);
            radShortDate.Name = "radShortDate";
            radShortDate.Size = new Size(101, 24);
            radShortDate.TabIndex = 8;
            radShortDate.Text = "Short Date";
            radShortDate.UseVisualStyleBackColor = false;
            radShortDate.CheckedChanged += radShortDate_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 9;
            label1.Text = "Select the days you will trave";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(radShortDate);
            Controls.Add(radLongDate);
            Controls.Add(label2);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpLaunchDate);
            Controls.Add(monthCalendar1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private DateTimePicker dtpLaunchDate;
        private Label lblStartDate;
        private Label lblEndDate;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private RadioButton radLongDate;
        private RadioButton radShortDate;
        private Label label1;
    }
}