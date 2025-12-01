using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdateProfile;

namespace StudentInformationSystem
{
    public partial class AnnouncementsPage : Form
    {
        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        public AnnouncementsPage()
        {
            InitializeComponent();

    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this, new Point(1130, 63));
        }

        private void AnnouncementsPage_Load(object sender, EventArgs e)
        {
            RefreshListBoxes();
            var repo = new LoadData(connectionSQL);
            System.Drawing.Image Updated = repo.LoadProfileImage(LoginUserRecord.UName);
            pictureBox1.Image = Updated;
        }
        private void LoadListBox(ListBox listBox, string filePath)
        {
            if (File.Exists(filePath))
            {
                listBox.Items.Clear();
                string[] lines = File.ReadAllLines(filePath);
                listBox.Items.AddRange(lines);
            }
            else
            {
                MessageBox.Show("No File Found");
            }
        }
        public void RefreshListBoxes()
        {
            LoadListBox(listBox1, @"C:\Users\Christopher\Desktop\file1.txt");
            LoadListBox(listBox2, @"C:\Users\Christopher\Desktop\file2.txt");
            LoadListBox(listBox3, @"C:\Users\Christopher\Desktop\file3.txt");
            LoadListBox(listBox4, @"C:\Users\Christopher\Desktop\file4.txt");
        }


        private void StudInfo_Click(object sender, EventArgs e)
        {
            StudInfoPage studInfoPage = new StudInfoPage();
            studInfoPage.StartPosition = FormStartPosition.CenterScreen;
            studInfoPage.Location = this.Location;
            studInfoPage.ShowDialog();
            this.Hide();
        }

        private void CreateA_Click(object sender, EventArgs e)
        {
            AddAnnouncement addAnnouncement = new AddAnnouncement();
            addAnnouncement.ShowDialog();
        }

        private void EditA_Click(object sender, EventArgs e)
        {
            EditAnnouncement edit = new EditAnnouncement();
            edit.ShowDialog();
        }

        private void View_Profile_Click(object sender, EventArgs e)
        {
            View_Profile view = new View_Profile();
            view.ShowDialog();
        }

        private void Grades_Click(object sender, EventArgs e)
        {
            GradesPage studInfoPage = new GradesPage();
            studInfoPage.StartPosition = FormStartPosition.CenterScreen;
            studInfoPage.Location = this.Location;
            this.Hide();
            studInfoPage.ShowDialog();
            
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            AttendancePage studInfoPage = new AttendancePage();
            studInfoPage.StartPosition = FormStartPosition.CenterScreen;
            studInfoPage.Location = this.Location;
            this.Hide();
            studInfoPage.ShowDialog();
            
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            this.Hide(); ;
            login.ShowDialog();
        }

        private void StudinfoSystem_Click(object sender, EventArgs e)
        {
            LandingPage Land = new LandingPage();
            Land.StartPosition = FormStartPosition.CenterScreen;
            Land.Location = this.Location;
            this.Hide();
            Land.ShowDialog();
            
        }

        private void AnnouncementsPage_Activated(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }
    }
}


