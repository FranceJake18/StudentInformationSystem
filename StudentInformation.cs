using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdateProfile;
using static System.Net.Mime.MediaTypeNames;

namespace StudentInformationSystem
{
    public partial class StudInfoPage : Form
    {

        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        public StudInfoPage()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataStudInfo.CurrentRow == null)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            int Studnum = Convert.ToInt32(dataStudInfo.CurrentRow.Cells["Student_ID"].Value);

            DialogResult confirm = MessageBox.Show("Delete this record?",
                                                   "Confirm",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                delete(Studnum);
                dataStudInfo.Rows.Remove(dataStudInfo.CurrentRow);
            }
        }

        private void delete(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionSQL))
            {
                con.Open();
                string query = "DELETE FROM StudentInfo_Table WHERE Student_ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StudInfoPage_Load(object sender, EventArgs e)
        {
            loaddata();
            var repo = new LoadData(connectionSQL);
            System.Drawing.Image Updated = repo.LoadProfileImage(LoginUserRecord.UName);
            Pic.Image = Updated;
        }
        private void StudInfoPage_Activated(object sender, EventArgs e)
        {
            var repo = new LoadData(connectionSQL);
            Pic.Image = repo.LoadProfileImage(LoginUserRecord.UName);
        }



        public void loaddata()
        {


            using (SqlConnection sqlconnect = new SqlConnection(connectionSQL))
            {
                sqlconnect.Open();

                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM StudentInfo_Table", sqlconnect);
                DataTable dataTable = new DataTable();
                sql.Fill(dataTable);
                dataStudInfo.DataSource = dataTable;
                dataStudInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataStudInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataStudInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }
        private void AddStudInfo_Click(object sender, EventArgs e)
        {
            ProgramError add = new ProgramError(this);
            add.ShowDialog();
        }

        private void SearchStudTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchStudInfo_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionSQL))
            {
                con.Open();
                string query = "SELECT * FROM StudentInfo_Table WHERE Student_ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(SearchStudTextBox.Text));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataStudInfo.DataSource = dt;
                }
            }
        }


        private void SearchStudInfo_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionSQL))
                {
                    con.Open();
                    string query = "SELECT * FROM StudentInfo_Table WHERE Student_ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(SearchStudTextBox.Text));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataStudInfo.DataSource = dt;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Input. Try Again.");
            }
           
        }

        private void StudInfo_Click(object sender, EventArgs e)
        {
            loaddata();

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            this.Hide(); ;
            login.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Profile view = new View_Profile();
            view.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ProfileMenu.Show(this, new Point(1130, 63));
        }

        private void ProfileMenu_Opening(object sender, CancelEventArgs e)
        {

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
            AttendancePage GP = new AttendancePage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            this.Hide();
            GP.ShowDialog();
            
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            AnnouncementsPage GP = new AnnouncementsPage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            this.Hide();
            GP.ShowDialog();
            
        }

        private void StudinfoSystem_Click(object sender, EventArgs e)
        {
            LandingPage Land = new LandingPage();
            Land.StartPosition = FormStartPosition.CenterScreen;
            Land.Location = this.Location;
            this.Hide();
            Land.ShowDialog();
            
        }
        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName]?.Value?.ToString() ?? string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataStudInfo.SelectedRows.Count > 0)
                {

                    DataGridViewRow row = dataStudInfo.SelectedRows[0];


                    EdiitStudentAccounts Edit = new EdiitStudentAccounts();
                    Edit.LoadEditData(
                    Convert.ToInt32(row.Cells["Student_ID"].Value),
                    row.Cells["First_Name"].Value?.ToString(),
                    row.Cells["Last_Name"].Value?.ToString(),
                    row.Cells["Middle_Name"].Value?.ToString(),
                    Convert.ToInt32(row.Cells["Age"].Value),
                    Convert.ToDateTime(row.Cells["Date_of_Birth"].Value),
                    row.Cells["Gender"].Value?.ToString(),
                    row.Cells["Program"].Value?.ToString()
    );
                    Edit.StartPosition = FormStartPosition.CenterScreen;
                    Edit.Location = this.Location;
                    Edit.ShowDialog();

                    loaddata();
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Input. Try Again.");
            }
        }
    }
}

