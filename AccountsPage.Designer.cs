namespace StudentInformationSystem
{
    partial class AccountsPage
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
            this.AccountList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAcc = new System.Windows.Forms.Button();
            this.DeleteAcc = new System.Windows.Forms.Button();
            this.EditAcc = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(409, 58);
            this.panel1.TabIndex = 4;
            // 
            // StudinfoSystem
            // 
            this.StudinfoSystem.AutoSize = true;
            this.StudinfoSystem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudinfoSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.StudinfoSystem.Location = new System.Drawing.Point(13, 21);
            this.StudinfoSystem.Name = "StudinfoSystem";
            this.StudinfoSystem.Size = new System.Drawing.Size(221, 19);
            this.StudinfoSystem.TabIndex = 1;
            this.StudinfoSystem.Text = "Student Information System";
            // 
            // AccountList
            // 
            this.AccountList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountList.FormattingEnabled = true;
            this.AccountList.ItemHeight = 16;
            this.AccountList.Location = new System.Drawing.Point(12, 123);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(383, 276);
            this.AccountList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Accounts";
            // 
            // AddAcc
            // 
            this.AddAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAcc.BackColor = System.Drawing.Color.LavenderBlush;
            this.AddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.AddAcc.Location = new System.Drawing.Point(12, 426);
            this.AddAcc.Name = "AddAcc";
            this.AddAcc.Size = new System.Drawing.Size(103, 29);
            this.AddAcc.TabIndex = 20;
            this.AddAcc.Text = "Add";
            this.AddAcc.UseVisualStyleBackColor = false;
            // 
            // DeleteAcc
            // 
            this.DeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteAcc.BackColor = System.Drawing.Color.LavenderBlush;
            this.DeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.DeleteAcc.Location = new System.Drawing.Point(12, 461);
            this.DeleteAcc.Name = "DeleteAcc";
            this.DeleteAcc.Size = new System.Drawing.Size(103, 29);
            this.DeleteAcc.TabIndex = 21;
            this.DeleteAcc.Text = "Delete";
            this.DeleteAcc.UseVisualStyleBackColor = false;
            // 
            // EditAcc
            // 
            this.EditAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditAcc.BackColor = System.Drawing.Color.LavenderBlush;
            this.EditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.EditAcc.Location = new System.Drawing.Point(12, 496);
            this.EditAcc.Name = "EditAcc";
            this.EditAcc.Size = new System.Drawing.Size(103, 29);
            this.EditAcc.TabIndex = 22;
            this.EditAcc.Text = "Edit";
            this.EditAcc.UseVisualStyleBackColor = false;
            // 
            // AccountsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 539);
            this.Controls.Add(this.EditAcc);
            this.Controls.Add(this.DeleteAcc);
            this.Controls.Add(this.AddAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountList);
            this.Controls.Add(this.panel1);
            this.Name = "AccountsPage";
            this.Text = "AccountsPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StudinfoSystem;
        private System.Windows.Forms.ListBox AccountList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAcc;
        private System.Windows.Forms.Button DeleteAcc;
        private System.Windows.Forms.Button EditAcc;
    }
}