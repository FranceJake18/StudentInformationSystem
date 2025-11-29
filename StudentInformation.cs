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
            using (SqlConnection conn = new SqlConnection(connectionSQL))
            {
                conn.Open();
                string query = "SELECT Profile_Image FROM Registered_Accounts WHERE Username=@Username;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", LoginUserRecord.UName);
                    SqlDataReader result = command.ExecuteReader();

                    if (result.Read())

                        if (result["Profile_Image"] != DBNull.Value)
                        {
                            byte[] img = (byte[])result["Profile_Image"];
                            using (MemoryStream ms = new MemoryStream(img))
                            {
                                Pic.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                        else if (result["Profile_Image"] == DBNull.Value)
                        {
                            Pic.Image = Properties.Resources.free_user_icon_3296_thumb;

                        }
                }
            }
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
            add.Show();
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

        private void StudInfo_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileMenu.Hide();
            this.Close();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Profile view = new View_Profile();
            view.Show();
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
            GP.Show();
            this.Close();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            AttendancePage GP = new AttendancePage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            GP.Show();
            this.Close();
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            AnnouncementsPage GP = new AnnouncementsPage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            GP.Show();
            this.Close();
        }
    }
}

