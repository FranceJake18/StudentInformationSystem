using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
    }
}
