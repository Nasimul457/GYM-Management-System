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
    public partial class WorkoutDietForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public string loggedInTrainer = "";

        public WorkoutDietForm(string trainerName)
        {
            InitializeComponent();
            loggedInTrainer = trainerName;
        }

        private void FillMemberName()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "";
                SqlCommand cmd;


                if (loggedInTrainer != "" && loggedInTrainer != "Admin")
                {
                    query = "SELECT M.MName FROM MemberTbl M INNER JOIN TrainerTbl T ON M.TrainerId = T.TrainerId WHERE T.TrainerName = @TName";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TName", loggedInTrainer);
                }
                else
                {

                    query = "SELECT MName FROM MemberTbl";
                    cmd = new SqlCommand(query, con);
                }

                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);

                MemberCB.ValueMember = "MName";
                MemberCB.DisplayMember = "MName";
                MemberCB.DataSource = dt;
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

        public WorkoutDietForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void WorkoutDietForm_Load(object sender, EventArgs e)
        {
            FillMemberName();
            DisplayPlan();
        }

        //private void FillMemberName()
        //{
        //    try
        //    {
        //        con.Open();
        //        string query = "SELECT * FROM MemberTbl";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("MName", typeof(string));
        //        dt.Load(rdr);
        //        MemberCB.ValueMember = "MName";
        //        MemberCB.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (con.State == ConnectionState.Open) con.Close();
        //    }
        //}

        //private void DisplayPlan()
        //{
        //    try
        //    {
        //        con.Open();
        //        string query = "SELECT * FROM WorkoutDietTbl";
        //        SqlDataAdapter sda = new SqlDataAdapter(query, con);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (con.State == ConnectionState.Open) con.Close();
        //    }
        //}

        private void Clear()
        {
            MemberCB.SelectedIndex = -1;
            WorkoutTb.Text = "";
            DietTb.Text = "";
            DateTb.Text = "";
            key = 0; 
        }

        private void DisplayPlan()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "";
                SqlCommand cmd;


                if (loggedInTrainer != "" && loggedInTrainer != "Admin")
                {
                    query = "SELECT W.PlanId, M.MName AS MemberName, W.WorkoutRoutine, W.DietPlan, W.PlanDate FROM WorkoutDietTbl W INNER JOIN MemberTbl M ON W.MemberName = M.MName INNER JOIN TrainerTbl T ON M.TrainerId = T.TrainerId WHERE T.TrainerName = @TName";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TName", loggedInTrainer);
                }
                else
                {

                    query = "SELECT * FROM WorkoutDietTbl";
                    cmd = new SqlCommand(query, con);
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                dataGridView1.DataSource = dt;
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (MemberCB.Text == "" || WorkoutTb.Text == "" || DietTb.Text == "" || DateTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string query = "INSERT INTO WorkoutDietTbl (MemberName, WorkoutRoutine, DietPlan, PlanDate) VALUES (@MName, @WRoutine, @DPlan, @PDate)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MName", MemberCB.SelectedValue?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@WRoutine", WorkoutTb.Text);
                    cmd.Parameters.AddWithValue("@DPlan", DietTb.Text);
                    cmd.Parameters.AddWithValue("@PDate", DateTb.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Workout & Diet Plan Added Successfully!");
                    DisplayPlan();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm("Trainer", loggedInTrainer);
            main.Show();
            this.Hide();
        }


        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                MemberCB.Text = row.Cells["MemberName"].Value?.ToString();
                WorkoutTb.Text = row.Cells["WorkoutRoutine"].Value?.ToString();
                DietTb.Text = row.Cells["DietPlan"].Value?.ToString();
                DateTb.Text = row.Cells["PlanDate"].Value?.ToString();

                if (row.Cells["PlanId"].Value != null)
                {
                    key = Convert.ToInt32(row.Cells["PlanId"].Value?.ToString());
                }
                else
                {
                    key = 0;
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (MemberCB.Text == "" || WorkoutTb.Text == "" || DietTb.Text == "" || DateTb.Text == "")
            {
                MessageBox.Show("Select The Plan To Be Updated!");
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }


                    string query = "UPDATE WorkoutDietTbl SET MemberName = @MName, WorkoutRoutine = @WRoutine, DietPlan = @DPlan, PlanDate = @PDate WHERE PlanId = @PKey";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MName", MemberCB.Text);
                    cmd.Parameters.AddWithValue("@WRoutine", WorkoutTb.Text);
                    cmd.Parameters.AddWithValue("@DPlan", DietTb.Text);
                    cmd.Parameters.AddWithValue("@PDate", DateTb.Text);
                    cmd.Parameters.AddWithValue("@PKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Workout & Diet Plan Updated Successfully!");

                    DisplayPlan();
                    Clear();
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
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Plan To Be Deleted!");
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string query = "DELETE FROM WorkoutDietTbl WHERE PlanId = @PKey";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Workout & Diet Plan Deleted Successfully!");

                    DisplayPlan();
                    Clear();

                   
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
        }
    }
}

        
    


