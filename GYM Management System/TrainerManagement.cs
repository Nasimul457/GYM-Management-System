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
    public partial class TrainerManagement : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");



        public TrainerManagement()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTrainerName.Text == "" || txtPhone.Text == "" || txtAge.Text == "" || txtExperience.Text == "" || txtSalary.Text == "" || cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


                    con.Open();


                    string query = "INSERT INTO TrainerTbl (TrainerName, TrainerPhone, TrainerGender, TrainerAge, TrainerExperience, TrainerSalary) VALUES (@TName, @TPhone, @TGen, @TAge, @TExp, @TSal)";
                    SqlCommand cmd = new SqlCommand(query, con);


                    cmd.Parameters.AddWithValue("@TName", txtTrainerName.Text);
                    cmd.Parameters.AddWithValue("@TPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@TGen", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAge", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@TExp", txtExperience.Text);
                    cmd.Parameters.AddWithValue("@TSal", Convert.ToDecimal(txtSalary.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trainer Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    DisplayTrainer();
                    Clear();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        public void DisplayTrainer()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                string query = "SELECT * FROM TrainerTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);


                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void TrainerManagement_Load(object sender, EventArgs e)
        {
            DisplayTrainer();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

        }


        int key = 0;
        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                txtTrainerName.Text = row.Cells[1].Value?.ToString();
                txtPhone.Text = row.Cells[2].Value?.ToString();
                cmbGender.SelectedItem = row.Cells[3].Value?.ToString();
                txtAge.Text = row.Cells[4].Value?.ToString();
                txtExperience.Text = row.Cells[5].Value?.ToString();
                txtSalary.Text = row.Cells[6].Value?.ToString();


                if (txtTrainerName.Text == "")
                {
                    key = 0;
                }
                else
                {

                    key = Convert.ToInt32(row.Cells[0].Value?.ToString());
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please Select a Trainer to Update!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtTrainerName.Text == "" || txtPhone.Text == "" || txtAge.Text == "" || txtExperience.Text == "" || txtSalary.Text == "" || cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                    con.Open();


                    string query = "UPDATE TrainerTbl SET TrainerName = @TName, TrainerPhone = @TPhone, TrainerGender = @TGen, TrainerAge = @TAge, TrainerExperience = @TExp, TrainerSalary = @TSal WHERE TrainerId = @TKey";
                    SqlCommand cmd = new SqlCommand(query, con);


                    cmd.Parameters.AddWithValue("@TName", txtTrainerName.Text);
                    cmd.Parameters.AddWithValue("@TPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@TGen", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAge", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@TExp", txtExperience.Text);
                    cmd.Parameters.AddWithValue("@TSal", Convert.ToDecimal(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@TKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trainer Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();


                    DisplayTrainer();
                    Clear();
                    key = 0;


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        public void Clear()
        {
            txtTrainerName.Text = "";
            txtPhone.Text = "";
            cmbGender.SelectedIndex = -1;
            txtAge.Text = "";
            txtExperience.Text = "";
            txtSalary.Text = "";
            key = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please Select a Trainer to Delete!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                    con.Open();


                    string query = "DELETE FROM TrainerTbl WHERE TrainerId = @TKey";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trainer Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();


                    DisplayTrainer();
                    Clear();
                    key = 0;


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm("Admin", "");
            main.Show();
            this.Hide();
        }
    }
}

