using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GYM_Management_System
{
    public partial class MainForm : Form
    {
        string userRole = "";
        string userName = "";
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string role, string name)
        {
            InitializeComponent();
            userRole = role;
            userName = name;

            ApplyRolePermissions();
        }


        private void ApplyRolePermissions()
        {
            if (userRole == "Trainer")
            {
                ViewMember.Visible = false;
                PaymentMember.Visible = false;
                DeleteMember.Visible = false;
                UserWorkDiet.Visible = false;
                PaymentHistoryBtn.Visible = false;
                btnGymNotice.Visible = false;
                AddMember.Visible = false;
                UserProfileBtn.Visible = false;
                btnTrainer.Visible = false;
            }
            else if (userRole == "Cashier")
            {
                PaymentMember.Visible = true;
                AddMember.Visible = false;
                DeleteMember.Visible = false;
                ViewMember.Visible = false;
                UserProfileBtn.Visible = false;
                workDietbtn.Visible = false;
                UserWorkDiet.Visible = false;
                PaymentHistoryBtn.Visible = false;
                btnGymNotice.Visible = false;
                ManagebtnGYm.Visible = false;
                btnTrainer.Visible = false;
            }
            else if (userRole == "Admin")
            {

                AddMember.Visible = true;
                ViewMember.Visible = true;
                DeleteMember.Visible = true;
                PaymentMember.Visible = false;
                UserProfileBtn.Visible = false;
                workDietbtn.Visible = false;
                UserWorkDiet.Visible = false;
                PaymentHistoryBtn.Visible = false;
                btnGymNotice.Visible = false;
                ManagebtnGYm.Visible = false;

            }
            else if (userRole == "User")
            {

                AddMember.Visible = false;
                ViewMember.Visible = false;
                DeleteMember.Visible = false;
                PaymentMember.Visible = false;
                UserProfileBtn.Visible = true;
                PaymentHistoryBtn.Visible = true;
                workDietbtn.Visible = false;
                UserWorkDiet.Visible = true;
                btnTrainer.Visible = false;
                ManagebtnGYm.Visible = false;



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Back_Btn(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }


        private void AddMember_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember();
            addmember.Show();
            this.Hide();
        }


        private void PaymentMember_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void View_Member_Click(object sender, EventArgs e)
        {
            ViewMembers view_Member = new ViewMembers();
            view_Member.Show();
            this.Hide();
        }

        private void Update_Delete_Click(object sender, EventArgs e)
        {
            UpdateDelete upd = new UpdateDelete();
            upd.Show();
            this.Hide();
        }

        private void UserProfileBtn_Click(object sender, EventArgs e)
        {
            UserProfileForm profile = new UserProfileForm(userName);
            profile.Show();
            this.Hide();
        }

        private void PaymentHistoryBtn_Click(object sender, EventArgs e)
        {
            UserPaymentForm payForm = new UserPaymentForm(userName);
            payForm.Show();
            this.Hide();
        }

        private void workDietbtn_Click(object sender, EventArgs e)
        {
            WorkoutDietForm wf = new WorkoutDietForm(userName);
            wf.Show();
            this.Hide();
        }

        private void UserWorkDiet_Click(object sender, EventArgs e)
        {
            UserPlanForm upf = new UserPlanForm(userName);
            upf.Show();
            this.Hide();
        }

        private void btnGymNotice_Click(object sender, EventArgs e)
        {
          //  UserNoticeForm noticeForm = new UserNoticeForm();
            UserNoticeForm noticeForm = new UserNoticeForm(userName);
            noticeForm.Show();
            this.Hide();
        }

        private void ManagebtnGYm_Click(object sender, EventArgs e)
        {
            AdminNotice adminNoticeForm = new AdminNotice();
            adminNoticeForm.Show();
            this.Hide();
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            TrainerManagement trainer = new TrainerManagement();
            trainer.Show();
            this.Hide();
        }
    }
}
