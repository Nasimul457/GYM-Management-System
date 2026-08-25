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

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void UpdateMemberBtn_Click(object sender, EventArgs e)
        {

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
                TimingCB.Text = row.Cells[5].Value?.ToString();
                AmountTb.Text = row.Cells[6].Value?.ToString();
            }
        }
    }
}
