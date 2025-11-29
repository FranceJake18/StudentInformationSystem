using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UpdateProfile;

namespace StudentInformationSystem
{
    public partial class GradesPage : Form
    {
        private readonly string connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";

        public GradesPage()
        {
            InitializeComponent();
            Load += GradesPage_Load;
            SearchGrade.Click += SearchGrade_Click;
            ExportGrade.Click += ExportGrade_Click;
            dataGrades.AutoGenerateColumns = true;
            dataGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrades.ReadOnly = true;
            dataGrades.AllowUserToAddRows = false;
        }

        private void GradesPage_Load(object sender, EventArgs e)
        {
            LoadGrades();
            var repo = new LoadData(connectionSQL);
            System.Drawing.Image Updated = repo.LoadProfileImage(LoginUserRecord.UName);
            pictureBox1.Image = Updated;

        }

        private void SearchGrade_Click(object sender, EventArgs e)
        {
            LoadGrades(SearchStudTextBox.Text);
        }

        private void ExportGrade_Click(object sender, EventArgs e)
        {
            using (var exportForm = new ExportGradePage())
            {
                exportForm.GradeSaved += (_, __) => LoadGrades(SearchStudTextBox.Text);
                exportForm.ShowDialog(this);
            }
        }

        private void LoadGrades(string searchTerm = "")
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionSQL))
                {
                    string query = "SELECT StudentNumber, StudentName, Subject, Section, Grade FROM StudentGradesTable";
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += " WHERE StudentNumber LIKE @Search OR StudentName LIKE @Search";
                    }

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        if (!string.IsNullOrWhiteSpace(searchTerm))
                        {
                            command.Parameters.AddWithValue("@Search", $"%{searchTerm}%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGrades.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load grades. {ex.Message}", "Grades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GradesPage_Load_1(object sender, EventArgs e)
        {

        }

        private void Grades_Click(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void StudInfo_Click(object sender, EventArgs e)
        {
            StudInfoPage GP = new StudInfoPage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            GP.ShowDialog();
            this.Close();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            AttendancePage GP = new AttendancePage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            GP.ShowDialog();
            this.Close();
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            AnnouncementsPage GP = new AnnouncementsPage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            GP.ShowDialog();
            this.Close();
        }

        private void ExportGrade_Click_1(object sender, EventArgs e)
        {
            ExportGradePage EGP = new ExportGradePage();
            EGP.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this, new Point(1130, 63));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Profile view = new View_Profile();
            view.ShowDialog();
            this.Close();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
            this.Close();
        }

        private void StudinfoSystem_Click(object sender, EventArgs e)
        {
            LandingPage Land = new LandingPage();
            Land.StartPosition = FormStartPosition.CenterScreen;
            Land.Location = this.Location;
            Land.ShowDialog();
            this.Close();
        }
    }
}
