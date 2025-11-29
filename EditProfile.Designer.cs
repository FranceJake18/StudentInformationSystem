namespace StudentInformationSystem
{
    partial class EditProfile
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
            this.label5 = new System.Windows.Forms.Label();
            this.UserN = new System.Windows.Forms.TextBox();
            this.FirstN = new System.Windows.Forms.TextBox();
            this.LastN = new System.Windows.Forms.TextBox();
            this.MidN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Imageb = new System.Windows.Forms.PictureBox();
            this.ChangePhoto = new System.Windows.Forms.Button();
            this.FileDiaolog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imageb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.StudinfoSystem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 58);
            this.panel1.TabIndex = 2;
            // 
            // StudinfoSystem
            // 
            this.StudinfoSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudinfoSystem.AutoSize = true;
            this.StudinfoSystem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudinfoSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.StudinfoSystem.Location = new System.Drawing.Point(13, 21);
            this.StudinfoSystem.Name = "StudinfoSystem";
            this.StudinfoSystem.Size = new System.Drawing.Size(221, 19);
            this.StudinfoSystem.TabIndex = 1;
            this.StudinfoSystem.Text = "Student Information System";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label5.Location = new System.Drawing.Point(284, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "EDIT PROFILE";
            // 
            // UserN
            // 
            this.UserN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.UserN.Location = new System.Drawing.Point(66, 165);
            this.UserN.Name = "UserN";
            this.UserN.Size = new System.Drawing.Size(363, 26);
            this.UserN.TabIndex = 16;
            this.UserN.TextChanged += new System.EventHandler(this.FirstN_TextChanged);
            // 
            // FirstN
            // 
            this.FirstN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.FirstN.Location = new System.Drawing.Point(66, 218);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(363, 26);
            this.FirstN.TabIndex = 17;
            // 
            // LastN
            // 
            this.LastN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.LastN.Location = new System.Drawing.Point(66, 272);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(363, 26);
            this.LastN.TabIndex = 18;
            // 
            // MidN
            // 
            this.MidN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MidN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.MidN.Location = new System.Drawing.Point(66, 324);
            this.MidN.Name = "MidN";
            this.MidN.Size = new System.Drawing.Size(363, 26);
            this.MidN.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(62, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "First name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(62, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(62, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Middle name:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(62, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Username:";
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savebtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.Savebtn.Location = new System.Drawing.Point(66, 359);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(119, 32);
            this.Savebtn.TabIndex = 28;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancelbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.Cancelbtn.Location = new System.Drawing.Point(310, 356);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(119, 32);
            this.Cancelbtn.TabIndex = 29;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            // 
            // Imageb
            // 
            this.Imageb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Imageb.Location = new System.Drawing.Point(487, 165);
            this.Imageb.Name = "Imageb";
            this.Imageb.Size = new System.Drawing.Size(210, 185);
            this.Imageb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imageb.TabIndex = 26;
            this.Imageb.TabStop = false;
            this.Imageb.Click += new System.EventHandler(this.Imageb_Click);
            // 
            // ChangePhoto
            // 
            this.ChangePhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangePhoto.BackColor = System.Drawing.Color.LavenderBlush;
            this.ChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePhoto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.ChangePhoto.Location = new System.Drawing.Point(521, 356);
            this.ChangePhoto.Name = "ChangePhoto";
            this.ChangePhoto.Size = new System.Drawing.Size(146, 28);
            this.ChangePhoto.TabIndex = 27;
            this.ChangePhoto.Text = "Change Photo";
            this.ChangePhoto.UseVisualStyleBackColor = false;
            this.ChangePhoto.Click += new System.EventHandler(this.ChangePhoto_Click);
            // 
            // FileDiaolog
            // 
            this.FileDiaolog.FileName = "openFileDialog1";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 509);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.ChangePhoto);
            this.Controls.Add(this.Imageb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MidN);
            this.Controls.Add(this.LastN);
            this.Controls.Add(this.FirstN);
            this.Controls.Add(this.UserN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "EditProfile";
            this.Text = "-";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imageb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StudinfoSystem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserN;
        private System.Windows.Forms.TextBox FirstN;
        private System.Windows.Forms.TextBox LastN;
        private System.Windows.Forms.TextBox MidN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Imageb;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button ChangePhoto;
        private System.Windows.Forms.OpenFileDialog FileDiaolog;
    }
}