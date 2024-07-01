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

    public partial class EditSaloon : Form
    {
        public int selectedRow { get; set; }
        public DataGridView SaloonGridView { get; set; }
        
        private SaloonManagement saloonManagementForm;

        public EditSaloon(SaloonManagement saloonManagement)
        {
            InitializeComponent();
            saloonManagementForm = saloonManagement;
        }

        private void editSaloonbutton_Click(object sender, EventArgs e)
        {
            var saloonName = saloonNameTextBox.Text;
            DataGridViewRow row = SaloonGridView.Rows[selectedRow];
            int saloonId = Convert.ToInt32(row.Cells["SaloonId"].Value);
            using (var context = new IranProjectContext())
            {
                var saloon = context.Saloon.Where(x => x.SaloonId == saloonId).FirstOrDefault();
                saloon.SaloonName = saloonName;
                context.Update(saloon);
                context.SaveChanges();
                saloonManagementForm.RefreshSaloonGridview();

                this.Hide();
            }
        }

        private void EditSaloon_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = SaloonGridView.Rows[selectedRow];
            saloonNameTextBox.Text = row.Cells["SaloonName"].Value.ToString();
        }
    }
}
