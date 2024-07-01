using IranProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IranProject
{
    public partial class EditSurvey : Form
    {
        //public static int selectedRow = CommonAccess.row;
        //public static DataGridView votingGridView = CommonAccess.view;
        //public static VotingManagement VotingManagement = CommonAccess.votingManagement;
        //public static DataGridViewRow row = votingGridView.Rows[selectedRow];
        public static int surveyId;
        public static int choiceCount;
        VotingManagement votingManagement;

        public EditSurvey()
        {
            InitializeComponent();
        }

        private void EditSurvey_Load(object sender, EventArgs e)
        {
            int selectedRow = CommonAccess.row;
            DataGridView votingGridView = CommonAccess.view;
            votingManagement = CommonAccess.votingManagement;
            DataGridViewRow row = votingGridView.Rows[selectedRow];
            surveyNameTextbox.Text = row.Cells["SurveyName"].Value.ToString();
            QuestionTextBox.Text = row.Cells["Question"].Value.ToString();
            endDatedateTimePicker.Text = row.Cells["EndDate"].Value.ToString();
            StatusCombobox.Text = row.Cells["Status"].Value.ToString();


            surveyId = int.Parse(row.Cells["SurveyId"].Value.ToString());

            using (var context = new IranProjectContext())
            {
                var optionList = context.SurveyOption.Where(x=>x.SurveyId == surveyId).ToList();
                Console.WriteLine(surveyId);
                foreach (var option in optionList)
                {
                    TextBox choiceTextBox = new TextBox() { Width = 230, Tag = addoptionButton };
                    choiceTextBox.Text = $"{option.SurveyOptionName}";
                    choiceCount++;
                    surveyOptionFlowLayoutPanel.Controls.Add(choiceTextBox);
                }

            }

        }

        private void editSurveyButton_Click(object sender, EventArgs e)
        {
            using (var context = new IranProjectContext())
            {
                var surveyName = surveyNameTextbox.Text;
                var question = QuestionTextBox.Text;
                var Date = endDatedateTimePicker.Value.Date;
                var status = StatusCombobox.Text;


                try
                {
                    var survey = context.Survey.Where(x => x.SurveyId == surveyId).FirstOrDefault();
                    survey.SurveyName = surveyName;
                    survey.Question = question;
                    survey.Status = status;
                    survey.StartDate = DateTime.Now.Date;
                    survey.EndDate = Date;


                    var optionList = context.SurveyOption.Where(x=> x.SurveyId == surveyId).ToList();
                    context.RemoveRange(optionList);
                    context.SaveChanges();
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
                                SurveyId = surveyId
                            };
                            //context.Add(surveyOption);
                            //context.SaveChanges();
                            survey.SurveyOption.Add(surveyOption);
                        }
                    }
                    context.Update(survey);
                    context.SaveChanges();
                    votingManagement.RefreshVotingGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error has occured");
                }

               
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
    }
}
