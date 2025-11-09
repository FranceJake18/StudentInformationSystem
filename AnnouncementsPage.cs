using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class AnnouncementsPage : Form
    {
        public AnnouncementsPage()
        {
            InitializeComponent();

            string[] announcements = {
        "Upcoming Midterm Exam",
        "Date & Time: November 18, 2025, 8:00 AM",
        "Content: The Midterm Exam for Science will be held on Tuesday, November 18 in the main hall."
    };

            listBox1.Items.Clear();
            foreach (string announcement in announcements)
            {
                listBox1.Items.Add(announcement);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = listBox1.SelectedItem.ToString();
        }

    }
}

