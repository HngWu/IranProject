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
    public partial class EditExhibitor : Form
    {
        public int selectedRow { get; set; }
        public DataGridView ExhibitorGridView { get; set; }

        private ExhibitorManagement ExhibitorManagement { get; set; }
        public EditExhibitor(ExhibitorManagement exhibitorManagement)
        {
            InitializeComponent();
            ExhibitorManagement = exhibitorManagement;
        }

        private void editSignupButton_Click(object sender, EventArgs e)
        {
            //var saloonName = saloonNameTextBox.Text;
            var userName = usernameTextbox.Text;
            var fullName = fullNameTextBox.Text;
            var tel = int.Parse(telephoneNumberTextBox.Text);


            DataGridViewRow row = ExhibitorGridView.Rows[selectedRow];
            int userId = Convert.ToInt32(row.Cells["UserId"].Value);
            using (var context = new IranProjectContext())
            {
                var user = context.User.Where(x => x.UserId == userId).FirstOrDefault();
                //saloon.SaloonName = saloonName;
                user.UserName = userName;
                user.Fullname = fullName;
                user.Tel = tel;
                context.Update(user);
                context.SaveChanges();
                ExhibitorManagement.refreshExhibitorGridView();
                //saloonManagementForm.RefreshSaloonGridview();

                this.Hide();
            }
        }

        private void EditExhibitor_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = ExhibitorGridView.Rows[selectedRow];
            usernameTextbox.Text = row.Cells["UserName"].Value.ToString();
            fullNameTextBox.Text = row.Cells["Fullname"].Value.ToString();
            telephoneNumberTextBox.Text = row.Cells["Tel"].Value.ToString();
            //passwordTextbox.Text = row.Cells["Password"].Value.ToString();
            passwordTextbox.Text = "******************";

            //saloonNameTextBox.Text = row.Cells["SaloonName"].Value.ToString();
        }
    }
}
