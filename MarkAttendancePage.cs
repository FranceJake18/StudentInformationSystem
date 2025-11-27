using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class MarkAttendancePage : Form
    {
        private readonly string connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";

        public event EventHandler AttendanceSaved;

        public MarkAttendancePage()
        {
            InitializeComponent();
            Savebtn.Click += Savebtn_Click;
            Cancelbtn.Click += (s, e) => Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string studentNumber = StudNumGrade.Text.Trim();
            string studentName = NameOfStud.Text.Trim();
            string presentValue = Present.Text.Trim();
            DateTime attendanceDate = DateAttendance.Value.Date;
            string subject = SubjectAttendance.Text.Trim();

            if (!ValidateInputs(studentNumber, studentName, presentValue, subject, out string validationError))
            {
                MessageBox.Show(validationError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionSQL))
                {
                    const string query = @"INSERT INTO StudentsAttendanceTable (StudentNumber, StudentName, Present, AttendanceDate, Subject)
                                           VALUES (@StudentNumber, @StudentName, @Present, @AttendanceDate, @Subject)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        sqlCommand.Parameters.AddWithValue("@StudentName", studentName);
                        sqlCommand.Parameters.AddWithValue("@Present", presentValue);
                        sqlCommand.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                        sqlCommand.Parameters.AddWithValue("@Subject", subject);

                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                AttendanceSaved?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Attendance saved successfully.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save attendance. {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool ValidateInputs(string studentNumber, string studentName, string present, string subject, out string error)
        {
            if (string.IsNullOrWhiteSpace(studentNumber))
            {
                error = "Student number is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(studentName))
            {
                error = "Student name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(present))
            {
                error = "Please select if the student is present.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(subject))
            {
                error = "Subject is required.";
                return false;
            }

            error = string.Empty;
            return true;
        }
    }
}
