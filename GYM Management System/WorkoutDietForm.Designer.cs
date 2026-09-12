namespace GYM_Management_System
{
    partial class WorkoutDietForm
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            MemberCB = new ComboBox();
            DietTb = new RichTextBox();
            WorkoutTb = new RichTextBox();
            DateTb = new TextBox();
            BackBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            DeleteBtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(13, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(214, 38);
            label3.TabIndex = 5;
            label3.Text = "Member Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(13, 260);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 38);
            label1.TabIndex = 6;
            label1.Text = "WorkOutROutine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(433, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 38);
            label2.TabIndex = 7;
            label2.Text = "DietPlan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(448, 260);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 38);
            label4.TabIndex = 8;
            label4.Text = "Date";
            // 
            // MemberCB
            // 
            MemberCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemberCB.FormattingEnabled = true;
            MemberCB.Items.AddRange(new object[] { "06.00 am - 08:00 am", "08.00 am - 10:00 am", "06.00 pm - 08:00 pm", "08.00 pm - 10:00 pm" });
            MemberCB.Location = new Point(13, 124);
            MemberCB.Margin = new Padding(4);
            MemberCB.Name = "MemberCB";
            MemberCB.Size = new Size(244, 36);
            MemberCB.TabIndex = 18;
            // 
            // DietTb
            // 
            DietTb.Location = new Point(433, 110);
            DietTb.Name = "DietTb";
            DietTb.Size = new Size(324, 120);
            DietTb.TabIndex = 20;
            DietTb.Text = "";
            // 
            // WorkoutTb
            // 
            WorkoutTb.Location = new Point(22, 318);
            WorkoutTb.Name = "WorkoutTb";
            WorkoutTb.Size = new Size(249, 120);
            WorkoutTb.TabIndex = 21;
            WorkoutTb.Text = "";
            // 
            // DateTb
            // 
            DateTb.Location = new Point(448, 327);
            DateTb.Name = "DateTb";
            DateTb.Size = new Size(222, 27);
            DateTb.TabIndex = 22;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(192, 0, 0);
            BackBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(22, 459);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(172, 45);
            BackBtn.TabIndex = 23;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(192, 0, 0);
            EditBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(411, 459);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(172, 45);
            EditBtn.TabIndex = 24;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(192, 0, 0);
            SaveBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(221, 459);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(172, 45);
            SaveBtn.TabIndex = 25;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(192, 0, 0);
            DeleteBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(604, 459);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(172, 45);
            DeleteBtn.TabIndex = 26;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(782, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(739, 456);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // WorkoutDietForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1548, 611);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(EditBtn);
            Controls.Add(BackBtn);
            Controls.Add(DateTb);
            Controls.Add(WorkoutTb);
            Controls.Add(DietTb);
            Controls.Add(MemberCB);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "WorkoutDietForm";
            Text = "WorkoutDietForm";
            Load += WorkoutDietForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox MemberCB;
        private RichTextBox DietTb;
        private RichTextBox WorkoutTb;
        private TextBox DateTb;
        private Button BackBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private Button DeleteBtn;
        private DataGridView dataGridView1;
    }
}