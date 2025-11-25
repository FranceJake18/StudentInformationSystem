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

            if (string.IsNullOrWhiteSpace(Username))
            {
                UsenameLabel.Text = "The Username is Empty";
            } 
            if (string.IsNullOrWhiteSpace(Password))
            {
                PasswordLabel.Text = "The Password is Empty";
            }
            if (string.IsNullOrWhiteSpace(CPassword))
            {
                NotedPassswordError.Text = "The Confirm password is Empty";
            } 
            if (string.IsNullOrWhiteSpace(FName))
            {
                FNameLabel.Text = "The First Name is Empty";
            } 
            if (string.IsNullOrWhiteSpace(LName))
            {
                LNameLabel.Text = "The Last Name is Empty";
            }
           

            if (Username.Length > 0 && Password.Length > 0 && CPassword.Length > 0 && FName.Length > 0 && LName.Length > 0)
            {
               
                if (Password.Length >= 8 && Password.Length < 16)
                    {

                    if (Password == CPassword)
                    {

                        String connectionSQL = "data source=192.168.1.5\\MSSQLSERVER,1433; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
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

                                string log = "SELECT COUNT (*) FROM Registered_Accounts WHERE Username=@Username";
                                using (SqlCommand command = new SqlCommand(log, connection))
                                {
                                    command.Parameters.AddWithValue("@Username", Username);
                                    
                                    int res = (int)command.ExecuteScalar();

                                    if (res == 0)
                                    {
                                        if (result > 0)
                                        {
                                            MessageBox.Show("Account Created");
                                        }
                                    }
                                    else if (res > 0)
                                    {
                                            MessageBox.Show("Account exist create new one");
                                        
                                    }

                                }

                            }

                        }
                    }
                    else if (Password != CPassword)
                    {
                        NotedPassswordError.Text = "Password does not match";
                    }
                }
                else
                {
                    PasswordLabel.Text = "Password must consist of 8-16 letters";
                }


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

        private void CreateAccountPage_Load(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsenameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
