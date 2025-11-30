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
    public partial class EdiitStudentAccounts : Form
    {

        public string Student_ID { get; set; }
        public EdiitStudentAccounts()
        {
            InitializeComponent();
        }

        public void LoadEditData(int id, string firstN, string lastN, string middN, int age, DateTime birthday, string gender, string program)
        {
            Student_ID = id.ToString();
            FirstN.Text = firstN;
            LastN.Text = lastN;
            MidN.Text = middN;
            AgeB.Text = age.ToString();
            BirthDTP.Value = birthday;
            GenderCB.Text = gender;
            ProgramCB.Text = program;
        }
        private void EdiitStudentAccounts_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

     
            if (string.IsNullOrWhiteSpace(FirstN.Text))
            {
                FirstName.Text = "Invalid Input";
            }
            if (string.IsNullOrWhiteSpace(LastN.Text))
            {
                LastName.Text = "Invalid Input";
            }
    

                if (string.IsNullOrWhiteSpace(ProgramCB.Text))
                {
                    ProgramE.Text = "Invalid Input";
                }
                if (string.IsNullOrWhiteSpace(GenderCB.Text))
                {
                    GenderError.Text = "Invalid Input";
                }
                if (string.IsNullOrWhiteSpace(AgeB.Text))
                {
                    AgeError.Text = "Invalid Input";
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection("data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;"))
                    {
                        conn.Open();
                        string query = "UPDATE StudentInfo_Table SET First_Name=@FN, Last_Name=@LN, Middle_Name = @MN,  Age = @Age, Date_of_Birth = @DTP, Gender = @Gender, Program= @PB  WHERE Student_ID=@ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {

                        
                            cmd.Parameters.AddWithValue("@FN", FirstN.Text);
                            cmd.Parameters.AddWithValue("@LN", LastN.Text);
                            cmd.Parameters.AddWithValue("@MN", MidN.Text);
                            cmd.Parameters.AddWithValue("@Age", int.Parse(AgeB.Text));
                            cmd.Parameters.AddWithValue("@DTP", BirthDTP.Value.Date);
                            cmd.Parameters.AddWithValue("@Gender", GenderCB.Text);
                            cmd.Parameters.AddWithValue("@PB", ProgramCB.Text);
                            cmd.Parameters.AddWithValue("@ID", Student_ID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                string queryID = @"UPDATE StudentInfo_Table SET Student_ID=@SID  WHERE First_Name =@FN AND Last_Name = @LN";

                                if (string.IsNullOrWhiteSpace(StudNum.Text))
                                {
                                    using (SqlCommand command = new SqlCommand(queryID, conn))
                                    {
                                        command.Parameters.AddWithValue("@SID", Student_ID);
                                        command.Parameters.AddWithValue("@FN", FirstN.Text);
                                        command.Parameters.AddWithValue("@LN", LastN.Text);
                                        command.ExecuteNonQuery();
                                    }

                                }
                                else
                                {

                                    using (SqlCommand command = new SqlCommand(queryID, conn))
                                    {
                                        command.Parameters.AddWithValue("@SID", StudNum.Text);
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
                    this.Close();
                }

            }
        }
    }

