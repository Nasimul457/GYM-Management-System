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
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MembersDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            Populate();
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
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
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
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || GenderCB.Text == "" || AgeTb.Text == "" || AmountTb.Text == "" || TimingCB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update MemberTbl set MName='" + NameTb.Text + "', MPhone='" + PhoneTb.Text + "', MGen='" + GenderCB.Text + "', MAge='" + AgeTb.Text + "', MAmount='" + AmountTb.Text + "', MTiming='" + TimingCB.Text + "' where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
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
