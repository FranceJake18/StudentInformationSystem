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

namespace StudentInformationSystem
{
    public partial class StudInfoPage : Form
    {
        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        public StudInfoPage()
        {
            InitializeComponent();
            loaddata();
            
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
    }
}

