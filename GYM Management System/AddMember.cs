using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
namespace GYM_Management_System
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "" || cmbTrainer.Text == "" || HeightTb.Text == "" || WeightTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    string query = "insert into MemberTbl(MName, MPhone, MGen, MAge, MAmount, MTiming, TrainerId, MHeight, MWeight) values('" + NameTb.Text + "','" + PhoneTb.Text + "','" + GenderCB.Text + "','" + AgeTb.Text + "','" + AmountTb.Text + "','" + TimingCB.Text + "','" + cmbTrainer.SelectedValue + "','" + HeightTb.Text + "','" + WeightTb.Text + "')"; 
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    Reset_All_TextBoxs();
                    con.Close();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
        }


        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset_All_TextBoxs();
        }

        private void Reset_All_TextBoxs()
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            HeightTb.Text = ""; 
            WeightTb.Text = ""; 
            GenderCB.SelectedIndex = -1;
            TimingCB.SelectedIndex = -1;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm("Admin", "");
            main.Show();
            this.Hide();
        }

        private void FillTrainer()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                string query = "SELECT * FROM TrainerTbl";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("TrainerName", typeof(string));
                dt.Load(rdr);

              
                cmbTrainer.ValueMember = "TrainerId"; 
                cmbTrainer.DisplayMember = "TrainerName";
                cmbTrainer.DataSource = dt;
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void AddMember_Load_1(object sender, EventArgs e)
        {
            FillTrainer();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
