using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UpdateProfile;

namespace StudentInformationSystem
{
    public partial class AttendancePage : Form
    {
        private readonly string connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";

        public AttendancePage()
        {
            InitializeComponent();
            Load += AttendancePage_Load;
            SearchAttendance.Click += SearchAttendance_Click;
            markAttendance.Click += MarkAttendance_Click;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            dataAttendance.AutoGenerateColumns = true;
            dataAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAttendance.ReadOnly = true;
            dataAttendance.AllowUserToAddRows = false;
        }

        private void AttendancePage_Load(object sender, EventArgs e)
        {
            LoadAttendance();

            var repo = new LoadData(connectionSQL);
            System.Drawing.Image Updated = repo.LoadProfileImage(LoginUserRecord.UName);
            pictureBox1.Image = Updated;
        }

        private void SearchAttendance_Click(object sender, EventArgs e)
        {
            LoadAttendance(SearchStudTextBox.Text, dateTimePicker1.Value.Date);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendance(SearchStudTextBox.Text, dateTimePicker1.Value.Date);
        }

        private void MarkAttendance_Click(object sender, EventArgs e)
        {
            using (var markForm = new MarkAttendancePage())
            {
                markForm.AttendanceSaved += (_, __) => LoadAttendance(SearchStudTextBox.Text, dateTimePicker1.Value.Date);
                markForm.ShowDialog(this);
            }
        }

        private void LoadAttendance(string searchTerm = "", DateTime? dateFilter = null)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionSQL))
                {
                    string query = "SELECT StudentNumber, StudentName, Subject, Present, AttendanceDate FROM StudentsAttendanceTable";

                    bool hasSearch = !string.IsNullOrWhiteSpace(searchTerm);
                    bool hasDate = dateFilter.HasValue;

                    if (hasSearch || hasDate)
                    {
                        query += " WHERE";
                        if (hasSearch)
                        {
                            query += " (StudentNumber LIKE @Search OR StudentName LIKE @Search)";
                        }

                        if (hasDate)
                        {
                            if (hasSearch)
                            {
                                query += " AND";
                            }

                            query += " CAST(AttendanceDate AS DATE) = @DateFilter";
                        }
                    }

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        if (hasSearch)
                        {
                            command.Parameters.AddWithValue("@Search", $"%{searchTerm}%");
                        }

                        if (hasDate)
                        {
                            command.Parameters.AddWithValue("@DateFilter", dateFilter.Value.Date);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable attendanceTable = new DataTable();
                        adapter.Fill(attendanceTable);
                        dataAttendance.DataSource = attendanceTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load attendance. {ex.Message}", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudInfo_Click(object sender, EventArgs e)
        {
            StudInfoPage GP = new StudInfoPage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            this.Hide();
            GP.ShowDialog();
            
        }

        private void Grades_Click(object sender, EventArgs e)
        {
            GradesPage GP = new GradesPage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            this.Hide();
            GP.ShowDialog();
            
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            LoadAttendance();

        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            AnnouncementsPage GP = new AnnouncementsPage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            this.Hide();
            GP.ShowDialog();
            
        }

        private void markAttendance_Click_1(object sender, EventArgs e)
        {
            MarkAttendancePage GP = new MarkAttendancePage();
            GP.ShowDialog();
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Profile view = new View_Profile();
            view.ShowDialog();
            
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            this.Hide(); ;
            login.ShowDialog();

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this, new Point(1130, 63));
        }

        private void AttendancePage_Load_1(object sender, EventArgs e)
        {

        }

        private void StudinfoSystem_Click(object sender, EventArgs e)
        {
            LandingPage Land = new LandingPage();
            Land.StartPosition = FormStartPosition.CenterScreen;
            Land.Location = this.Location;
            this.Hide();
            Land.ShowDialog();
            
        }
    }
}
