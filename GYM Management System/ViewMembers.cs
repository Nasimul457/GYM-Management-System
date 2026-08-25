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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GymConn"].ConnectionString);

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
    }
}
