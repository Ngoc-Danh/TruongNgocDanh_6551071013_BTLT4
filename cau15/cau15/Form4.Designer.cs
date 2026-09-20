namespace cau15
{
    partial class Form4
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            txtCaption = new TextBox();
            txtMessage = new TextBox();
            tabPage2 = new TabPage();
            radRetryCancel = new RadioButton();
            radOKCancel = new RadioButton();
            radYesNoCancel = new RadioButton();
            radYesNo = new RadioButton();
            radOK = new RadioButton();
            tabPage3 = new TabPage();
            radWarning = new RadioButton();
            radQuestion = new RadioButton();
            radNone = new RadioButton();
            radInfo = new RadioButton();
            radError = new RadioButton();
            btnShow = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radBottom = new RadioButton();
            radTop = new RadioButton();
            radRight = new RadioButton();
            radLeft = new RadioButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(184, 69);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(359, 294);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtCaption);
            tabPage1.Controls.Add(txtMessage);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(351, 261);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Message";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 107);
            label2.Name = "label2";
            label2.Size = new Size(221, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter a Caption for MessageBox";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 29);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter the message to dislay";
            // 
            // txtCaption
            // 
            txtCaption.Location = new Point(45, 130);
            txtCaption.Name = "txtCaption";
            txtCaption.Size = new Size(201, 27);
            txtCaption.TabIndex = 1;
            txtCaption.Text = "TabControl Demo";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(45, 52);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(201, 27);
            txtMessage.TabIndex = 0;
            txtMessage.Text = "Sample Message";
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(radRetryCancel);
            tabPage2.Controls.Add(radOKCancel);
            tabPage2.Controls.Add(radYesNoCancel);
            tabPage2.Controls.Add(radYesNo);
            tabPage2.Controls.Add(radOK);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(351, 261);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Buttons";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // radRetryCancel
            // 
            radRetryCancel.AutoSize = true;
            radRetryCancel.Location = new Point(58, 115);
            radRetryCancel.Name = "radRetryCancel";
            radRetryCancel.Size = new Size(141, 24);
            radRetryCancel.TabIndex = 6;
            radRetryCancel.TabStop = true;
            radRetryCancel.Text = "Retry and Cancel";
            radRetryCancel.UseVisualStyleBackColor = true;
            // 
            // radOKCancel
            // 
            radOKCancel.AutoSize = true;
            radOKCancel.Location = new Point(60, 84);
            radOKCancel.Name = "radOKCancel";
            radOKCancel.Size = new Size(127, 24);
            radOKCancel.TabIndex = 5;
            radOKCancel.TabStop = true;
            radOKCancel.Text = "OK and Cancel";
            radOKCancel.UseVisualStyleBackColor = true;
            radOKCancel.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // radYesNoCancel
            // 
            radYesNoCancel.AutoSize = true;
            radYesNoCancel.Location = new Point(60, 174);
            radYesNoCancel.Name = "radYesNoCancel";
            radYesNoCancel.Size = new Size(155, 24);
            radYesNoCancel.TabIndex = 4;
            radYesNoCancel.Text = "Yes, No and Cancel";
            radYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // radYesNo
            // 
            radYesNo.AutoSize = true;
            radYesNo.Location = new Point(60, 144);
            radYesNo.Name = "radYesNo";
            radYesNo.Size = new Size(104, 24);
            radYesNo.TabIndex = 3;
            radYesNo.Text = "Yes and No";
            radYesNo.UseVisualStyleBackColor = true;
            radYesNo.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radOK
            // 
            radOK.AutoSize = true;
            radOK.Checked = true;
            radOK.Location = new Point(60, 54);
            radOK.Name = "radOK";
            radOK.Size = new Size(50, 24);
            radOK.TabIndex = 0;
            radOK.TabStop = true;
            radOK.Text = "OK";
            radOK.UseVisualStyleBackColor = true;
            radOK.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(radWarning);
            tabPage3.Controls.Add(radQuestion);
            tabPage3.Controls.Add(radNone);
            tabPage3.Controls.Add(radInfo);
            tabPage3.Controls.Add(radError);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(351, 261);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Icon";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // radWarning
            // 
            radWarning.AutoSize = true;
            radWarning.Location = new Point(98, 178);
            radWarning.Name = "radWarning";
            radWarning.Size = new Size(85, 24);
            radWarning.TabIndex = 9;
            radWarning.Text = "Warning";
            radWarning.UseVisualStyleBackColor = true;
            // 
            // radQuestion
            // 
            radQuestion.AutoSize = true;
            radQuestion.Location = new Point(98, 148);
            radQuestion.Name = "radQuestion";
            radQuestion.Size = new Size(89, 24);
            radQuestion.TabIndex = 8;
            radQuestion.Text = "Question";
            radQuestion.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            radNone.AutoSize = true;
            radNone.Location = new Point(98, 118);
            radNone.Name = "radNone";
            radNone.Size = new Size(66, 24);
            radNone.TabIndex = 7;
            radNone.Text = "None";
            radNone.UseVisualStyleBackColor = true;
            radNone.CheckedChanged += radioButton3_CheckedChanged_1;
            // 
            // radInfo
            // 
            radInfo.AutoSize = true;
            radInfo.Checked = true;
            radInfo.Location = new Point(98, 88);
            radInfo.Name = "radInfo";
            radInfo.Size = new Size(108, 24);
            radInfo.TabIndex = 6;
            radInfo.TabStop = true;
            radInfo.Text = "Information";
            radInfo.UseVisualStyleBackColor = true;
            // 
            // radError
            // 
            radError.AutoSize = true;
            radError.Location = new Point(98, 58);
            radError.Name = "radError";
            radError.Size = new Size(62, 24);
            radError.TabIndex = 5;
            radError.Text = "Error";
            radError.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(318, 389);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 30);
            label3.Name = "label3";
            label3.Size = new Size(272, 20);
            label3.TabIndex = 2;
            label3.Text = "Select options to create a message box:";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radBottom);
            groupBox1.Controls.Add(radTop);
            groupBox1.Controls.Add(radRight);
            groupBox1.Controls.Add(radLeft);
            groupBox1.Location = new Point(188, 458);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 165);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tab Layout";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radBottom
            // 
            radBottom.AutoSize = true;
            radBottom.Location = new Point(144, 94);
            radBottom.Name = "radBottom";
            radBottom.Size = new Size(80, 24);
            radBottom.TabIndex = 3;
            radBottom.Text = "Bottom";
            radBottom.UseVisualStyleBackColor = true;
            radBottom.CheckedChanged += radBottom_CheckedChanged;
            // 
            // radTop
            // 
            radTop.AutoSize = true;
            radTop.Checked = true;
            radTop.Location = new Point(21, 94);
            radTop.Name = "radTop";
            radTop.Size = new Size(55, 24);
            radTop.TabIndex = 2;
            radTop.TabStop = true;
            radTop.Text = "Top";
            radTop.UseVisualStyleBackColor = true;
            radTop.CheckedChanged += radTop_CheckedChanged;
            // 
            // radRight
            // 
            radRight.AutoSize = true;
            radRight.Location = new Point(144, 34);
            radRight.Name = "radRight";
            radRight.Size = new Size(65, 24);
            radRight.TabIndex = 1;
            radRight.Text = "Right";
            radRight.UseVisualStyleBackColor = true;
            radRight.CheckedChanged += radRight_CheckedChanged;
            // 
            // radLeft
            // 
            radLeft.AutoSize = true;
            radLeft.Location = new Point(21, 34);
            radLeft.Name = "radLeft";
            radLeft.Size = new Size(55, 24);
            radLeft.TabIndex = 0;
            radLeft.Text = "Left";
            radLeft.UseVisualStyleBackColor = true;
            radLeft.CheckedChanged += radLeft_CheckedChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 708);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(btnShow);
            Controls.Add(tabControl1);
            Name = "Form4";
            Text = "Form4";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtCaption;
        private TextBox txtMessage;
        private Label label1;
        private Label label2;
        private RadioButton radYesNoCancel;
        private RadioButton radYesNo;
        private RadioButton radOK;
        private RadioButton radWarning;
        private RadioButton radQuestion;
        private RadioButton radNone;
        private RadioButton radInfo;
        private RadioButton radError;
        private Button btnShow;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radBottom;
        private RadioButton radTop;
        private RadioButton radRight;
        private RadioButton radLeft;
        private RadioButton radOKCancel;
        private RadioButton radRetryCancel;
    }
}