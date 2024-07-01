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
    public partial class SaloonManagement : Form
    {
        BindingSource saloonBindingSource = new BindingSource();
        public SaloonManagement()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            initialiseSaloonGridView();


        }

        private void initialiseSaloonGridView()
        {
            saloonGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            saloonGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (var context = new IranProjectContext())
            {
                var saloonList = context.Saloon
                    .Select(sn => new
                    {
                        sn.SaloonId,
                        sn.SaloonName,
                    })
                    .ToList();
                saloonBindingSource.DataSource = saloonList;

                saloonGridView.DataSource = saloonBindingSource;


                DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
                editLink.UseColumnTextForLinkValue = true;
                editLink.HeaderText = "Edit";
                editLink.Text = "Edit";
                editLink.Name = "edit";
                saloonGridView.Columns.Add(editLink);

                // Add Delete link column
                DataGridViewLinkColumn deleteLink = new DataGridViewLinkColumn();
                deleteLink.UseColumnTextForLinkValue = true;
                deleteLink.HeaderText = "Delete";
                deleteLink.Text = "Delete";
                deleteLink.Name = "Delete";
                saloonGridView.Columns.Add(deleteLink);
            }
        }

        public void RefreshSaloonGridview() 
        {
            using (var context = new IranProjectContext())
            {
                var saloonList = context.Saloon
                    .Select(sn => new
                    {
                        sn.SaloonId,
                        sn.SaloonName,
                    })
                    .ToList();
                saloonBindingSource.DataSource = saloonList;
            }

        }


        private void createSaloonButton_Click(object sender, EventArgs e)
        {
            CreateSaloon createSaloon = new CreateSaloon(this);
            //createSaloon.SaloonGridView = saloonGridView;
            createSaloon.Show();
        }

        private void SaloonManagementLabel_Click(object sender, EventArgs e)
        {

        }

        private void saloonGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (saloonGridView.Rows[e.RowIndex] != null && e.ColumnIndex == saloonGridView.Columns["Delete"].Index)
            {
                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected row
                    //saloonGridView.Rows.RemoveAt(e.RowIndex);
                    DataGridViewRow row = saloonGridView.Rows[e.RowIndex];
                    int saloonId = Convert.ToInt32(row.Cells["SaloonId"].Value);
                    Console.WriteLine(saloonId);
                    using (var context = new IranProjectContext())
                    {

                        var saloon = context.Saloon.Where(x=> x.SaloonId == saloonId).FirstOrDefault();
                        if (saloon != null) // Check if saloon is not null
                        {
                            context.Remove(saloon);
                            context.SaveChanges();

                            // Refresh the DataGridView to reflect the changes
                            RefreshSaloonGridview();
                        }
                        else
                        {
                            MessageBox.Show("Saloon not found.", "Error");
                        }
                    }
                }
            }

            // Check if row has edit button
            else if (saloonGridView.Rows[e.RowIndex] != null && e.ColumnIndex == saloonGridView.Columns["Edit"].Index)
            {
                EditSaloon EditSaloon = new EditSaloon(this);
                EditSaloon.selectedRow = e.RowIndex;
                EditSaloon.SaloonGridView = saloonGridView;

                EditSaloon.Show();
            }

        }

        private void exhibitorManagement_Click(object sender, EventArgs e)
        {
            ExhibitorManagement exhibitorManagement = new ExhibitorManagement();    
            exhibitorManagement.Show();
            this.Hide();
        }

        private void evaluateRequestsLabel_Click(object sender, EventArgs e)
        {
            RequestEvaluation requestEvaluation = new RequestEvaluation();
            requestEvaluation.Show();
            this.Hide();
        }

        private void votingManagementLabel_Click(object sender, EventArgs e)
        {
            VotingManagement votingManagement = new VotingManagement();
            votingManagement.Show();
            this.Hide();
        }
    }
}

