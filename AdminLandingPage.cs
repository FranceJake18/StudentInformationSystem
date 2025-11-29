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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentInformationSystem
{
    public partial class AddAccInfo : Form
    {
        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        public AddAccInfo()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            using (SqlConnection sqlconnect = new SqlConnection(connectionSQL))
            {
                sqlconnect.Open();

                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM Registered_Accounts", sqlconnect);
                DataTable dataTable = new DataTable();
                sql.Fill(dataTable);
                dataAccinfo.DataSource = dataTable;
                dataAccinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataAccinfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataAccinfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddAccInfo_Load(object sender, EventArgs e)
        {
            AddAcccountAdmin ad = new AddAcccountAdmin(this);
            ad.Show();
        }

        private void Accounts_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void DeleteAccInfo_Click(object sender, EventArgs e)
        {
            if (dataAccinfo.CurrentRow == null)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            string US = dataAccinfo.CurrentRow.Cells["Username"].Value.ToString();

            DialogResult confirm = MessageBox.Show("Delete this record?",
                                                   "Confirm",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                del(US);
                dataAccinfo.Rows.Remove(dataAccinfo.CurrentRow);
            }
        }
        public void del(string StudUS)
        {
            using (SqlConnection con = new SqlConnection(connectionSQL))
            {
                con.Open();
                string query = "DELETE FROM Registered_Acounts WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", StudUS);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SearchAccInfo_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionSQL))
            {
                con.Open();
                string query = "SELECT * FROM StudentInfo_Table WHERE Student_ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(SearchAccTextBox.Text));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataAccinfo.DataSource = dt;
                }
            }
        }
    }
    }
