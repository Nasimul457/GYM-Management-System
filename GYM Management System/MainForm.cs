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

        private void UpdateMember_Click(object sender, EventArgs e)
        {
            UpdateDelete update_delted = new UpdateDelete();
            update_delted.Show();
            this.Hide();
        }

        private void DeleteMember_Click(object sender, EventArgs e)
        {
            ViewMembers view = new ViewMembers();
            view.Show();
            this.Hide();
        }

        private void PaymentMember_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }
    }
}
