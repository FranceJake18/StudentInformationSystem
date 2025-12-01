namespace StudentInformationSystem
{
    partial class ExportGradePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudinfoSystem = new System.Windows.Forms.Label();
            this.StudNumGrade = new System.Windows.Forms.TextBox();
            this.NameOfStud = new System.Windows.Forms.TextBox();
            this.GradeOfStud = new System.Windows.Forms.TextBox();
            this.SubjectCB = new System.Windows.Forms.ComboBox();
            this.ProgramOfStud = new System.Windows.Forms.ComboBox();
            this.StudNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.StudinfoSystem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 50);
            this.panel1.TabIndex = 2;
            // 
            // StudinfoSystem
            // 
            this.StudinfoSystem.AutoSize = true;
            this.StudinfoSystem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudinfoSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.StudinfoSystem.Location = new System.Drawing.Point(3, 17);
            this.StudinfoSystem.Name = "StudinfoSystem";
            this.StudinfoSystem.Size = new System.Drawing.Size(221, 19);
            this.StudinfoSystem.TabIndex = 1;
            this.StudinfoSystem.Text = "Student Information System";
            // 
            // StudNumGrade
            // 
            this.StudNumGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudNumGrade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudNumGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.StudNumGrade.Location = new System.Drawing.Point(12, 149);
            this.StudNumGrade.Multiline = true;
            this.StudNumGrade.Name = "StudNumGrade";
            this.StudNumGrade.Size = new System.Drawing.Size(432, 31);
            this.StudNumGrade.TabIndex = 12;
            // 
            // NameOfStud
            // 
            this.NameOfStud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameOfStud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfStud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.NameOfStud.Location = new System.Drawing.Point(12, 205);
            this.NameOfStud.Multiline = true;
            this.NameOfStud.Name = "NameOfStud";
            this.NameOfStud.Size = new System.Drawing.Size(432, 31);
            this.NameOfStud.TabIndex = 13;
            // 
            // GradeOfStud
            // 
            this.GradeOfStud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GradeOfStud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeOfStud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.GradeOfStud.Location = new System.Drawing.Point(12, 261);
            this.GradeOfStud.Multiline = true;
            this.GradeOfStud.Name = "GradeOfStud";
            this.GradeOfStud.Size = new System.Drawing.Size(432, 31);
            this.GradeOfStud.TabIndex = 14;
            // 
            // SubjectCB
            // 
            this.SubjectCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubjectCB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCB.FormattingEnabled = true;
            this.SubjectCB.Items.AddRange(new object[] {
            "Event-Driven Programming",
            "Advance Database Systems"});
            this.SubjectCB.Location = new System.Drawing.Point(12, 317);
            this.SubjectCB.Name = "SubjectCB";
            this.SubjectCB.Size = new System.Drawing.Size(432, 30);
            this.SubjectCB.TabIndex = 21;
            // 
            // ProgramOfStud
            // 
            this.ProgramOfStud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgramOfStud.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramOfStud.FormattingEnabled = true;
            this.ProgramOfStud.Items.AddRange(new object[] {
            "BS Information Technology",
            "BS Computer Science",
            "BS Hospitality Management"});
            this.ProgramOfStud.Location = new System.Drawing.Point(12, 372);
            this.ProgramOfStud.Name = "ProgramOfStud";
            this.ProgramOfStud.Size = new System.Drawing.Size(432, 30);
            this.ProgramOfStud.TabIndex = 22;
            // 
            // StudNum
            // 
            this.StudNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudNum.AutoSize = true;
            this.StudNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.StudNum.Location = new System.Drawing.Point(8, 127);
            this.StudNum.Name = "StudNum";
            this.StudNum.Size = new System.Drawing.Size(101, 19);
            this.StudNum.TabIndex = 23;
            this.StudNum.Text = "Student No:";
            this.StudNum.Click += new System.EventHandler(this.StudNum_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(8, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name(Last name, First name, Middle name):";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(8, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Grade:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(8, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(8, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Program:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label5.Location = new System.Drawing.Point(126, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Student Grade";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancelbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.Cancelbtn.Location = new System.Drawing.Point(105, 419);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(119, 32);
            this.Cancelbtn.TabIndex = 42;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savebtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.Savebtn.Location = new System.Drawing.Point(229, 419);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(119, 32);
            this.Savebtn.TabIndex = 43;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            // 
            // ExportGradePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 473);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudNum);
            this.Controls.Add(this.ProgramOfStud);
            this.Controls.Add(this.SubjectCB);
            this.Controls.Add(this.GradeOfStud);
            this.Controls.Add(this.NameOfStud);
            this.Controls.Add(this.StudNumGrade);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ExportGradePage";
            this.Text = "ExportGradePage";
            this.Load += new System.EventHandler(this.ExportGradePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StudinfoSystem;
        private System.Windows.Forms.TextBox StudNumGrade;
        private System.Windows.Forms.TextBox NameOfStud;
        private System.Windows.Forms.TextBox GradeOfStud;
        private System.Windows.Forms.ComboBox SubjectCB;
        private System.Windows.Forms.ComboBox ProgramOfStud;
        private System.Windows.Forms.Label StudNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Savebtn;
    }
}