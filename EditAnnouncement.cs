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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StudentInformationSystem
{
    public partial class EditAnnouncement : Form
    {
        public EditAnnouncement()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AnnouncementCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKey = AnnouncementCB.SelectedItem.ToString();
            string baseFolder = @"C:\Users\Christopher\Desktop";
            string filePath = Path.Combine(baseFolder, FindFile[selectedKey]);

            if (File.Exists(filePath))
            {
                Input.Text = File.ReadAllText(filePath); // show file content in TextBox
            }
            else
            {
                MessageBox.Show("No Text Exist.");
            }

        }
        private Dictionary<string, string> FindFile = new Dictionary<string, string>
        {
        { "Announcements 1", "file1.txt" },
        { "Announcements 2", "file2.txt" },
        { "Announcements 3", "file3.txt" },
        { "Announcements 4", "file4.txt" }
        };

        private void EditAnnouncement_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Input.Text) && AnnouncementCB.SelectedItem != null)
            {
                string selectedKey = AnnouncementCB.SelectedItem.ToString();
                string baseFolder = @"C:\Users\Christopher\Desktop";
                string filePath = Path.Combine(baseFolder, FindFile[selectedKey]);


                File.WriteAllText(filePath, Input.Text);

                MessageBox.Show($"{selectedKey} updated successfully!");
                var mainForm = (AnnouncementsPage)Application.OpenForms["AnnouncementsPage"];
                mainForm?.RefreshListBoxes();
                mainForm.RefreshListBoxes();
            }
            else
            {
                MessageBox.Show("The input is empty, try again.");
            }

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
