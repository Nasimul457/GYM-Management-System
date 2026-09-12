using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GYM_Management_System
{
    public partial class Change_PasswordForm : Form
    {
        public Change_PasswordForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void Change_PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "" || NewPassTb.Text == "")
            {
                MessageBox.Show("Please Enter Username and New Password!");
            }
            else
            {
                try
                {
                    con.Open();

                    string uname = UserNameTb.Text.Trim();
                    string newPass = NewPassTb.Text.Trim();

                    string checkMemberQuery = "SELECT COUNT(*) FROM MemberTbl WHERE MName = @UName";
                    SqlCommand memberCmd = new SqlCommand(checkMemberQuery, con);
                    memberCmd.Parameters.AddWithValue("@UName", uname);
                    int memberCount = (int)memberCmd.ExecuteScalar();

                    if (memberCount > 0)
                    {
                       
                        string updateMemberQuery = "UPDATE MemberTbl SET MPassword = @NewPass WHERE MName = @UName";
                        SqlCommand updateMemberCmd = new SqlCommand(updateMemberQuery, con);
                        updateMemberCmd.Parameters.AddWithValue("@NewPass", newPass);
                        updateMemberCmd.Parameters.AddWithValue("@UName", uname);
                        updateMemberCmd.ExecuteNonQuery();

                        MessageBox.Show("Member Password Reset Successfully!");
                    }

                    else
                    {
                        string checkUserQuery = "SELECT COUNT(*) FROM UserTbl WHERE Username = @UName";
                        SqlCommand userCmd = new SqlCommand(checkUserQuery, con);
                        userCmd.Parameters.AddWithValue("@UName", uname);
                        int userCount = (int)userCmd.ExecuteScalar();
                        if (userCount > 0)
                        {
                            string updateUserQuery = "UPDATE UserTbl SET Password = @NewPass WHERE Username = @UName";
                            SqlCommand updateUserCmd = new SqlCommand(updateUserQuery, con);
                            updateUserCmd.Parameters.AddWithValue("@NewPass", newPass);
                            updateUserCmd.Parameters.AddWithValue("@UName", uname);
                            updateUserCmd.ExecuteNonQuery();

                            MessageBox.Show("Staff Password Reset Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Username Not Found in System!");
                        }
                    }
                    con.Close();


                        UserNameTb.Text = "";
                        NewPassTb.Text = "";
                    
                    //else
                    //{
                    //    MessageBox.Show("Username Not Found!");
                    //    con.Close();
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            //MainForm main = new MainForm("Admin", "Nasim");
            //main.Show();
            //this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }
    }
}

