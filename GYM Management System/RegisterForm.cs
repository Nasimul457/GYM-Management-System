using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace GYM_Management_System
{
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            if (FullNameTb.Text == "" || PhoneTb.Text == "" || GenderCB.SelectedIndex == -1 || AgeTb.Text == "" || PasswordTb.Text == "" || ConfirmPasswordTb.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (PasswordTb.Text != ConfirmPasswordTb.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                    con.Open();


                    string query = "INSERT INTO MemberTbl (MName, MPhone, MGen, MAge, MAmount, MTiming, TrainerId, MPassword) VALUES (@Name, @Phone, @Gender, @Age, @Amount, @Timing, @TrainerId, @Password)"; SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", FullNameTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", GenderCB.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Age", AgeTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Amount", 0);
                    cmd.Parameters.AddWithValue("@Timing", "06.00 am - 08.00 am"); 
                    cmd.Parameters.AddWithValue("@TrainerId", 1);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        private void ClearForm()
        {
            FullNameTb.Text = "";
            PhoneTb.Text = "";
            GenderCB.SelectedIndex = -1;
            AgeTb.Text = "";
            PasswordTb.Text = "";
            ConfirmPasswordTb.Text = "";
            FullNameTb.Focus(); 
        }
    }
}

