using IranProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IranProject
{
    public partial class CreateSurvey : Form
    {
        private int choiceCount = 1;
        public CreateSurvey()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createSurveyButton_Click(object sender, EventArgs e)
        {




            using (var context = new IranProjectContext())
            {
                var surveyName = surveyNameTextbox.Text;
                var question = QuestionTextBox.Text;
                var Date = endDatedateTimePicker.Value.Date;
                var status = StatusCombobox.Text;


                try
                {
                    var survey = new Survey()
                    {
                        SurveyName = surveyName,
                        Question = question,
                        Status = status,
                        StartDate = DateTime.Now.Date,
                        EndDate = Date,
                    };
                    foreach (Control control in surveyOptionFlowLayoutPanel.Controls)
                    {
                        //context.Add(survey);
                        //context.SaveChanges();
                        //var surveyId = context.Survey.Where(x => x.SurveyName == surveyName).FirstOrDefault().SurveyId;
                        if (control is TextBox choiceTextBox)
                        {


                            //choices.Add(choiceTextBox.Text);
                            var surveyOption = new SurveyOption()
                            {
                                SurveyOptionName = choiceTextBox.Text,
                                //SurveyId = surveyId
                            };
                            //context.Add(surveyOption);
                            //context.SaveChanges();
                            survey.SurveyOption.Add(surveyOption);
                        }
                    }
                    context.Add(survey);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error has occured");
                }

                //VotingManagement votingManagement = new VotingManagement();
                VotingManagement votingManagement = CommonAccess.votingManagement;
                votingManagement.RefreshVotingGridView();
                //votingManagement.Show();

                this.Hide();

            }

        }

        private void addoptionButton_Click(object sender, EventArgs e)
        {
            TextBox choiceTextBox = new TextBox() { Width = 230, Tag = addoptionButton };
            choiceTextBox.Text = $"Option {choiceCount}";
            choiceCount++;
            surveyOptionFlowLayoutPanel.Controls.Add(choiceTextBox);
        }

        private void CreateSurvey_Load(object sender, EventArgs e)
        {
            TextBox choiceTextBox = new TextBox() { Width = 230, Tag = addoptionButton };
            choiceTextBox.Text = $"Option {choiceCount}";
            choiceCount++;
            surveyOptionFlowLayoutPanel.Controls.Add(choiceTextBox);

        }

        private void delOptionbutton_Click(object sender, EventArgs e)
        {
            if (surveyOptionFlowLayoutPanel.Controls.Count > 0)
            {
                // Remove the last TextBox added to the choicesPanel
                surveyOptionFlowLayoutPanel.Controls.RemoveAt(surveyOptionFlowLayoutPanel.Controls.Count - 1);
                choiceCount--;
            }
            else
            {
                MessageBox.Show("No choices to remove.");
            }
        }

        private void createSurveyLabel_Click(object sender, EventArgs e)
        {

        }

        private void surveyOptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void StatusCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        private void surveyNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void endDatedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surveyNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
