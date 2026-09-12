using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace GYM_Management_System
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void Populate()
        {
            con.Open();
            string query = "SELECT M.Mid, M.MName, M.MPhone, M.MGen, M.MAge, M.MAmount, M.MTiming, T.TrainerName, M.MHeight, M.MWeight FROM MemberTbl M LEFT JOIN TrainerTbl T ON M.TrainerId = T.TrainerId";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MembersDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void FillTrainer()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM TrainerTbl";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("TrainerName", typeof(string));
                dt.Load(rdr);

                TrainerCB.ValueMember = "TrainerId";
                TrainerCB.DisplayMember = "TrainerName";
                TrainerCB.DataSource = dt;
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            Populate();
            FillTrainer();
        }

        

        int key = 0;


        private void MembersDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MembersDGV.Rows[e.RowIndex];

                key = Convert.ToInt32(row.Cells[0].Value?.ToString());

                NameTb.Text = row.Cells[1].Value?.ToString();
                PhoneTb.Text = row.Cells[2].Value?.ToString();
                GenderCB.Text = row.Cells[3].Value?.ToString();
                AgeTb.Text = row.Cells[4].Value?.ToString();
               
                AmountTb.Text = row.Cells[5].Value?.ToString();
                TimingCB.Text = row.Cells[6].Value?.ToString();
                TrainerCB.Text = row.Cells[7].Value?.ToString();
                HeightTb.Text = row.Cells[8].Value?.ToString();
                WeightTb.Text = row.Cells[9].Value?.ToString();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm("Admin", "");
            main.Show();
            this.Hide();
        }

        private void Reset_All_TextBoxes()
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            TimingCB.Text = "";
            GenderCB.Text = "";
            HeightTb.Text = "";
            WeightTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset_All_TextBoxes();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Member to be deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from MemberTbl where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Deleted Successfully");
                    con.Close();
                    Populate();
                    Reset_All_TextBoxes();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMemberBtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || GenderCB.Text == "" || AgeTb.Text == "" || AmountTb.Text == "" || TimingCB.Text == "" || TrainerCB.Text == "" || HeightTb.Text == "" || WeightTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update MemberTbl set MName='" + NameTb.Text + "', MPhone='" + PhoneTb.Text + "', MGen='" + GenderCB.Text + "', MAge='" + AgeTb.Text + "', MAmount='" + AmountTb.Text + "', MTiming='" + TimingCB.Text + "', TrainerId='" + TrainerCB.SelectedValue + "', MHeight='" + HeightTb.Text + "', MWeight='" + WeightTb.Text + "' where MId=" + key + ";"; SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Updated Successfully");
                    con.Close();
                    Populate();
                    Reset_All_TextBoxes();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

       
    }
}
