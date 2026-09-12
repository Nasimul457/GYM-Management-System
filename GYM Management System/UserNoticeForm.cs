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
    public partial class UserNoticeForm : Form
    {

        //public  string user = "";
        string currentUsername = "";
        public UserNoticeForm()
        {
            InitializeComponent();
        }
        public UserNoticeForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserNoticeForm_Load(object sender, EventArgs e)
        {
            LoadNotices();
        }

        private void LoadNotices()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                string query = "SELECT NoticeTitle, NoticeDetails, NoticeDate FROM NoticeTbl";
                SqlCommand cmd = new SqlCommand(query, con);
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
            MainForm main = new MainForm("User", currentUsername);
            main.Show();
            this.Hide();
        }
    }
}
