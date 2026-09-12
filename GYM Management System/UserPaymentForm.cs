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
    public partial class UserPaymentForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public string currentUserName = "";
        public UserPaymentForm()
        {
            InitializeComponent();
        }

        public UserPaymentForm(string username)
        {
            InitializeComponent();
            currentUserName = username;
        }

        private void UserPaymentForm_Load(object sender, EventArgs e)
        {
            LoadPaymentHistory();
        }

        private void LoadPaymentHistory()
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM PaymentTbl WHERE PMember = @MemberName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MemberName", currentUserName);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                PaymentHistoryDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {

            MainForm main = new MainForm("User", currentUserName);
            main.Show();
            this.Hide();
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            MainForm main = new MainForm("User", currentUserName);
            main.Show();
            this.Hide();
        }
    }
}
