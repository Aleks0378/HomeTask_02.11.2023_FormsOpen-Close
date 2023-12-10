namespace ComputerShop
{
    partial class DetailsForm
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
            detailsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)detailsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // detailsDataGridView
            // 
            detailsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailsDataGridView.Dock = DockStyle.Fill;
            detailsDataGridView.Location = new Point(0, 0);
            detailsDataGridView.Name = "detailsDataGridView";
            detailsDataGridView.RowHeadersWidth = 51;
            detailsDataGridView.Size = new Size(644, 397);
            detailsDataGridView.TabIndex = 0;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 397);
            Controls.Add(detailsDataGridView);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ((System.ComponentModel.ISupportInitialize)detailsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView detailsDataGridView;
    }
}