using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GYM_Management_System
{
    public partial class UserProfileForm : Form
    {
        public string currentUsername = "";
        private int memberId = 0;

        public UserProfileForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }
        public UserProfileForm()
        {
            InitializeComponent();
            currentUsername = "Nasimul";
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

            LoadProfileData();
        }

        private void LoadProfileData()
        {
            try
            {
                con.Open();


                string query = "SELECT * FROM MemberTbl WHERE MName = @UserName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", currentUsername);

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    memberId = Convert.ToInt32(dt.Rows[0]["Mid"]);
                    NameTb.Text = dt.Rows[0]["MName"].ToString();
                    PhoneTB.Text = dt.Rows[0]["MPhone"].ToString();
                    AgeTb.Text = dt.Rows[0]["MAge"].ToString();
                    GenderCB.Text = dt.Rows[0]["MGen"].ToString();
                    MonthlyAmountTb.Text = dt.Rows[0]["MAmount"].ToString();
                    TimingCb.Text = dt.Rows[0]["MTiming"].ToString();
                    HeightTb.Text = dt.Rows[0]["MHeight"].ToString();
                    weightTb.Text = dt.Rows[0]["MWeight"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found for: " + currentUsername);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserProfileForm_Load_1(object sender, EventArgs e)
        {


            LoadProfileData();
            MonthlyAmountTb.ReadOnly = true;
            TimingCb.Enabled = false;
            HeightTb.ReadOnly = true; 
            weightTb.ReadOnly = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm("User", currentUsername);
            main.Show();
            this.Hide();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTB.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Please fill in all required fields!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }


                    string query = "UPDATE MemberTbl SET MName = @Name, MPhone = @Phone, MAge = @Age, MGen = @Gender, MHeight = @Height, MWeight = @Weight WHERE Mid = @Id"; SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", NameTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age", AgeTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", GenderCB.Text);
                    cmd.Parameters.AddWithValue("@Id", memberId);
                    cmd.Parameters.AddWithValue("@Height", HeightTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Weight", weightTb.Text.Trim());

                    cmd.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    MessageBox.Show("Profile Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    currentUsername = NameTb.Text.Trim();
                    LoadProfileData();
                }
                catch (Exception ex)
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
