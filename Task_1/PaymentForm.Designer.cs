namespace ComputerShop
{
    partial class PaymentForm
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
            label1 = new Label();
            TotalToPayTextBox = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cashRadioButton = new RadioButton();
            creditCardRadioButton = new RadioButton();
            PayButton = new Button();
            OrderListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Your Order:";
            // 
            // TotalToPayTextBox
            // 
            TotalToPayTextBox.Location = new Point(444, 159);
            TotalToPayTextBox.Name = "TotalToPayTextBox";
            TotalToPayTextBox.ReadOnly = true;
            TotalToPayTextBox.Size = new Size(140, 27);
            TotalToPayTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 162);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 8;
            label2.Text = "Total Sum to pay:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cashRadioButton);
            groupBox1.Controls.Add(creditCardRadioButton);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 90);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment method:";
            // 
            // cashRadioButton
            // 
            cashRadioButton.AutoSize = true;
            cashRadioButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cashRadioButton.Location = new Point(448, 52);
            cashRadioButton.Name = "cashRadioButton";
            cashRadioButton.Size = new Size(68, 27);
            cashRadioButton.TabIndex = 1;
            cashRadioButton.Text = "Cash";
            cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // creditCardRadioButton
            // 
            creditCardRadioButton.AutoSize = true;
            creditCardRadioButton.Checked = true;
            creditCardRadioButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            creditCardRadioButton.Location = new Point(448, 19);
            creditCardRadioButton.Name = "creditCardRadioButton";
            creditCardRadioButton.Size = new Size(118, 27);
            creditCardRadioButton.TabIndex = 0;
            creditCardRadioButton.TabStop = true;
            creditCardRadioButton.Text = "Credit Card";
            creditCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // PayButton
            // 
            PayButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PayButton.Location = new Point(380, 324);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(204, 38);
            PayButton.TabIndex = 11;
            PayButton.Text = "Pay";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // OrderListBox
            // 
            OrderListBox.FormattingEnabled = true;
            OrderListBox.Location = new Point(0, 29);
            OrderListBox.Name = "OrderListBox";
            OrderListBox.Size = new Size(584, 124);
            OrderListBox.TabIndex = 1;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 385);
            Controls.Add(PayButton);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(TotalToPayTextBox);
            Controls.Add(OrderListBox);
            Controls.Add(label1);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.Manual;
            Text = "PaymentForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TotalToPayTextBox;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton cashRadioButton;
        private RadioButton creditCardRadioButton;
        private Button PayButton;
        private ListBox OrderListBox;
    }
}