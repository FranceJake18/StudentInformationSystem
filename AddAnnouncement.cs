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

namespace StudentInformationSystem
{
    public partial class AddAnnouncement : Form
    {
        public AddAnnouncement()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string newText = Input.Text.Trim();
            if (!string.IsNullOrEmpty(newText) && AnnouncementCB.SelectedItem != null)
            {
                string selectedKey = AnnouncementCB.SelectedItem.ToString();
                string baseFolder = @"C:\Users\Christopher\Desktop";
                string filePath = Path.Combine(baseFolder, FindFile[selectedKey]);
                string _ifExist = File.ReadAllText(filePath);

                    if (!string.IsNullOrWhiteSpace(_ifExist))
                    {
                        File.WriteAllText(filePath, string.Empty);
                    }

                File.AppendAllText(filePath, newText + Environment.NewLine);
                MessageBox.Show($"Text added to {selectedKey}!");
                    
               
                var mainForm = (AnnouncementsPage)Application.OpenForms["AnnouncementsPage"];
                mainForm?.RefreshListBoxes();
                mainForm.Refresh();
            }
            else
            {
                MessageBox.Show("No input found.");
            }
        }
        private Dictionary<string, string> FindFile = new Dictionary<string, string>
        {
        { "Announcements 1", "file1.txt" },
        { "Announcements 2", "file2.txt" },
        { "Announcements 3", "file3.txt" },
        { "Announcements 4", "file4.txt" }
        };

        private void Delete_Click(object sender, EventArgs e)
        {
            if (AnnouncementCB.SelectedItem != null)
            {
                string selectedKey = AnnouncementCB.SelectedItem.ToString();
                string baseFolder = @"C:\Users\Christopher\Desktop";
                string filePath = Path.Combine(baseFolder, FindFile[selectedKey]);
               
                File.WriteAllText(filePath, string.Empty);

                var mainForm = (AnnouncementsPage)Application.OpenForms["AnnouncementsPage"];
                mainForm?.RefreshListBoxes();

                MessageBox.Show($"Text in {selectedKey} has been deleted.");
            }
            else
            {
                MessageBox.Show("No Announcement found. Please select in the box the Announcement to Delete");
            }
        }

        private void AddAnnouncement_Load(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
       