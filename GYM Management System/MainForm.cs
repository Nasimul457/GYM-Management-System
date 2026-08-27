using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GYM_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
