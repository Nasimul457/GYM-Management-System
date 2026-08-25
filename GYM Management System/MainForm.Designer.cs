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
            button5 = new Button();
            pictureBox1 = new PictureBox();
            PaymentMember = new Button();
            DeleteMember = new Button();
            AddMember = new Button();
            UpdateMember = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PaymentMember);
            panel1.Controls.Add(DeleteMember);
            panel1.Controls.Add(AddMember);
            panel1.Controls.Add(UpdateMember);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 70);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1133, -3);
            button5.Name = "button5";
            button5.Size = new Size(51, 70);
            button5.TabIndex = 13;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            PaymentMember.Location = new Point(833, 10);
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
            DeleteMember.Size = new Size(172, 45);
            DeleteMember.TabIndex = 11;
            DeleteMember.Text = "Delete";
            DeleteMember.UseVisualStyleBackColor = false;
            DeleteMember.Click += DeleteMember_Click;
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
            // UpdateMember
            // 
            UpdateMember.BackColor = Color.FromArgb(192, 0, 0);
            UpdateMember.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMember.ForeColor = Color.White;
            UpdateMember.Location = new Point(453, 10);
            UpdateMember.Name = "UpdateMember";
            UpdateMember.Size = new Size(172, 45);
            UpdateMember.TabIndex = 9;
            UpdateMember.Text = "Update";
            UpdateMember.UseVisualStyleBackColor = false;
            UpdateMember.Click += UpdateMember_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 570);
            button1.Name = "button1";
            button1.Size = new Size(172, 45);
            button1.TabIndex = 13;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Back_Btn;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_a_fully_equipped_gym_with_dumbbells_weight_machines_and_cardio_equipment_image_16843660__1_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 654);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button PaymentMember;
        private Button DeleteMember;
        private Button AddMember;
        private Button UpdateMember;
        private Button button5;
        private PictureBox pictureBox1;
        private Button button1;
    }
}