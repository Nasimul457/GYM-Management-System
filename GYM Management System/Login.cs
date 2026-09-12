using Microsoft.Data.SqlClient;

namespace GYM_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UsernameTb.Text = "";
            PasswordTb.Text = "";
            
        }

        

       

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            
            if (UsernameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please enter Username and Password!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PKE8D82\SQLEXPRESS02;Initial Catalog=GYMDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                    con.Open();

                    string loggedInUser = UsernameTb.Text.Trim();
                    string password = PasswordTb.Text;

                   
                    string memberQuery = "SELECT COUNT(*) FROM MemberTbl WHERE MName = @UName AND MPassword = @UPass";
                    SqlCommand memberCmd = new SqlCommand(memberQuery, con);
                    memberCmd.Parameters.AddWithValue("@UName", loggedInUser);
                    memberCmd.Parameters.AddWithValue("@UPass", password);

                    int memberCount = (int)memberCmd.ExecuteScalar();

                    if (memberCount > 0)
                    {
                        
                        string selectedRole = "User";
                        MainForm main = new MainForm(selectedRole, loggedInUser);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                      
                        string userQuery = "SELECT Role FROM UserTbl WHERE Username = @UName AND Password = @UPass";
                        SqlCommand userCmd = new SqlCommand(userQuery, con);
                        userCmd.Parameters.AddWithValue("@UName", loggedInUser);
                        userCmd.Parameters.AddWithValue("@UPass", password);

                        object roleResult = userCmd.ExecuteScalar();

                        if (roleResult != null)
                        {
                            string selectedRole = roleResult.ToString() ?? "";
                            MainForm main = new MainForm(selectedRole, loggedInUser);
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            
                            MessageBox.Show("Wrong Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ForgottenPasswordBtn_Click(object sender, EventArgs e)
        {
            Change_PasswordForm cpForm = new Change_PasswordForm();
            cpForm.Show();
            this.Hide();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();

          
            regForm.Show();

            
            this.Hide(); 
        }

        
    }
}
        
    

