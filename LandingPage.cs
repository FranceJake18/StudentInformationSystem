using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdateProfile;

namespace StudentInformationSystem
{
    public partial class LandingPage : Form
    {
        String connectionSQL = "data source=DESKTOP-HHPGTHF; initial catalog=StudentInformation; User ID = sa; Password = EmbateChris;";
        public LandingPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this, new Point(1130, 63));
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            var repo = new LoadData(connectionSQL);
            System.Drawing.Image Updated = repo.LoadProfileImage(LoginUserRecord.UName);
            pictureBox1.Image = Updated;
        }

        private void StudInfo_Click(object sender, EventArgs e)
        {
            StudInfoPage GP = new StudInfoPage();
            GP.StartPosition = FormStartPosition.CenterScreen;
            GP.Location = this.Location;
            GP.ShowDialog();
            this.Close();
        }

        private void Grades_Click(object sender, EventArgs e)
        {
            GradesPage GP = new GradesPage();
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
    }
}
