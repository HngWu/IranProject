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
    public partial class ExhibitorDoSurvey : Form
    {

        static Dictionary<string, int> surveyOptions;
        public ExhibitorDoSurvey()
        {
            InitializeComponent();
        }

        private void submitSurveybutton_Click(object sender, EventArgs e)
        {
            var enteredAnswer = surveyOptionComboBox.Text;
            var surveyOptionId = surveyOptions[enteredAnswer];
            using (var context = new IranProjectContext())
            {

                var answer = new SurveyAnswer
                {
                    SurveyId = CommonAccess.surveyId,
                    UserId = CommonAccess.user.UserId,
                    SurveyOptionId = surveyOptionId
                };

                context.Add(answer);
                context.SaveChanges();
                ExhibitorVotingPanel exhibitorVotingPanel = CommonAccess.exhibitorVotingPanel;
                exhibitorVotingPanel.RefreshExhibitorVotingGridView();
                this.Hide();
            }
        }

        private void ExhibitorDoSurvey_Load(object sender, EventArgs e)
        {
            using (var context = new IranProjectContext())
            {
                var surveyId = CommonAccess.surveyId;
                var survey = context.Survey.Where(x => x.SurveyId == surveyId).FirstOrDefault();
                QuestionLabel.Text = $"Question: {survey.Question}";
                surveyOptions = context.SurveyOption
                    .Where(x => x.SurveyId == surveyId)
                    .ToDictionary(x => x.SurveyOptionName, x => x.SurveyOptionId);

                foreach (var surveyOptionName in surveyOptions.Keys)
                {
                    surveyOptionComboBox.Items.Add(surveyOptionName);

                }

            }
        }
    }
}
