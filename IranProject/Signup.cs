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
using IranProject.Models;

namespace IranProject
{
    public partial class Signup : Form
    {
        private Form1 form1;
        public Signup()
        {
            InitializeComponent();
        }

        private void loginLinkLabel_Click(object sender, EventArgs e)
        {
            if (form1 == null)
            {
                form1 = new Form1();

            }
            form1.Show();
            this.Hide();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextbox.Text;
            string enteredFullName = fullNameTextBox.Text;
            int enteredTelephoneNumber = int.Parse(telephoneNumberTextBox.Text);
            string enteredPassword = passwordTextbox.Text;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(enteredPassword);

            using (var context = new IranProjectContext())
            {
                var user = new User
                {
                    UserTypeId = 2,
                    UserName = enteredUsername,
                    Password = hashedPassword, // Remember to hash your passwords before storing them
                    Fullname = enteredFullName,
                    Tel = enteredTelephoneNumber
                };

                context.Add(user);
                context.SaveChanges();
                Home homepage = new Home();
                homepage.Show();
                this.Hide();

            }

        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {

        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void telLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void telephoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
