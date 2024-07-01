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
    public partial class CreateSaloon : Form
    {
        private SaloonManagement saloonManagementForm;
        public CreateSaloon(SaloonManagement saloonManagement)
        {
            InitializeComponent();
            saloonManagementForm = saloonManagement;
        }

        private void saloonNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaloonNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void createSaloonbutton_Click(object sender, EventArgs e)
        {
            using (var context = new IranProjectContext())
            {
                var enteredSaloonName = saloonNameTextBox.Text;
                var saloon = new Saloon()
                {
                    SaloonName = enteredSaloonName,
                };
                context.Saloon.Add(saloon);
                context.SaveChanges();
                saloonManagementForm.RefreshSaloonGridview();
                MessageBox.Show("Saloon Has been Added Successfully");
                this.Hide();
            }
        }
    }
}
