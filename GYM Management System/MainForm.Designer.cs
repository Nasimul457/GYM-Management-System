namespace GYM_Management_System
{
    partial class MainForm
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
            panel1 = new Panel();
            btnTrainer = new Button();
            ManagebtnGYm = new Button();
            workDietbtn = new Button();
            pictureBox1 = new PictureBox();
            PaymentMember = new Button();
            DeleteMember = new Button();
            AddMember = new Button();
            ViewMember = new Button();
            button1 = new Button();
            UserProfileBtn = new Button();
            PaymentHistoryBtn = new Button();
            UserWorkDiet = new Button();
            btnGymNotice = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnTrainer);
            panel1.Controls.Add(ManagebtnGYm);
            panel1.Controls.Add(workDietbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PaymentMember);
            panel1.Controls.Add(DeleteMember);
            panel1.Controls.Add(AddMember);
            panel1.Controls.Add(ViewMember);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 108);
            panel1.TabIndex = 0;
            // 
            // btnTrainer
            // 
            btnTrainer.BackColor = Color.FromArgb(192, 0, 0);
            btnTrainer.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrainer.ForeColor = Color.White;
            btnTrainer.Location = new Point(890, 12);
            btnTrainer.Name = "btnTrainer";
            btnTrainer.Size = new Size(222, 45);
            btnTrainer.TabIndex = 18;
            btnTrainer.Text = "Trainer";
            btnTrainer.UseVisualStyleBackColor = false;
            btnTrainer.Click += btnTrainer_Click;
            // 
            // ManagebtnGYm
            // 
            ManagebtnGYm.BackColor = Color.FromArgb(192, 0, 0);
            ManagebtnGYm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagebtnGYm.ForeColor = Color.White;
            ManagebtnGYm.Location = new Point(542, 61);
            ManagebtnGYm.Name = "ManagebtnGYm";
            ManagebtnGYm.Size = new Size(222, 45);
            ManagebtnGYm.TabIndex = 17;
            ManagebtnGYm.Text = "Manage Notice";
            ManagebtnGYm.UseVisualStyleBackColor = false;
            ManagebtnGYm.Click += ManagebtnGYm_Click;
            // 
            // workDietbtn
            // 
            workDietbtn.BackColor = Color.FromArgb(192, 0, 0);
            workDietbtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            workDietbtn.ForeColor = Color.White;
            workDietbtn.Location = new Point(298, 60);
            workDietbtn.Name = "workDietbtn";
            workDietbtn.Size = new Size(222, 45);
            workDietbtn.TabIndex = 16;
            workDietbtn.Text = "Workout&&DietPlan";
            workDietbtn.UseVisualStyleBackColor = false;
            workDietbtn.Click += workDietbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.workout1;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PaymentMember
            // 
            PaymentMember.BackColor = Color.FromArgb(192, 0, 0);
            PaymentMember.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentMember.ForeColor = Color.White;
            PaymentMember.Location = new Point(12, 60);
            PaymentMember.Name = "PaymentMember";
            PaymentMember.Size = new Size(172, 45);
            PaymentMember.TabIndex = 12;
            PaymentMember.Text = "Payment";
            PaymentMember.UseVisualStyleBackColor = false;
            PaymentMember.Click += PaymentMember_Click;
            // 
            // DeleteMember
            // 
            DeleteMember.BackColor = Color.FromArgb(192, 0, 0);
            DeleteMember.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteMember.ForeColor = Color.White;
            DeleteMember.Location = new Point(641, 10);
            DeleteMember.Name = "DeleteMember";
            DeleteMember.Size = new Size(234, 45);
            DeleteMember.TabIndex = 11;
            DeleteMember.Text = "Update && Delete";
            DeleteMember.UseVisualStyleBackColor = false;
            DeleteMember.Click += Update_Delete_Click;
            // 
            // AddMember
            // 
            AddMember.BackColor = Color.FromArgb(192, 0, 0);
            AddMember.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMember.ForeColor = Color.White;
            AddMember.Location = new Point(266, 10);
            AddMember.Name = "AddMember";
            AddMember.Size = new Size(172, 45);
            AddMember.TabIndex = 10;
            AddMember.Text = "Add Member";
            AddMember.UseVisualStyleBackColor = false;
            AddMember.Click += AddMember_Click;
            // 
            // ViewMember
            // 
            ViewMember.BackColor = Color.FromArgb(192, 0, 0);
            ViewMember.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewMember.ForeColor = Color.White;
            ViewMember.Location = new Point(453, 10);
            ViewMember.Name = "ViewMember";
            ViewMember.Size = new Size(172, 45);
            ViewMember.TabIndex = 9;
            ViewMember.Text = "View Member";
            ViewMember.UseVisualStyleBackColor = false;
            ViewMember.Click += View_Member_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 609);
            button1.Name = "button1";
            button1.Size = new Size(172, 45);
            button1.TabIndex = 13;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Back_Btn;
            // 
            // UserProfileBtn
            // 
            UserProfileBtn.BackColor = Color.FromArgb(192, 0, 0);
            UserProfileBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserProfileBtn.ForeColor = Color.White;
            UserProfileBtn.Location = new Point(12, 140);
            UserProfileBtn.Name = "UserProfileBtn";
            UserProfileBtn.Size = new Size(172, 45);
            UserProfileBtn.TabIndex = 14;
            UserProfileBtn.Text = "UserProfile";
            UserProfileBtn.UseVisualStyleBackColor = false;
            UserProfileBtn.Click += UserProfileBtn_Click;
            // 
            // PaymentHistoryBtn
            // 
            PaymentHistoryBtn.BackColor = Color.FromArgb(192, 0, 0);
            PaymentHistoryBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentHistoryBtn.ForeColor = Color.White;
            PaymentHistoryBtn.Location = new Point(12, 242);
            PaymentHistoryBtn.Name = "PaymentHistoryBtn";
            PaymentHistoryBtn.Size = new Size(222, 45);
            PaymentHistoryBtn.TabIndex = 15;
            PaymentHistoryBtn.Text = "PaymentHistory";
            PaymentHistoryBtn.UseVisualStyleBackColor = false;
            PaymentHistoryBtn.Click += PaymentHistoryBtn_Click;
            // 
            // UserWorkDiet
            // 
            UserWorkDiet.BackColor = Color.FromArgb(192, 0, 0);
            UserWorkDiet.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserWorkDiet.ForeColor = Color.White;
            UserWorkDiet.Location = new Point(12, 338);
            UserWorkDiet.Name = "UserWorkDiet";
            UserWorkDiet.Size = new Size(251, 45);
            UserWorkDiet.TabIndex = 16;
            UserWorkDiet.Text = "User Workout&&Diet";
            UserWorkDiet.UseVisualStyleBackColor = false;
            UserWorkDiet.Click += UserWorkDiet_Click;
            // 
            // btnGymNotice
            // 
            btnGymNotice.BackColor = Color.FromArgb(192, 0, 0);
            btnGymNotice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGymNotice.ForeColor = Color.White;
            btnGymNotice.Location = new Point(12, 430);
            btnGymNotice.Name = "btnGymNotice";
            btnGymNotice.Size = new Size(251, 45);
            btnGymNotice.TabIndex = 17;
            btnGymNotice.Text = "GYM NOTICE";
            btnGymNotice.UseVisualStyleBackColor = false;
            btnGymNotice.Click += btnGymNotice_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 654);
            Controls.Add(btnGymNotice);
            Controls.Add(UserWorkDiet);
            Controls.Add(PaymentHistoryBtn);
            Controls.Add(UserProfileBtn);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button PaymentMember;
        private Button DeleteMember;
        private Button AddMember;
        private Button ViewMember;
        private PictureBox pictureBox1;
        private Button button1;
        private Button UserProfileBtn;
        private Button PaymentHistoryBtn;
        private Button workDietbtn;
        private Button UserWorkDiet;
        private Button btnGymNotice;
        private Button ManagebtnGYm;
        private Button btnTrainer;
    }
}