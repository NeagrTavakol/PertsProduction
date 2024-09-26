namespace WinFormsApp7
{
    partial class DuplicateOrdersReportForm
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
            dataGridViewReports = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReports
            // 
            dataGridViewReports.AllowUserToAddRows = false;
            dataGridViewReports.AllowUserToDeleteRows = false;
            dataGridViewReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReports.Location = new Point(0, 51);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.ReadOnly = true;
            dataGridViewReports.RowHeadersWidth = 51;
            dataGridViewReports.RowTemplate.Height = 29;
            dataGridViewReports.Size = new Size(800, 398);
            dataGridViewReports.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 20);
            label1.TabIndex = 1;
            label1.Text = "گزارش سفارش های  بیش از یکبار";
            // 
            // DuplicateOrdersReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewReports);
            Name = "DuplicateOrdersReportForm";
            Text = "DuplicateOrdersReportForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReports;
        private Label label1;
    }
}