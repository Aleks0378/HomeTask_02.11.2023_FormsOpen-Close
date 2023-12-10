namespace ComputerShop
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
            categoryComboBox = new ComboBox();
            itemsListBox = new ListBox();
            cartListBox = new ListBox();
            addToCartButton = new Button();
            detailsButton = new Button();
            deleteFromCartButton = new Button();
            totalToPayTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            completeOrderButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 35);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(157, 28);
            categoryComboBox.TabIndex = 0;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(176, 10);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.SelectionMode = SelectionMode.MultiExtended;
            itemsListBox.Size = new Size(958, 304);
            itemsListBox.TabIndex = 1;
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.Location = new Point(175, 366);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(973, 244);
            cartListBox.TabIndex = 2;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(13, 231);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(157, 29);
            addToCartButton.TabIndex = 3;
            addToCartButton.Text = "Add Item";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // detailsButton
            // 
            detailsButton.Location = new Point(13, 283);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(157, 29);
            detailsButton.TabIndex = 4;
            detailsButton.Text = "Details";
            detailsButton.UseVisualStyleBackColor = true;
            detailsButton.Click += detailsButton_Click;
            // 
            // deleteFromCartButton
            // 
            deleteFromCartButton.Location = new Point(13, 457);
            deleteFromCartButton.Name = "deleteFromCartButton";
            deleteFromCartButton.Size = new Size(158, 29);
            deleteFromCartButton.TabIndex = 5;
            deleteFromCartButton.Text = "Delete";
            deleteFromCartButton.UseVisualStyleBackColor = true;
            deleteFromCartButton.Click += deleteFromCartButton_Click;
            // 
            // totalToPayTextBox
            // 
            totalToPayTextBox.Location = new Point(13, 536);
            totalToPayTextBox.Name = "totalToPayTextBox";
            totalToPayTextBox.ReadOnly = true;
            totalToPayTextBox.Size = new Size(157, 27);
            totalToPayTextBox.TabIndex = 6;
            totalToPayTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 513);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 7;
            label1.Text = "Total Sum to pay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Category:";
            // 
            // completeOrderButton
            // 
            completeOrderButton.Location = new Point(12, 581);
            completeOrderButton.Name = "completeOrderButton";
            completeOrderButton.Size = new Size(158, 29);
            completeOrderButton.TabIndex = 11;
            completeOrderButton.Text = "Complete Order";
            completeOrderButton.UseVisualStyleBackColor = true;
            completeOrderButton.Click += completeOrderButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 343);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 12;
            label4.Text = "Your Shoping Cart list:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 658);
            Controls.Add(label4);
            Controls.Add(completeOrderButton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(totalToPayTextBox);
            Controls.Add(deleteFromCartButton);
            Controls.Add(detailsButton);
            Controls.Add(addToCartButton);
            Controls.Add(cartListBox);
            Controls.Add(itemsListBox);
            Controls.Add(categoryComboBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox categoryComboBox;
        private ListBox itemsListBox;
        private ListBox cartListBox;
        private Button addToCartButton;
        private Button detailsButton;
        private Button deleteFromCartButton;
        private TextBox totalToPayTextBox;
        private Label label1;
        private Label label3;
        private Button completeOrderButton;
        private Label label4;
    }
}
