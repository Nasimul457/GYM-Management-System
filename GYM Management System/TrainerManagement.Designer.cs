namespace GYM_Management_System
{
    partial class TrainerManagement
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
            txtTrainerName = new TextBox();
            txtPhone = new TextBox();
            label2 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtExperience = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtSalary = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            backbtn = new Button();
            btnSave = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 0;
            label1.Text = "Trainer Name";
            // 
            // txtTrainerName
            // 
            txtTrainerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTrainerName.Location = new Point(12, 91);
            txtTrainerName.Name = "txtTrainerName";
            txtTrainerName.Size = new Size(185, 34);
            txtTrainerName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(12, 244);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(185, 34);
            txtPhone.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 2;
            label2.Text = "Phone";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(12, 369);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(185, 34);
            txtAge.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 312);
            label3.Name = "label3";
            label3.Size = new Size(55, 31);
            label3.TabIndex = 4;
            label3.Text = "Age";
            // 
            // txtExperience
            // 
            txtExperience.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExperience.Location = new Point(257, 91);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(185, 34);
            txtExperience.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(257, 33);
            label4.Name = "label4";
            label4.Size = new Size(125, 31);
            label4.TabIndex = 6;
            label4.Text = "Experience";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 198);
            label5.Name = "label5";
            label5.Size = new Size(75, 31);
            label5.TabIndex = 8;
            label5.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalary.Location = new Point(272, 244);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(170, 34);
            txtSalary.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(272, 312);
            label6.Name = "label6";
            label6.Size = new Size(89, 31);
            label6.TabIndex = 10;
            label6.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(272, 369);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 36);
            cmbGender.TabIndex = 11;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.FromArgb(192, 0, 0);
            backbtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.ForeColor = Color.White;
            backbtn.Location = new Point(12, 511);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(101, 42);
            backbtn.TabIndex = 14;
            backbtn.Text = "BACK";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(147, 511);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 42);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(281, 511);
            button3.Name = "button3";
            button3.Size = new Size(101, 42);
            button3.TabIndex = 16;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnUpdate_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(430, 511);
            button4.Name = "button4";
            button4.Size = new Size(101, 42);
            button4.TabIndex = 17;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(481, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(756, 364);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TrainerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1260, 558);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnSave);
            Controls.Add(backbtn);
            Controls.Add(cmbGender);
            Controls.Add(label6);
            Controls.Add(txtSalary);
            Controls.Add(label5);
            Controls.Add(txtExperience);
            Controls.Add(label4);
            Controls.Add(txtAge);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtTrainerName);
            Controls.Add(label1);
            Name = "TrainerManagement";
            Text = "TrainerManagement";
            Load += TrainerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTrainerName;
        private TextBox txtPhone;
        private Label label2;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtExperience;
        private Label label4;
        private Label label5;
        private TextBox txtSalary;
        private Label label6;
        private ComboBox cmbGender;
        private Button backbtn;
        private Button btnSave;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}