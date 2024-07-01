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

namespace IranProject
{
    public partial class CreateExhibitor : Form
    {
        ExhibitorManagement ExhibitorManagementForm;
        public CreateExhibitor(ExhibitorManagement exhibitorManagementForm)
        {
            InitializeComponent();
            ExhibitorManagementForm = exhibitorManagementForm;
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
                    UserTypeId = 1,
                    UserName = enteredUsername,
                    Password = hashedPassword, // Remember to hash your passwords before storing them
                    Fullname = enteredFullName,
                    Tel = enteredTelephoneNumber
                };

                context.Add(user);
                context.SaveChanges();
                ExhibitorManagementForm.refreshExhibitorGridView();
                MessageBox.Show("exhibitor Has been Added Successfully");
                this.Hide();
            }


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

        private void SignupLabel_Click(object sender, EventArgs e)
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
