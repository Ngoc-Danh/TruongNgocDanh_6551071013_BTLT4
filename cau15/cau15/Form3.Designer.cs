namespace cau15
{
    partial class Form3
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
            progressBar1 = new ProgressBar();
            trackBar1 = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblPhanTram = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(165, 107);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(217, 29);
            progressBar1.TabIndex = 0;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(152, 290);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(230, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 5;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblPhanTram
            // 
            lblPhanTram.AutoSize = true;
            lblPhanTram.Location = new Point(165, 156);
            lblPhanTram.Name = "lblPhanTram";
            lblPhanTram.Size = new Size(186, 20);
            lblPhanTram.TabIndex = 2;
            lblPhanTram.Text = "Percentage Complete: 45%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 52);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 3;
            label1.Text = "Progress Indicator";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 247);
            label2.Name = "label2";
            label2.Size = new Size(315, 20);
            label2.TabIndex = 4;
            label2.Text = "Slide the TrackBar to control processing speed";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPhanTram);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private Label lblPhanTram;
        private Label label1;
        private Label label2;
    }
}