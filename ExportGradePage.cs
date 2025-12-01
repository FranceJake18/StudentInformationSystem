using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class ExportGradePage : Form
    {
        private readonly string connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";

        public event EventHandler GradeSaved;

        public ExportGradePage()
        {
            InitializeComponent();
            Savebtn.Click += Savebtn_Click;
            Cancelbtn.Click += (s, e) => Close();
        }

        private void StudNum_Click(object sender, EventArgs e)
        {
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string studentNumber = StudNumGrade.Text.Trim();
            string studentName = NameOfStud.Text.Trim();
            string gradeText = GradeOfStud.Text.Trim();
            string subject = SubjectCB.Text.Trim();
            string section = ProgramOfStud.Text.Trim();

            if (!ValidateInputs(studentNumber, studentName, gradeText, subject, section, out decimal gradeValue, out string validationError))
            {
                MessageBox.Show(validationError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionSQL))
                {
                    string query = @"INSERT INTO StudentGradesTable (StudentNumber, StudentName, Grade, Subject, Section)
                                     VALUES (@StudentNumber, @StudentName, @Grade, @Subject, @Section)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        sqlCommand.Parameters.AddWithValue("@StudentName", studentName);
                        sqlCommand.Parameters.AddWithValue("@Grade", gradeValue);
                        sqlCommand.Parameters.AddWithValue("@Subject", subject);
                        sqlCommand.Parameters.AddWithValue("@Section", section);

                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                GradeSaved?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Grade saved successfully.", "Student Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save grade. {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool ValidateInputs(string number, string name, string grade, string subject, string section, out decimal gradeValue, out string error)
        {
            gradeValue = 0;
            if (string.IsNullOrWhiteSpace(number))
            {
                error = "Student number is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                error = "Student name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(grade) || !decimal.TryParse(grade, NumberStyles.Any, CultureInfo.InvariantCulture, out gradeValue))
            {
                error = "Grade must be a numeric value.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(subject))
            {
                error = "Subject is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(section))
            {
                error = "Section/Program is required.";
                return false;
            }

            error = string.Empty;
            return true;
        }

        private void ExportGradePage_Load(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
