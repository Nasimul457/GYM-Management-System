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
    public partial class AdminNotice : Form
    {
        public AdminNotice()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void btnPostNotice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
        string.IsNullOrWhiteSpace(txtDetails.Text) ||
        txtTitle.Text == "Notice Title" ||
        txtDetails.Text == "Notice Details")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = "INSERT INTO NoticeTbl (NoticeTitle, NoticeDetails, NoticeDate) VALUES (@Title, @Details, @Date)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Details", txtDetails.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Notice Posted Successfully!");

                    this.Refresh();
                    txtTitle.Text = "";
                    txtDetails.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm("Trainer", "");
            main.Show();
            this.Hide();
        }

        private void btnDeleteNotice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the fields?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtTitle.Text = "";
                txtDetails.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}

