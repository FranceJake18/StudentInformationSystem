using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class EditAdminAccount : Form

    {
        public string User_name { get; set; }
        public EditAdminAccount()
        {
            InitializeComponent();
        }
        public void LoadEditAccData(string usn, string pass, string firstN, string lastN, string middN)
        {
            User_name = usn;
            Password.Text = pass;
            FirstN.Text = firstN;
            LastN.Text = lastN;
            MidN.Text = middN;
    
        }
        private void EditAdminAccount_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try{
                if (string.IsNullOrWhiteSpace(FirstN.Text))
                {
                    FName.Text = "Invalid Input";
                }
                if (string.IsNullOrWhiteSpace(LastN.Text))
                {
                    LName.Text = "Invalid Input";
                }


                if (string.IsNullOrWhiteSpace(Username.Text))
                {
                    UserN.Text = "Invalid Input";
                }
                if (string.IsNullOrWhiteSpace(Password.Text))
                {
                    PassW.Text = "Invalid Input";
                }

                else
                {
                    using (SqlConnection conn = new SqlConnection("data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;"))
                    {
                        conn.Open();
                        string query = "UPDATE Registered_Accounts SET Password = @Pass, First_Name=@FN, Last_Name=@LN, Middle_Name = @MN  WHERE Username=@ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {


                            cmd.Parameters.AddWithValue("@FN", FirstN.Text);
                            cmd.Parameters.AddWithValue("@LN", LastN.Text);
                            cmd.Parameters.AddWithValue("@MN", MidN.Text);

                            cmd.Parameters.AddWithValue("@Pass", Password.Text);
                            cmd.Parameters.AddWithValue("@ID", User_name);


                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                string queryID = @"UPDATE Registered_Accounts SET Username=@UN WHERE First_Name =@FN AND Last_Name = @LN";

                                if (string.IsNullOrWhiteSpace(UserN.Text))
                                {
                                    using (SqlCommand command = new SqlCommand(queryID, conn))
                                    {
                                        command.Parameters.AddWithValue("@UN", User_name);
                                        command.Parameters.AddWithValue("@FN", FirstN.Text);
                                        command.Parameters.AddWithValue("@LN", LastN.Text);
                                        command.ExecuteNonQuery();
                                    }

                                }
                                else
                                {

                                    using (SqlCommand command = new SqlCommand(queryID, conn))
                                    {
                                        command.Parameters.AddWithValue("@UN", UserN.Text);
                                        command.Parameters.AddWithValue("@FN", FirstN.Text);
                                        command.Parameters.AddWithValue("@LN", LastN.Text);
                                        command.ExecuteNonQuery();
                                    }
                                }


                                MessageBox.Show("Student data updated and Student ID refreshed!");
                            }
                            else
                            {
                                MessageBox.Show("Name update failed, Student ID not changed.");
                            }
                        }

                    }
                    MessageBox.Show("Record updated successfully!");
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Input. Try Again.");
            }
        }
    }
}