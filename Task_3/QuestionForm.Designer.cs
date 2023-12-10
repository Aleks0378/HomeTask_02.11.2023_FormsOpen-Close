namespace Task_3
{
    partial class QuestionForm
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            radioBtnAnswer1 = new RadioButton();
            lblQuestion = new Label();
            radioBtnAnswer3 = new RadioButton();
            radioBtnAnswer2 = new RadioButton();
            radioBtnAnswer4 = new RadioButton();
            groupBox1 = new GroupBox();
            lblTimer = new Label();
            lblAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources._1429132238_1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(572, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 259);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 8;
            button1.Text = "50/50";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(173, 259);
            button2.Name = "button2";
            button2.Size = new Size(80, 36);
            button2.TabIndex = 9;
            button2.Text = "Замена";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.BackColor = Color.Cyan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.Control;
            button3.Image = Properties.Resources.icons8_телефон_361;
            button3.Location = new Point(330, 259);
            button3.Name = "button3";
            button3.Size = new Size(83, 36);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoEllipsis = true;
            button4.BackColor = Color.Goldenrod;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(477, 259);
            button4.Name = "button4";
            button4.Size = new Size(83, 36);
            button4.TabIndex = 11;
            button4.TabStop = false;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = false;
            // 
            // radioBtnAnswer1
            // 
            radioBtnAnswer1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioBtnAnswer1.AutoSize = true;
            radioBtnAnswer1.Location = new Point(31, 129);
            radioBtnAnswer1.Name = "radioBtnAnswer1";
            radioBtnAnswer1.Size = new Size(17, 16);
            radioBtnAnswer1.TabIndex = 13;
            radioBtnAnswer1.TabStop = true;
            radioBtnAnswer1.UseVisualStyleBackColor = true;
            radioBtnAnswer1.CheckedChanged += radioBtnAnswer1_CheckedChanged;
            // 
            // lblQuestion
            // 
            lblQuestion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(72, 58);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 20);
            lblQuestion.TabIndex = 12;
            // 
            // radioBtnAnswer3
            // 
            radioBtnAnswer3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioBtnAnswer3.AutoSize = true;
            radioBtnAnswer3.Location = new Point(323, 129);
            radioBtnAnswer3.Name = "radioBtnAnswer3";
            radioBtnAnswer3.Size = new Size(17, 16);
            radioBtnAnswer3.TabIndex = 16;
            radioBtnAnswer3.TabStop = true;
            radioBtnAnswer3.UseVisualStyleBackColor = true;
            radioBtnAnswer3.CheckedChanged += radioBtnAnswer3_CheckedChanged;
            // 
            // radioBtnAnswer2
            // 
            radioBtnAnswer2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioBtnAnswer2.AutoSize = true;
            radioBtnAnswer2.Location = new Point(31, 191);
            radioBtnAnswer2.Name = "radioBtnAnswer2";
            radioBtnAnswer2.Size = new Size(17, 16);
            radioBtnAnswer2.TabIndex = 14;
            radioBtnAnswer2.TabStop = true;
            radioBtnAnswer2.UseVisualStyleBackColor = true;
            radioBtnAnswer2.CheckedChanged += radioBtnAnswer2_CheckedChanged;
            // 
            // radioBtnAnswer4
            // 
            radioBtnAnswer4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioBtnAnswer4.AutoSize = true;
            radioBtnAnswer4.Location = new Point(323, 191);
            radioBtnAnswer4.Name = "radioBtnAnswer4";
            radioBtnAnswer4.Size = new Size(17, 16);
            radioBtnAnswer4.TabIndex = 15;
            radioBtnAnswer4.TabStop = true;
            radioBtnAnswer4.UseVisualStyleBackColor = true;
            radioBtnAnswer4.CheckedChanged += radioBtnAnswer4_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtnAnswer1);
            groupBox1.Controls.Add(radioBtnAnswer4);
            groupBox1.Controls.Add(lblQuestion);
            groupBox1.Controls.Add(radioBtnAnswer2);
            groupBox1.Controls.Add(radioBtnAnswer3);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 261);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(31, 331);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 20);
            lblTimer.TabIndex = 21;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(272, 331);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(0, 20);
            lblAmount.TabIndex = 20;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(572, 634);
            Controls.Add(lblTimer);
            Controls.Add(lblAmount);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "QuestionForm";
            Text = "QuestionForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private RadioButton radioBtnAnswer1;
        private Label lblQuestion;
        private RadioButton radioBtnAnswer3;
        private RadioButton radioBtnAnswer2;
        private RadioButton radioBtnAnswer4;
        private GroupBox groupBox1;
        private Label lblTimer;
        private Label lblAmount;
    }
}