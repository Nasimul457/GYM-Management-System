namespace GYM_Management_System
{
    partial class RegisterForm
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            FullNameTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PhoneTb = new TextBox();
            AgeTb = new TextBox();
            label7 = new Label();
            PasswordTb = new TextBox();
            ConfirmPasswordTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            GenderCB = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 46);
            label1.TabIndex = 1;
            label1.Text = "Create Account";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // FullNameTb
            // 
            FullNameTb.Location = new Point(121, 77);
            FullNameTb.Name = "FullNameTb";
            FullNameTb.Size = new Size(125, 27);
            FullNameTb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 149);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 213);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 277);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 6;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 114);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 7;
            label6.Text = "Password";
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(121, 149);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(125, 27);
            PhoneTb.TabIndex = 8;
            // 
            // AgeTb
            // 
            AgeTb.Location = new Point(121, 274);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(125, 27);
            AgeTb.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(358, 177);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 11;
            label7.Text = "Confirm Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(491, 114);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(125, 27);
            PasswordTb.TabIndex = 12;
            // 
            // ConfirmPasswordTb
            // 
            ConfirmPasswordTb.Location = new Point(491, 177);
            ConfirmPasswordTb.Name = "ConfirmPasswordTb";
            ConfirmPasswordTb.Size = new Size(125, 27);
            ConfirmPasswordTb.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Location = new Point(48, 367);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Registerbtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(657, 367);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancel_Click;
            // 
            // GenderCB
            // 
            GenderCB.FormattingEnabled = true;
            GenderCB.Items.AddRange(new object[] { "Male", "Female" });
            GenderCB.Location = new Point(121, 210);
            GenderCB.Name = "GenderCB";
            GenderCB.Size = new Size(125, 28);
            GenderCB.TabIndex = 16;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(GenderCB);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ConfirmPasswordTb);
            Controls.Add(PasswordTb);
            Controls.Add(label7);
            Controls.Add(AgeTb);
            Controls.Add(PhoneTb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FullNameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private TextBox FullNameTb;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox PhoneTb;
        private TextBox AgeTb;
        private Label label7;
        private TextBox PasswordTb;
        private TextBox ConfirmPasswordTb;
        private Button button1;
        private Button button2;
        private ComboBox GenderCB;
    }
}