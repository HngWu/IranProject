using IranProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace IranProject
{
    public partial class Form1 : Form
    {
        Signup signup;

        public Form1()
        {
            InitializeComponent();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextbox.Text;
            string enteredPassword = passwordTextbox.Text;

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("You have entered an invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (IranProjectContext context = new IranProjectContext())
                {
                    var user = context.User.FirstOrDefault(x => x.UserName == enteredUsername);
                    if (user != null && user.UserTypeId == 1 && user.Password == enteredPassword)
                    {
                        ExhibitorHome homePage = new ExhibitorHome();
                        CommonAccess.user = user;
                        homePage.Show();
                        this.Hide();
                    }
                    else if (user != null && user.UserTypeId ==  2 && BCrypt.Net.BCrypt.Verify(enteredPassword, user.Password))
                    {
                        Home homepage = new Home();
                        CommonAccess.user = user;
                        homepage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You have entered an invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void signUpLinkLabel_Click(object sender, EventArgs e)
        {
            if (signup == null)
            {
                signup = new Signup();

            }
            signup.Show();
            this.Hide();

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
