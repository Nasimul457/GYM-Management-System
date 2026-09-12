namespace GYM_Management_System
{
    partial class AdminNotice
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
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnPostNotice = new Button();
            btnDeleteNotice = new Button();
            btnBack = new Button();
            txtTitle = new RichTextBox();
            txtDetails = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(219, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 46);
            label1.TabIndex = 2;
            label1.Text = "Manage Gym Notice";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(504, 87);
            label4.Name = "label4";
            label4.Size = new Size(141, 31);
            label4.TabIndex = 7;
            label4.Text = "Notice Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(504, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(363, 38);
            dateTimePicker1.TabIndex = 8;
            // 
            // btnPostNotice
            // 
            btnPostNotice.BackColor = Color.FromArgb(192, 0, 0);
            btnPostNotice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostNotice.ForeColor = Color.White;
            btnPostNotice.Location = new Point(346, 406);
            btnPostNotice.Name = "btnPostNotice";
            btnPostNotice.Size = new Size(172, 45);
            btnPostNotice.TabIndex = 14;
            btnPostNotice.Text = "Save";
            btnPostNotice.UseVisualStyleBackColor = false;
            btnPostNotice.Click += btnPostNotice_Click;
            // 
            // btnDeleteNotice
            // 
            btnDeleteNotice.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteNotice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteNotice.ForeColor = Color.White;
            btnDeleteNotice.Location = new Point(539, 406);
            btnDeleteNotice.Name = "btnDeleteNotice";
            btnDeleteNotice.Size = new Size(172, 45);
            btnDeleteNotice.TabIndex = 15;
            btnDeleteNotice.Text = "Delete";
            btnDeleteNotice.UseVisualStyleBackColor = false;
            btnDeleteNotice.Click += btnDeleteNotice_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 0, 0);
            btnBack.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(744, 404);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 45);
            btnBack.TabIndex = 16;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(26, 143);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(299, 67);
            txtTitle.TabIndex = 17;
            txtTitle.Text = "";
            // 
            // txtDetails
            // 
            txtDetails.Location = new Point(26, 299);
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(400, 89);
            txtDetails.TabIndex = 18;
            txtDetails.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 98);
            label2.Name = "label2";
            label2.Size = new Size(131, 31);
            label2.TabIndex = 19;
            label2.Text = "Notice Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 248);
            label3.Name = "label3";
            label3.Size = new Size(155, 31);
            label3.TabIndex = 20;
            label3.Text = "Notice details";
            // 
            // AdminNotice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(947, 461);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDetails);
            Controls.Add(txtTitle);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteNotice);
            Controls.Add(btnPostNotice);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "AdminNotice";
            Text = "AdminNotice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button btnPostNotice;
        private Button btnDeleteNotice;
        private Button btnBack;
        private RichTextBox txtTitle;
        private RichTextBox txtDetails;
        private Label label2;
        private Label label3;
    }
}