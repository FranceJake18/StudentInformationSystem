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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentInformationSystem
{
    public partial class View_Profile : Form
    {
        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        public View_Profile()
        {
            InitializeComponent();
            loadprofile();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void loadprofile()
        {
            using (SqlConnection conn = new SqlConnection(connectionSQL))
            {
                conn.Open();
                string query = "SELECT Username, First_Name, Last_Name, Middle_Name, Profile_Image FROM Registered_Accounts WHERE Username=@Username;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", LoginUserRecord.UName);
                    SqlDataReader result = command.ExecuteReader();

                    if (result.Read())
                        {
                        UserN.Text = result["Username"].ToString();
                        FirstN.Text = result["First_Name"].ToString();
                        LastN.Text = result["Last_Name"].ToString();
                        MiddleN.Text = result["Middle_Name"].ToString();
                        
                        if (result["Profile_Image"] != DBNull.Value)
                        {


                            byte[] img = (byte[])result["Profile_Image"];
                            using (MemoryStream ms = new MemoryStream(img))
                            {
                                ImageB.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            ImageB.Image = Properties.Resources.free_user_icon_3296_thumb;
                        }

                    }
                    
                }
            }
        }
        private void View_Profile_Load(object sender, EventArgs e)
        {
            
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile(this);
            this.Hide();
            edit.Show();
        }
    }
}
