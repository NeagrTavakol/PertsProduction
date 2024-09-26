namespace WinFormsApp7
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
            btnProductionReForm = new Button();
            btnOpenForm2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnProductionReForm
            // 
            btnProductionReForm.Location = new Point(528, 86);
            btnProductionReForm.Name = "btnProductionReForm";
            btnProductionReForm.Size = new Size(260, 72);
            btnProductionReForm.TabIndex = 0;
            btnProductionReForm.Text = "گزارش‌گیری از روند تولید";
            btnProductionReForm.UseVisualStyleBackColor = true;
            btnProductionReForm.Click += btnProductionReForm_Click;
            // 
            // btnOpenForm2
            // 
            btnOpenForm2.Location = new Point(348, 108);
            btnOpenForm2.Name = "btnOpenForm2";
            btnOpenForm2.Size = new Size(133, 29);
            btnOpenForm2.TabIndex = 1;
            btnOpenForm2.Text = "سفارش تولید";
            btnOpenForm2.UseVisualStyleBackColor = true;
            btnOpenForm2.Click += btnOpenForm2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(27, 86);
            button3.Name = "button3";
            button3.Size = new Size(269, 72);
            button3.TabIndex = 2;
            button3.Text = "گزارش گیری از قطعات بیش از یکبار";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnOpenForm2);
            Controls.Add(btnProductionReForm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductionReForm;
        private Button btnOpenForm2;
        private Button button3;
    }
}