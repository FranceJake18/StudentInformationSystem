namespace StudentInformationSystem
{
    partial class AttendancePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudinfoSystem = new System.Windows.Forms.Label();
            this.Announcements = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Attendance = new System.Windows.Forms.Button();
            this.StudInfo = new System.Windows.Forms.Button();
            this.Grades = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataAttendance = new System.Windows.Forms.DataGridView();
            this.SearchStudTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchAttendance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAttendance = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.StudinfoSystem);
            this.panel1.Controls.Add(this.Announcements);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Attendance);
            this.panel1.Controls.Add(this.StudInfo);
            this.panel1.Controls.Add(this.Grades);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 61);
            this.panel1.TabIndex = 8;
            // 
            // StudinfoSystem
            // 
            this.StudinfoSystem.AutoSize = true;
            this.StudinfoSystem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudinfoSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.StudinfoSystem.Location = new System.Drawing.Point(12, 21);
            this.StudinfoSystem.Name = "StudinfoSystem";
            this.StudinfoSystem.Size = new System.Drawing.Size(221, 19);
            this.StudinfoSystem.TabIndex = 3;
            this.StudinfoSystem.Text = "Student Information System";
            // 
            // Announcements
            // 
            this.Announcements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Announcements.BackColor = System.Drawing.Color.LavenderBlush;
            this.Announcements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Announcements.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Announcements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.Announcements.Location = new System.Drawing.Point(1008, 14);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(194, 35);
            this.Announcements.TabIndex = 8;
            this.Announcements.Text = "Announcements";
            this.Announcements.UseVisualStyleBackColor = false;
            this.Announcements.Click += new System.EventHandler(this.Announcements_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1213, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Attendance
            // 
            this.Attendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Attendance.BackColor = System.Drawing.Color.LavenderBlush;
            this.Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attendance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.Attendance.Location = new System.Drawing.Point(808, 14);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(194, 35);
            this.Attendance.TabIndex = 7;
            this.Attendance.Text = "Attendance";
            this.Attendance.UseVisualStyleBackColor = false;
            this.Attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // StudInfo
            // 
            this.StudInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.StudInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.StudInfo.Location = new System.Drawing.Point(408, 14);
            this.StudInfo.Name = "StudInfo";
            this.StudInfo.Size = new System.Drawing.Size(194, 35);
            this.StudInfo.TabIndex = 5;
            this.StudInfo.Text = "Student Info";
            this.StudInfo.UseVisualStyleBackColor = false;
            this.StudInfo.Click += new System.EventHandler(this.StudInfo_Click);
            // 
            // Grades
            // 
            this.Grades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grades.BackColor = System.Drawing.Color.LavenderBlush;
            this.Grades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grades.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.Grades.Location = new System.Drawing.Point(608, 14);
            this.Grades.Name = "Grades";
            this.Grades.Size = new System.Drawing.Size(194, 35);
            this.Grades.TabIndex = 6;
            this.Grades.Text = "Grades";
            this.Grades.UseVisualStyleBackColor = false;
            this.Grades.Click += new System.EventHandler(this.Grades_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 621);
            this.panel2.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Lavender;
            this.panel6.Location = new System.Drawing.Point(0, 490);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 38);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lavender;
            this.panel5.Location = new System.Drawing.Point(0, 558);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 38);
            this.panel5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 38);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 38);
            this.panel3.TabIndex = 12;
            // 
            // dataAttendance
            // 
            this.dataAttendance.BackgroundColor = System.Drawing.Color.Snow;
            this.dataAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAttendance.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataAttendance.Location = new System.Drawing.Point(212, 171);
            this.dataAttendance.Name = "dataAttendance";
            this.dataAttendance.Size = new System.Drawing.Size(1040, 498);
            this.dataAttendance.TabIndex = 10;
            // 
            // SearchStudTextBox
            // 
            this.SearchStudTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchStudTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.SearchStudTextBox.Location = new System.Drawing.Point(863, 134);
            this.SearchStudTextBox.Multiline = true;
            this.SearchStudTextBox.Name = "SearchStudTextBox";
            this.SearchStudTextBox.Size = new System.Drawing.Size(264, 31);
            this.SearchStudTextBox.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::StudentInformationSystem.Properties.Resources.pngtree_vector_search_icon_png_image_320926;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1088, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // SearchAttendance
            // 
            this.SearchAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchAttendance.BackColor = System.Drawing.Color.LavenderBlush;
            this.SearchAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchAttendance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.SearchAttendance.Location = new System.Drawing.Point(1133, 133);
            this.SearchAttendance.Name = "SearchAttendance";
            this.SearchAttendance.Size = new System.Drawing.Size(119, 32);
            this.SearchAttendance.TabIndex = 17;
            this.SearchAttendance.Text = "Search";
            this.SearchAttendance.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(206, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Attendance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editProfileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "View Profile";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editProfileToolStripMenuItem.Text = "Logout";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // markAttendance
            // 
            this.markAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.markAttendance.BackColor = System.Drawing.Color.LavenderBlush;
            this.markAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markAttendance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.markAttendance.Location = new System.Drawing.Point(685, 134);
            this.markAttendance.Name = "markAttendance";
            this.markAttendance.Size = new System.Drawing.Size(172, 32);
            this.markAttendance.TabIndex = 20;
            this.markAttendance.Text = "Mark Attendance";
            this.markAttendance.UseVisualStyleBackColor = false;
            this.markAttendance.Click += new System.EventHandler(this.markAttendance_Click_1);
            // 
            // AttendancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.markAttendance);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchAttendance);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchStudTextBox);
            this.Controls.Add(this.dataAttendance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AttendancePage";
            this.Text = "AttendancePage";
            this.Load += new System.EventHandler(this.AttendancePage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StudinfoSystem;
        private System.Windows.Forms.Button Announcements;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Attendance;
        private System.Windows.Forms.Button StudInfo;
        private System.Windows.Forms.Button Grades;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataAttendance;
        private System.Windows.Forms.TextBox SearchStudTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SearchAttendance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.Button markAttendance;
    }
}