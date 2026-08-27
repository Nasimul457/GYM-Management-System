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
    public partial class ViewMembers : Form
    {

        public ViewMembers()
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

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainFrom = new MainForm();
            mainFrom.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_By_Name()
        {
            con.Open();
            string query = "select * from MemberTbl where MName = '" + SearchTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MembersDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search_By_Name();
            SearchTb.Text = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Populate();
            SearchTb.Text = "";
        }
    }
}
