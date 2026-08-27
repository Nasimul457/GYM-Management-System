namespace GYM_Management_System
{
    partial class LoginForm
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UsernameTb = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            PasswordTb = new TextBox();
            pictureBox3 = new PictureBox();
            LoginBtn = new Button();
            ResetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(133, 19);
            label1.Name = "label1";
            label1.Size = new Size(436, 46);
            label1.TabIndex = 0;
            label1.Text = "Gym Management System";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gym;
            pictureBox1.Location = new Point(12, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UsernameTb
            // 
            UsernameTb.Cursor = Cursors.IBeam;
            UsernameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTb.Location = new Point(237, 124);
            UsernameTb.Multiline = true;
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(262, 40);
            UsernameTb.TabIndex = 2;
            UsernameTb.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 83);
            label2.Name = "label2";
            label2.Size = new Size(148, 38);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.username;
            pictureBox2.Location = new Point(505, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(237, 189);
            label3.Name = "label3";
            label3.Size = new Size(139, 38);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(237, 230);
            PasswordTb.Multiline = true;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(262, 40);
            PasswordTb.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(505, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(192, 0, 0);
            LoginBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(237, 306);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(172, 45);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.FromArgb(192, 0, 0);
            ResetBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(442, 306);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(172, 45);
            ResetBtn.TabIndex = 9;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.pngtree_a_fully_equipped_gym_with_dumbbells_weight_machines_and_cardio_equipment_image_16843660__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(ResetBtn);
            Controls.Add(LoginBtn);
            Controls.Add(pictureBox3);
            Controls.Add(PasswordTb);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(UsernameTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UsernameTb;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox PasswordTb;
        private PictureBox pictureBox3;
        private Button LoginBtn;
        private Button ResetBtn;
    }
}
