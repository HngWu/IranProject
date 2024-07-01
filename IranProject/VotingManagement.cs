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
    public partial class VotingManagement : Form
    {
        BindingSource votingBindingSource = new BindingSource();
        public VotingManagement()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            initialiseSurveyGridView();
        }

        private void initialiseSurveyGridView()
        {
            votingGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            votingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (var context = new IranProjectContext())
            {
                var surveyList = context.Survey
                    .Select(sy => new
                    {
                        sy.SurveyId,
                        sy.SurveyName,
                        sy.Question,
                        sy.Status,
                        sy.StartDate,
                        sy.EndDate,

                    })
                    .ToList();
                votingBindingSource.DataSource = surveyList;
                votingGridView.DataSource = votingBindingSource;
                }
            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            editLink.UseColumnTextForLinkValue = true;
            editLink.HeaderText = "Edit";
            editLink.Text = "Edit";
            editLink.Name = "edit";
            votingGridView.Columns.Add(editLink);

            // Add Delete link column
            DataGridViewLinkColumn deleteLink = new DataGridViewLinkColumn();
            deleteLink.UseColumnTextForLinkValue = true;
            deleteLink.HeaderText = "Delete";
            deleteLink.Text = "Delete";
            deleteLink.Name = "Delete";
            votingGridView.Columns.Add(deleteLink);

            DataGridViewLinkColumn viewResultsLink = new DataGridViewLinkColumn();
            viewResultsLink.UseColumnTextForLinkValue = true;
            viewResultsLink.HeaderText = "View Results";
            viewResultsLink.Text = "View Results";
            viewResultsLink.Name = "View Results";
            votingGridView.Columns.Add(viewResultsLink);

        }

        public void RefreshVotingGridView()
        {
            using (var context = new IranProjectContext())
            {
                var surveyList = context.Survey
                    .Select(sy => new
                    {
                        sy.SurveyId,
                        sy.SurveyName,
                        sy.Question,
                        sy.Status,
                        sy.StartDate,
                        sy.EndDate,

                    })
                    .ToList();
                votingBindingSource.DataSource = surveyList;
                votingGridView.DataSource = votingBindingSource;
            }
        }


        private void SaloonManagementLabel_Click(object sender, EventArgs e)
        {
            SaloonManagement saloonManagement = new SaloonManagement();
            saloonManagement.Show();
            this.Hide();
        }

        private void votingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (votingGridView.Rows[e.RowIndex] != null && e.ColumnIndex == votingGridView.Columns["Delete"].Index)
            {
                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected row
                    //saloonGridView.Rows.RemoveAt(e.RowIndex);
                    DataGridViewRow row = votingGridView.Rows[e.RowIndex];
                    int surveyId = Convert.ToInt32(row.Cells["SurveyId"].Value);
                    Console.WriteLine(surveyId);
                    using (var context = new IranProjectContext())
                    {

                        var survey = context.Survey.Where(x => x.SurveyId == surveyId).FirstOrDefault();
                        if (survey != null) // Check if saloon is not null
                        {
                            context.Remove(survey);
                            context.SaveChanges();
                            RefreshVotingGridView();
                            // Refresh the DataGridView to reflect the changes
                            //RefreshSaloonGridview();
                        }
                        else
                        {
                            MessageBox.Show("Saloon not found.", "Error");
                        }
                    }
                }
            }

            // Check if row has edit button
            else if (votingGridView.Rows[e.RowIndex] != null && e.ColumnIndex == votingGridView.Columns["Edit"].Index)
            {
                CommonAccess.votingManagement = this;
                CommonAccess.row = e.RowIndex;
                CommonAccess.view = votingGridView;
                EditSurvey editSurvey = new EditSurvey();
                //editSurvey.selectedRow = e.RowIndex;
                //EditSaloon.SaloonGridView = votingGridView;
                
                editSurvey.Show();
            }
            else if (votingGridView.Rows[e.RowIndex] != null && e.ColumnIndex == votingGridView.Columns["View Results"].Index)
            {
                DataGridViewRow row = votingGridView.Rows[e.RowIndex];
                int surveyId = Convert.ToInt32(row.Cells["SurveyId"].Value);
                CommonAccess.surveyId = surveyId;
                SurveyResults surveyResults = new SurveyResults();
                surveyResults.Show();
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
            RequestEvaluation evaluation = new RequestEvaluation();
            evaluation.Show();
            this.Hide();
        }

        private void createSurveyButton_Click(object sender, EventArgs e)
        {
            CommonAccess.votingManagement = this;
            CreateSurvey createSurvey = new CreateSurvey();
            createSurvey.Show();
        }
    }
}
