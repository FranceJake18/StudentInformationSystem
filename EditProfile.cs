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
using System.Xml.Linq;
using UpdateProfile;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentInformationSystem
{
    public partial class EditProfile : Form
    {

        View_Profile ViewL;
        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        private bool imageChanged = false;
        public EditProfile(View_Profile a)
        {
            InitializeComponent();
            ViewL = a;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionSQL))
            {
                conn.Open();
                string query = "SELECT Profile_Image FROM Registered_Accounts WHERE Username=@Username;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", LoginUserRecord.UName);
                    SqlDataReader result = command.ExecuteReader();

                    if (result.Read())
                    {
                        if (result["Profile_Image"] == DBNull.Value)
                        {
                            Imageb.Image = Properties.Resources.free_user_icon_3296_thumb;
                        }
                        else
                        {
                            byte[] img = (byte[])result["Profile_Image"];
                            using (MemoryStream ms = new MemoryStream(img))
                                Imageb.Image = System.Drawing.Image.FromStream(ms);
                        }

                    }

                }
            }
        }

        private void FirstN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionSQL))
                {
                    conn.Open();
                    StringBuilder queryBuilder = new StringBuilder("UPDATE Registered_Accounts SET ");
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(UserN.Text))
                    {
                        queryBuilder.Append("Username = @UN, ");
                        parameters.Add(new SqlParameter("@UN", UserN.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(FirstN.Text))
                    {
                        queryBuilder.Append("First_Name = @FN, ");
                        parameters.Add(new SqlParameter("@FN", FirstN.Text)); ;
                    }
                    if (!string.IsNullOrWhiteSpace(LastN.Text))
                    {
                        queryBuilder.Append("Last_Name = @LN, ");
                        parameters.Add(new SqlParameter("@LN", LastN.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(MidN.Text))
                    {
                        queryBuilder.Append("Middle_Name = @MN, ");
                        parameters.Add(new SqlParameter("@MN", MidN.Text));
                    }

                    if (imageChanged)
                    {
                        queryBuilder.Append("Profile_Image = @PI ");
                        byte[] imgData = ImageToByteArray(Imageb.Image);
                        parameters.Add(new SqlParameter("@PI", imgData));
                    }

                    queryBuilder.Append("WHERE Username = @Username;");
                    parameters.Add(new SqlParameter("@Username", LoginUserRecord.UName));



                    string log = "SELECT COUNT (*) FROM Registered_Accounts WHERE Username=@Username";
                    using (SqlCommand command = new SqlCommand(log, conn))
                    {
                        command.Parameters.AddWithValue("@Username", UserN.Text);

                        int res = (int)command.ExecuteScalar();

                        if (res == 0)
                        {
                            using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn))
                            {
                                cmd.Parameters.AddRange(parameters.ToArray());
                                int result = cmd.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Your profile is Updated");

                                    if (!string.IsNullOrWhiteSpace(UserN.Text))
                                    {
                                        LoginUserRecord.UName = UserN.Text;
                                    }



                                    var repo = new LoadData(connectionSQL);
                                    System.Drawing.Image updatedImage = repo.LoadProfileImage(LoginUserRecord.UName);

                                    ViewL.loadprofile();


                                }
                                else
                                {
                                    MessageBox.Show("Update failed.");
                                }
                            }
                        }
                        else if (res > 0)
                        {
                            MessageBox.Show("Username exist create new one");

                        }
                    }
                    conn.Close();
                }
            }


            catch (System.ArgumentException)
            {
                MessageBox.Show("Error Input. Try Again.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No Image Selected. Try Again.");
            }
            
        }

        private void ChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files| *.jpg; *.png; *bmp;";

            if (op.ShowDialog() == DialogResult.OK) 
            {
                Imageb.Image = System.Drawing.Image.FromFile(op.FileName);
                imageChanged = true;
            }
        }
        private byte[] ImageToByteArray(System.Drawing.Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void Imageb_Click(object sender, EventArgs e)
        {

        }

        private void EditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            LandingPage LAND = new LandingPage();
            LAND.StartPosition = FormStartPosition.CenterScreen;
            LAND.Location = this.Location;
            this.Hide();
            LAND.ShowDialog();
        }

        private void EditProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            LandingPage LAND = new LandingPage();
            LAND.StartPosition = FormStartPosition.CenterScreen;
            LAND.Location = this.Location;
            this.Hide();
            LAND.ShowDialog();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            LandingPage LAND = new LandingPage();
            LAND.StartPosition = FormStartPosition.CenterScreen;
            LAND.Location = this.Location;
            this.Hide();
            LAND.ShowDialog();
        }
    }
}