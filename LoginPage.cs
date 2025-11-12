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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
          

        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            PasswordtextBox.UseSystemPasswordChar = true;
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.MaxLength = 20;
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPass_Click(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            string Password = PasswordtextBox.Text;
            string Username = UserNametextBox.Text;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
