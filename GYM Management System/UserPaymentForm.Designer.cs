namespace GYM_Management_System
{
    partial class UserPaymentForm
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
            label2 = new Label();
            PaymentHistoryDGV = new DataGridView();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PaymentHistoryDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(197, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(332, 46);
            label2.TabIndex = 77;
            label2.Text = "PAYMENT HISTORY";
            // 
            // PaymentHistoryDGV
            // 
            PaymentHistoryDGV.BackgroundColor = Color.White;
            PaymentHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentHistoryDGV.Location = new Point(89, 103);
            PaymentHistoryDGV.Name = "PaymentHistoryDGV";
            PaymentHistoryDGV.RowHeadersWidth = 51;
            PaymentHistoryDGV.Size = new Size(593, 208);
            PaymentHistoryDGV.TabIndex = 78;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(192, 0, 0);
            BackBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(12, 417);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(172, 45);
            BackBtn.TabIndex = 79;
            BackBtn.Text = "BACK";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click_1;
            // 
            // UserPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 474);
            Controls.Add(BackBtn);
            Controls.Add(PaymentHistoryDGV);
            Controls.Add(label2);
            Name = "UserPaymentForm";
            Text = "UserPaymentForm";
            Load += UserPaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)PaymentHistoryDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView PaymentHistoryDGV;
        private Button BackBtn;
    }
}