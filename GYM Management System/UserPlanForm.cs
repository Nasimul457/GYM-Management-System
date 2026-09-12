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
    public partial class UserPlanForm : Form

    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public string loggedInUser = "";
        public UserPlanForm()
        {
            InitializeComponent();
        }

        public UserPlanForm(string userName)
        {
            InitializeComponent();
            loggedInUser = userName; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserPlanForm_Load(object sender, EventArgs e)
        {
            LoadUserPlan();
        }

        private void LoadUserPlan()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                
                string query = "SELECT WorkoutRoutine, DietPlan, PlanDate FROM WorkoutDietTbl WHERE MemberName = @MName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MName", loggedInUser);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

               
                dataGridView1.DataSource = dt;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm("User", loggedInUser);
            main.Show();
            this.Hide();

        }
    }
}

