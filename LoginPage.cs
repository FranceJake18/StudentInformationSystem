using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            


        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            PasswordtextBox.UseSystemPasswordChar = true;
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.MaxLength = 20;
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountPage cap = new CreateAccountPage();
            this.Hide();
            cap.Show();
        }

        private void ForgotPass_Click(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            string Password = PasswordtextBox.Text;
            string Username = UserNametextBox.Text;
           
            String connectionSQL = "data source=192.168.1.5\\MSSQLSERVER,1433; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
            using (SqlConnection connection = new SqlConnection(connectionSQL))
            {
                connection.Open();

                string log = "SELECT COUNT (*) FROM Registered_Accounts WHERE Username=@Username AND Password=@Password";
            using (SqlCommand command = new SqlCommand(log, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        StudInfoPage landing = new StudInfoPage();
                        this.Hide();
                        landing.Show();
                    }
                    else
                    {
                        ErrorMessage.Text = "Username and Password is incorrect";
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CreateAccc_Click(object sender, EventArgs e)
        {

        }
    }
}
