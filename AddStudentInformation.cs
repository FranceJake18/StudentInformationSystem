using Microsoft.SqlServer.Server;
using StudentInformationSystem;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace StudentInformationSystem
{
    public partial class ProgramError : Form
    {

        StudInfoPage main;
        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        public ProgramError(StudInfoPage stud)
        {
            InitializeComponent();
            main = stud; 
        }

        private void AddStudentInformation_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string FN = FirstN.Text;
            string LN = LastN.Text;
            string MN = MidN.Text;
            string Program = ProgramCB.Text;
            string Gender = GenderCB.Text;
            DateTime Birth = BirthDTP.Value.Date;

            try
            {
                if (string.IsNullOrWhiteSpace(FirstN.Text))
                {
                    FirstName.Text = "First Name cannot be Empty";
                }
                if (string.IsNullOrWhiteSpace(LastN.Text))
                {
                    LastName.Text = "Last Name cannot be Empty";
                }
                if (string.IsNullOrWhiteSpace(StudNum.Text))
                {
                    StudentNoError.Text = "Student Number cannot be Empty";
                }
                if (string.IsNullOrWhiteSpace(ProgramCB.Text))
                {
                    ProgramE.Text = "Program cannot be Empty";
                }
                if (string.IsNullOrWhiteSpace(GenderCB.Text))
                {
                    GenderError.Text = "Gender cannot be Empty";
                }
                if (string.IsNullOrWhiteSpace(AgeB.Text))
                {
                    AgeError.Text = "Age cannot be Empty";
                }


                else
                {
                    int StudentNo = Convert.ToInt32(StudNum.Text);
                    int age = Convert.ToInt32(AgeB.Text);
                    using (SqlConnection con = new SqlConnection(connectionSQL))
                    {
                        con.Open();
                        string query = "INSERT INTO StudentInfo_Table (Student_ID, First_Name, Last_Name, Middle_Name, Age, Date_of_Birth, Gender, Program) VALUES  (@StudentNo, @FN, @LN, @MN, @Age, @Birth, @Gender, @Program); ";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@StudentNo", StudentNo);
                            cmd.Parameters.AddWithValue("@FN", FN);
                            cmd.Parameters.AddWithValue("@LN", LN);
                            cmd.Parameters.AddWithValue("@MN", MN);
                            cmd.Parameters.AddWithValue("@Age", age);
                            cmd.Parameters.AddWithValue("@Birth", Birth);
                            cmd.Parameters.AddWithValue("@Gender", Gender);
                            cmd.Parameters.AddWithValue("@Program", Program);

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Student Information Created");
                                main.loaddata();

                            }
                            else if (result == 0)
                            {
                                MessageBox.Show("Error");

                            }
                        }
                    }
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Wrong Input. Try Again.");
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}