namespace Task_2
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
            reductTextBox = new TextBox();
            CancelButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // reductTextBox
            // 
            reductTextBox.Dock = DockStyle.Top;
            reductTextBox.Location = new Point(0, 0);
            reductTextBox.Multiline = true;
            reductTextBox.Name = "reductTextBox";
            reductTextBox.Size = new Size(553, 403);
            reductTextBox.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.Location = new Point(330, 409);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(211, 29);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(7, 409);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(211, 29);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(reductTextBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox reductTextBox;
        private Button CancelButton;
        private Button SaveButton;
    }
}