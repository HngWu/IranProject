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
    public partial class ExhibitorManagement : Form
    {
        BindingSource exhibitorBindingSource = new BindingSource();

        public ExhibitorManagement()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            initialiseExhibitorGridView();
        }


        private void initialiseExhibitorGridView()
        {
            exhibitorGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            exhibitorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (var context = new IranProjectContext())
            {
                var exhibitorList = context.User
                    .Select(u => new
                    {
                        u.UserId,
                        u.UserTypeId,
                        u.UserName,
                        u.Fullname,
                        u.Tel,

                    })
                    .ToList();
                exhibitorBindingSource.DataSource = exhibitorList;

                exhibitorGridView.DataSource = exhibitorBindingSource;


                DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
                editLink.UseColumnTextForLinkValue = true;
                editLink.HeaderText = "Edit";
                editLink.Text = "Edit";
                editLink.Name = "edit";
                exhibitorGridView.Columns.Add(editLink);

                // Add Delete link column
                DataGridViewLinkColumn deleteLink = new DataGridViewLinkColumn();
                deleteLink.UseColumnTextForLinkValue = true;
                deleteLink.HeaderText = "Delete";
                deleteLink.Text = "Delete";
                deleteLink.Name = "Delete";
                exhibitorGridView.Columns.Add(deleteLink);
            }
        }

        public void refreshExhibitorGridView()
        {
            using (var context = new IranProjectContext())
            {
                var exhibitorList = context.User
                    .Select(u => new
                    {
                        u.UserId,
                        u.UserTypeId,
                        u.UserName,
                        u.Fullname,
                        u.Tel,

                    })
                    .ToList();
                exhibitorBindingSource.DataSource = exhibitorList;
            }
        }

        private void createExhibitorButton_Click(object sender, EventArgs e)
        {
            CreateExhibitor createExhibitor = new CreateExhibitor(this);
            //createSaloon.SaloonGridView = saloonGridView;
            createExhibitor.Show();
        }

        private void exhibitorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (exhibitorGridView.Rows[e.RowIndex] != null && e.ColumnIndex == exhibitorGridView.Columns["Delete"].Index)
            {
                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected row
                    //saloonGridView.Rows.RemoveAt(e.RowIndex);
                    DataGridViewRow row = exhibitorGridView.Rows[e.RowIndex];
                    int userId = Convert.ToInt32(row.Cells["UserId"].Value);
                    Console.WriteLine(userId);
                    using (var context = new IranProjectContext())
                    {

                        var user = context.User.Where(x => x.UserId == userId).FirstOrDefault();
                        if (user != null) // Check if saloon is not null
                        {
                            context.Remove(user);
                            context.SaveChanges();

                            // Refresh the DataGridView to reflect the changes
                            refreshExhibitorGridView();
                        }
                        else
                        {
                            MessageBox.Show("Saloon not found.", "Error");
                        }
                    }
                }
            }

            // Check if row has edit button
            else if (exhibitorGridView.Rows[e.RowIndex] != null && e.ColumnIndex == exhibitorGridView.Columns["Edit"].Index)
            {
                EditExhibitor editExhibitor = new EditExhibitor(this);
                editExhibitor.selectedRow = e.RowIndex;
                editExhibitor.ExhibitorGridView = exhibitorGridView;

                editExhibitor.Show();
            }

        }

        private void votingManagementLabel_Click(object sender, EventArgs e)
        {
            VotingManagement votingManagement = new VotingManagement();
            votingManagement.Show();
            this.Hide();
        }

        private void SaloonManagementLabel_Click(object sender, EventArgs e)
        {
            SaloonManagement saloonManagement = new SaloonManagement();
            saloonManagement.Show();
            this.Hide();
        }

        private void evaluateRequestsLabel_Click(object sender, EventArgs e)
        {
            RequestEvaluation requestEvaluation = new RequestEvaluation();
            requestEvaluation.Show();
            this.Hide();
        }
    }
    
}
