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
using System.Xml.Linq;

namespace StudentInformationSystem
{
    public partial class AddAcccountAdmin : Form
    {
        AddAccInfo main;
        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        public AddAcccountAdmin(AddAccInfo form)
        {
            InitializeComponent();
            main = form;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddAcccountAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string FN = FirstN.Text;
            string LN = LastN.Text;
            string MN = MidN.Text;
            string UN = Username.Text;
            string PW = Password.Text;


            if (string.IsNullOrWhiteSpace(FirstN.Text))
            {
                FName.Text = "First Name cannot be Empty";
            }
            if (string.IsNullOrWhiteSpace(LastN.Text))
            {
                LName.Text = "Last Name cannot be Empty";
            }
            if (string.IsNullOrWhiteSpace(UN))
            {
                UserN.Text = "Username cannot be Empty";
            }
            if (string.IsNullOrWhiteSpace(PW))
            {
                PassW.Text = "Password cannot be Empty";
            }



            else
            {

                using (SqlConnection con = new SqlConnection(connectionSQL))
                {
                    con.Open();
                    string AddAcc = @"INSERT INTO Registered_Accounts(Username, Password, First_Name, Last_Name, Middle_Name) VALUES (@Username, @Password, @FName, @LName, @MName)";
                    using (SqlCommand cmd = new SqlCommand(AddAcc, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", UN);
                        cmd.Parameters.AddWithValue("@Password", PW);
                        cmd.Parameters.AddWithValue("@FName", FN);
                        cmd.Parameters.AddWithValue("@LName", LN);
                        cmd.Parameters.AddWithValue("@MName", MN);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Student Information Created");
                            main.loaddata();

                        }
                        else if (result == 0)
                        {
                            MessageBox.Show("Error, Try Again.");

                        }
                    }
                }

            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

