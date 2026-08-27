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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void FillName()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select MName from MemberTbl", con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("MName", typeof(string));
                dt.Load(rdr);
                NameCB.ValueMember = "MName";
                NameCB.DataSource = dt;
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Search_By_Name()
        {
            con.Open();
            string query = "select * from PaymentTbl where PMember = '" + SearchTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Populate()
        {
            con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            con.Close();
        }



        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            Populate();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset_AllBoxes();
        }
        private void Reset_AllBoxes()
        {
            NameCB.Text = "";
            AmountTb.Text = "";
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            if (NameCB.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string paymentPeriod = PaymentDate.Value.Month.ToString() + PaymentDate.Value.Year.ToString();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTbl where PMember='" + NameCB.SelectedValue?.ToString() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid for this Month");
                }
                else
                {
                    string query = "insert into PaymentTbl values('" + paymentPeriod + "', '" + NameCB.SelectedValue?.ToString() + "', " + AmountTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");
                }

                con.Close();
                Populate();
                Reset_AllBoxes();
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Search_By_Name();
            SearchTb.Text = "";
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            Populate();
            SearchTb.Text = "";
        }
    }
}
