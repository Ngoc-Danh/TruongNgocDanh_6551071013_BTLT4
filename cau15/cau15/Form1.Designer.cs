namespace cau15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dudColor = new DomainUpDown();
            nudSize = new NumericUpDown();
            lblSampleText = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 113);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Color";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 218);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // dudColor
            // 
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Black");
            dudColor.Items.Add("Yellow");
            dudColor.Location = new Point(294, 105);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(150, 27);
            dudColor.TabIndex = 2;
            dudColor.Text = "Blue";
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // nudSize
            // 
            nudSize.Location = new Point(294, 218);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(150, 27);
            nudSize.TabIndex = 3;
            nudSize.ValueChanged += nudSize_ValueChanged_1;
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblSampleText.ForeColor = SystemColors.MenuHighlight;
            lblSampleText.Location = new Point(277, 306);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(137, 31);
            lblSampleText.TabIndex = 5;
            lblSampleText.Text = "Sample Text";
            lblSampleText.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 407);
            Controls.Add(lblSampleText);
            Controls.Add(nudSize);
            Controls.Add(dudColor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DomainUpDown dudColor;
        private NumericUpDown nudSize;
        private Label lblSampleText;
    }
}
