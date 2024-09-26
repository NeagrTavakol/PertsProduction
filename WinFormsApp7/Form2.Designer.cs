namespace WinFormsApp7
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
            label4 = new Label();
            txtOperatorName = new TextBox();
            label2 = new Label();
            txtWorkStation = new TextBox();
            btnShowPdf = new Button();
            btnAddStep = new Button();
            btnStartStep = new Button();
            dataGridViewSteps = new DataGridView();
            label1 = new Label();
            comboBoxParts = new ComboBox();
            btnCreateNewOrder = new Button();
            label3 = new Label();
            numericUDinput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUDinput).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(975, 201);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 23;
            label4.Text = "نام اپراتور";
            // 
            // txtOperatorName
            // 
            txtOperatorName.Location = new Point(745, 194);
            txtOperatorName.Name = "txtOperatorName";
            txtOperatorName.Size = new Size(151, 27);
            txtOperatorName.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(955, 131);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 19;
            label2.Text = "ایستگاه کاری";
            // 
            // txtWorkStation
            // 
            txtWorkStation.Location = new Point(745, 124);
            txtWorkStation.Name = "txtWorkStation";
            txtWorkStation.Size = new Size(151, 27);
            txtWorkStation.TabIndex = 18;
            // 
            // btnShowPdf
            // 
            btnShowPdf.Location = new Point(150, 489);
            btnShowPdf.Name = "btnShowPdf";
            btnShowPdf.Size = new Size(120, 39);
            btnShowPdf.TabIndex = 17;
            btnShowPdf.Text = "PDF نمایش";
            btnShowPdf.UseVisualStyleBackColor = true;
            btnShowPdf.Click += btnShowPdf_Click_1;
            // 
            // btnAddStep
            // 
            btnAddStep.Location = new Point(411, 489);
            btnAddStep.Name = "btnAddStep";
            btnAddStep.Size = new Size(153, 39);
            btnAddStep.TabIndex = 16;
            btnAddStep.Text = "افزودن مرحله جدید";
            btnAddStep.UseVisualStyleBackColor = true;
            btnAddStep.Click += btnAddStep_Click_1;
            // 
            // btnStartStep
            // 
            btnStartStep.Location = new Point(626, 489);
            btnStartStep.Name = "btnStartStep";
            btnStartStep.Size = new Size(145, 39);
            btnStartStep.TabIndex = 15;
            btnStartStep.Text = "شروع مرحله فعلی";
            btnStartStep.UseVisualStyleBackColor = true;
            btnStartStep.Click += btnStartStep_Click;
            // 
            // dataGridViewSteps
            // 
            dataGridViewSteps.AllowUserToAddRows = false;
            dataGridViewSteps.AllowUserToDeleteRows = false;
            dataGridViewSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSteps.Location = new Point(50, 39);
            dataGridViewSteps.Name = "dataGridViewSteps";
            dataGridViewSteps.ReadOnly = true;
            dataGridViewSteps.RowHeadersWidth = 51;
            dataGridViewSteps.RowTemplate.Height = 29;
            dataGridViewSteps.Size = new Size(665, 380);
            dataGridViewSteps.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(955, 56);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 13;
            label1.Text = "انتخاب قطعه";
            // 
            // comboBoxParts
            // 
            comboBoxParts.FormattingEnabled = true;
            comboBoxParts.Location = new Point(745, 53);
            comboBoxParts.Name = "comboBoxParts";
            comboBoxParts.Size = new Size(151, 28);
            comboBoxParts.TabIndex = 12;
            // 
            // btnCreateNewOrder
            // 
            btnCreateNewOrder.Location = new Point(835, 489);
            btnCreateNewOrder.Name = "btnCreateNewOrder";
            btnCreateNewOrder.Size = new Size(135, 39);
            btnCreateNewOrder.TabIndex = 24;
            btnCreateNewOrder.Text = "سفارش جدید";
            btnCreateNewOrder.UseVisualStyleBackColor = true;
            btnCreateNewOrder.Click += btnCreateNewOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(960, 270);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 25;
            label3.Text = "تعداد ورودی";
            // 
            // numericUDinput
            // 
            numericUDinput.Location = new Point(820, 270);
            numericUDinput.Name = "numericUDinput";
            numericUDinput.Size = new Size(76, 27);
            numericUDinput.TabIndex = 26;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 580);
            Controls.Add(numericUDinput);
            Controls.Add(label3);
            Controls.Add(btnCreateNewOrder);
            Controls.Add(label4);
            Controls.Add(txtOperatorName);
            Controls.Add(label2);
            Controls.Add(txtWorkStation);
            Controls.Add(btnShowPdf);
            Controls.Add(btnAddStep);
            Controls.Add(btnStartStep);
            Controls.Add(dataGridViewSteps);
            Controls.Add(label1);
            Controls.Add(comboBoxParts);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUDinput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtOperatorName;
        private Label label2;
        private TextBox txtWorkStation;
        private Button btnShowPdf;
        private Button btnAddStep;
        private Button btnStartStep;
        private DataGridView dataGridViewSteps;
        private Label label1;
        private ComboBox comboBoxParts;
        private Button btnCreateNewOrder;
        private Label label3;
        private NumericUpDown numericUDinput;
    }
}