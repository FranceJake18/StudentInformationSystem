using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentInformationSystem
{
    public partial class CreateAccountPage : Form
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void SignInCreate_Click(object sender, EventArgs e)
        {
            string Username = UserNameCreate.Text;
            string Password = PasswordCreate.Text;
            string CPassword = ConfirmPassword.Text;
            string FName = FirstNCreateAcc.Text;
            string LName = LastNCreateAcc.Text;
            string MName = MiddleNCreateAcc.Text;

            if (Password == CPassword)
            {
                String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionSQL))
                {
                    connection.Open();
                    string AddAcc = @"INSERT INTO Registered_Accounts(Username, Password, First_Name, Last_Name, Middle_Name) VALUES (@Username, @Password, @FName, @LName, @MName)";
                    using (SqlCommand cmd = new SqlCommand(AddAcc, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@FName", FName);
                        cmd.Parameters.AddWithValue("@LName", LName);
                        cmd.Parameters.AddWithValue("@MName", MName);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Account Created");
                        }
                    }
                   
                }


            }
            else if (Password != FName)
            {
                NotedPassswordError.Text = "Password does not match";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            loginPage show = new loginPage();
            this.Hide();
            show.Show();
        }
    }
}
