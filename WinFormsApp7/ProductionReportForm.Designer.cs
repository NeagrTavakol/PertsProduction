namespace WinFormsApp7
{
    partial class ProductionReportForm
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
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReports.Location = new Point(12, 53);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.RowHeadersWidth = 51;
            dataGridViewReports.RowTemplate.Height = 29;
            dataGridViewReports.Size = new Size(776, 385);
            dataGridViewReports.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "گزارش روند تولید";
            // 
            // ProductionReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewReports);
            Name = "ProductionReportForm";
            Text = "ProductionReportForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReports;
        private Label label1;
    }
}