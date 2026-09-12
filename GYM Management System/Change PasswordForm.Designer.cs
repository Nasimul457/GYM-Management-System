namespace GYM_Management_System
{
    partial class Change_PasswordForm
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
            label2 = new Label();
            UserNameTb = new TextBox();
            Label3 = new Label();
            NewPassTb = new TextBox();
            UpdateBtn = new Button();
            Backbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 46);
            label1.TabIndex = 3;
            label1.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(202, 102);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 4;
            label2.Text = "UserName";
            // 
            // UserNameTb
            // 
            UserNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTb.Location = new Point(202, 147);
            UserNameTb.Name = "UserNameTb";
            UserNameTb.Size = new Size(231, 34);
            UserNameTb.TabIndex = 5;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(202, 212);
            Label3.Name = "Label3";
            Label3.Size = new Size(162, 31);
            Label3.TabIndex = 6;
            Label3.Text = "New Password";
            // 
            // NewPassTb
            // 
            NewPassTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPassTb.Location = new Point(202, 259);
            NewPassTb.Name = "NewPassTb";
            NewPassTb.Size = new Size(231, 34);
            NewPassTb.TabIndex = 7;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(212, 377);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(152, 46);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backbtn.Location = new Point(519, 377);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(152, 46);
            Backbtn.TabIndex = 9;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // Change_PasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(683, 450);
            Controls.Add(Backbtn);
            Controls.Add(UpdateBtn);
            Controls.Add(NewPassTb);
            Controls.Add(Label3);
            Controls.Add(UserNameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Change_PasswordForm";
            Text = "Change_PasswordForm";
            Load += Change_PasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UserNameTb;
        private Label Label3;
        private TextBox NewPassTb;
        private Button UpdateBtn;
        private Button Backbtn;
    }
}