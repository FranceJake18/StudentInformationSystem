namespace StudentInformationSystem
{
    partial class CreateAccountPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameCreate = new System.Windows.Forms.TextBox();
            this.PasswordCreate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.SignInCreate = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNCreateAcc = new System.Windows.Forms.TextBox();
            this.LastNCreateAcc = new System.Windows.Forms.TextBox();
            this.MiddleNCreateAcc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NotedPassswordError = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsenameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.MNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 58);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Information System";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(208, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserNameCreate
            // 
            this.UserNameCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserNameCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.UserNameCreate.Location = new System.Drawing.Point(212, 162);
            this.UserNameCreate.Name = "UserNameCreate";
            this.UserNameCreate.Size = new System.Drawing.Size(362, 26);
            this.UserNameCreate.TabIndex = 4;
            // 
            // PasswordCreate
            // 
            this.PasswordCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.PasswordCreate.Location = new System.Drawing.Point(212, 220);
            this.PasswordCreate.Name = "PasswordCreate";
            this.PasswordCreate.Size = new System.Drawing.Size(362, 26);
            this.PasswordCreate.TabIndex = 5;
            this.PasswordCreate.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(208, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(207, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password:";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.ConfirmPassword.Location = new System.Drawing.Point(212, 278);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(362, 26);
            this.ConfirmPassword.TabIndex = 8;
            this.ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // SignInCreate
            // 
            this.SignInCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignInCreate.BackColor = System.Drawing.Color.LavenderBlush;
            this.SignInCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.SignInCreate.Location = new System.Drawing.Point(211, 491);
            this.SignInCreate.Name = "SignInCreate";
            this.SignInCreate.Size = new System.Drawing.Size(363, 35);
            this.SignInCreate.TabIndex = 9;
            this.SignInCreate.Text = "Sign Up";
            this.SignInCreate.UseVisualStyleBackColor = false;
            this.SignInCreate.Click += new System.EventHandler(this.SignInCreate_Click);
            // 
            // SignUp
            // 
            this.SignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignUp.BackColor = System.Drawing.Color.LavenderBlush;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.SignUp.Location = new System.Drawing.Point(211, 531);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(363, 35);
            this.SignUp.TabIndex = 10;
            this.SignUp.Text = "Log In";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = global::StudentInformationSystem.Properties.Resources._1199277_200;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(165, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::StudentInformationSystem.Properties.Resources.free_user_icon_3296_thumb;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(165, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label5.Location = new System.Drawing.Point(258, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "CREATE ACCOUNT";
            // 
            // FirstNCreateAcc
            // 
            this.FirstNCreateAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNCreateAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.FirstNCreateAcc.Location = new System.Drawing.Point(211, 334);
            this.FirstNCreateAcc.Name = "FirstNCreateAcc";
            this.FirstNCreateAcc.Size = new System.Drawing.Size(362, 26);
            this.FirstNCreateAcc.TabIndex = 15;
            // 
            // LastNCreateAcc
            // 
            this.LastNCreateAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNCreateAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.LastNCreateAcc.Location = new System.Drawing.Point(212, 394);
            this.LastNCreateAcc.Name = "LastNCreateAcc";
            this.LastNCreateAcc.Size = new System.Drawing.Size(362, 26);
            this.LastNCreateAcc.TabIndex = 16;
            // 
            // MiddleNCreateAcc
            // 
            this.MiddleNCreateAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MiddleNCreateAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.MiddleNCreateAcc.Location = new System.Drawing.Point(211, 452);
            this.MiddleNCreateAcc.Name = "MiddleNCreateAcc";
            this.MiddleNCreateAcc.Size = new System.Drawing.Size(363, 26);
            this.MiddleNCreateAcc.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(208, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "First name:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label7.Location = new System.Drawing.Point(208, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label8.Location = new System.Drawing.Point(208, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Middle name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // NotedPassswordError
            // 
            this.NotedPassswordError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NotedPassswordError.AutoSize = true;
            this.NotedPassswordError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotedPassswordError.ForeColor = System.Drawing.Color.Red;
            this.NotedPassswordError.Location = new System.Drawing.Point(365, 257);
            this.NotedPassswordError.Name = "NotedPassswordError";
            this.NotedPassswordError.Size = new System.Drawing.Size(0, 16);
            this.NotedPassswordError.TabIndex = 21;
            this.NotedPassswordError.Click += new System.EventHandler(this.label9_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordLabel.Location = new System.Drawing.Point(351, 199);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(0, 16);
            this.PasswordLabel.TabIndex = 22;
            // 
            // UsenameLabel
            // 
            this.UsenameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsenameLabel.AutoSize = true;
            this.UsenameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsenameLabel.ForeColor = System.Drawing.Color.Red;
            this.UsenameLabel.Location = new System.Drawing.Point(353, 142);
            this.UsenameLabel.Name = "UsenameLabel";
            this.UsenameLabel.Size = new System.Drawing.Size(0, 16);
            this.UsenameLabel.TabIndex = 23;
            this.UsenameLabel.Click += new System.EventHandler(this.UsenameLabel_Click);
            // 
            // FNameLabel
            // 
            this.FNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.ForeColor = System.Drawing.Color.Red;
            this.FNameLabel.Location = new System.Drawing.Point(302, 315);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(0, 16);
            this.FNameLabel.TabIndex = 24;
            // 
            // MNameLabel
            // 
            this.MNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MNameLabel.AutoSize = true;
            this.MNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNameLabel.ForeColor = System.Drawing.Color.Red;
            this.MNameLabel.Location = new System.Drawing.Point(318, 431);
            this.MNameLabel.Name = "MNameLabel";
            this.MNameLabel.Size = new System.Drawing.Size(0, 16);
            this.MNameLabel.TabIndex = 25;
            // 
            // LNameLabel
            // 
            this.LNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.ForeColor = System.Drawing.Color.Red;
            this.LNameLabel.Location = new System.Drawing.Point(300, 373);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(0, 16);
            this.LNameLabel.TabIndex = 26;
            // 
            // CreateAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 610);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.MNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.UsenameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NotedPassswordError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MiddleNCreateAcc);
            this.Controls.Add(this.LastNCreateAcc);
            this.Controls.Add(this.FirstNCreateAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SignInCreate);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordCreate);
            this.Controls.Add(this.UserNameCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateAccountPage";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccountPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameCreate;
        private System.Windows.Forms.TextBox PasswordCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Button SignInCreate;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNCreateAcc;
        private System.Windows.Forms.TextBox LastNCreateAcc;
        private System.Windows.Forms.TextBox MiddleNCreateAcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NotedPassswordError;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsenameLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label MNameLabel;
        private System.Windows.Forms.Label LNameLabel;
    }
}