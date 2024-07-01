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
    public partial class ExhibitorVotingPanel : Form
    {
        public ExhibitorVotingPanel()
        {
            this.WindowState = FormWindowState.Maximized;
            //ExhibitorVotingGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            InitializeComponent();
            PopulateExhibitorVotingGridView();
        }

        public void PopulateExhibitorVotingGridView()
        {
            ExhibitorVotingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (var context = new IranProjectContext())
            {
                var surveyList = context.Survey
                    .Where(x=>x.Status == "Activate")
                    .Where(x=> x.EndDate > DateTime.Now.Date)
                    .Select(sy => new
                    {
                        sy.SurveyId,
                        sy.SurveyName,


                    })
                    .ToList();

                var surveyAnswerList = context.SurveyAnswer.ToList();
                foreach(var user in surveyAnswerList)
                {
                    if(user.UserId == CommonAccess.user.UserId)
                    {
                        var CompletedSurvey = context.Survey.Where(x => x.SurveyId == user.SurveyId)
                                                .Select(sy => new
                                                {
                                                    sy.SurveyId,
                                                    sy.SurveyName,


                                                }).FirstOrDefault();
                        if(CompletedSurvey != null)
                        {
                            surveyList.Remove(CompletedSurvey);
                        }
                    }
                }
                surveyList = surveyList.ToList();

                DataGridViewLinkColumn doSurveyLink = new DataGridViewLinkColumn();
                doSurveyLink.UseColumnTextForLinkValue = true;
                doSurveyLink.HeaderText = "Do Survey";
                doSurveyLink.Text = "Do Survey";
                doSurveyLink.Name = "Do Survey";
                ExhibitorVotingGridView.DataSource = surveyList;
                ExhibitorVotingGridView.Columns.Add(doSurveyLink);


            }
        }

        public void RefreshExhibitorVotingGridView()
        {
            ExhibitorVotingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (var context = new IranProjectContext())
            {
                var surveyList = context.Survey
                    .Where(x => x.Status == "Activate")
                    .Where(x => x.EndDate > DateTime.Now.Date)
                    .Select(sy => new
                    {
                        sy.SurveyId,
                        sy.SurveyName,


                    })
                    .ToList();

                var surveyAnswerList = context.SurveyAnswer.ToList();
                foreach (var user in surveyAnswerList)
                {
                    if (user.UserId == CommonAccess.user.UserId)
                    {
                        var CompletedSurvey = context.Survey.Where(x => x.SurveyId == user.SurveyId)
                                                .Select(sy => new
                                                {
                                                    sy.SurveyId,
                                                    sy.SurveyName,


                                                }).FirstOrDefault();
                        if (CompletedSurvey != null)
                        {
                            surveyList.Remove(CompletedSurvey);
                        }
                    }
                }
                surveyList = surveyList.ToList();

                ExhibitorVotingGridView.DataSource = surveyList;

            }
        }


        private void ExhibitorVotingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ExhibitorVotingGridView.Rows[e.RowIndex] != null && e.ColumnIndex == ExhibitorVotingGridView.Columns["Do Survey"].Index)
            {
                DataGridViewRow row = ExhibitorVotingGridView.Rows[e.RowIndex];
                CommonAccess.surveyId = int.Parse(row.Cells["SurveyId"].Value.ToString());
                CommonAccess.exhibitorVotingPanel = this;
                ExhibitorDoSurvey exhibitorDoSurvey = new ExhibitorDoSurvey();
                exhibitorDoSurvey.Show();
                


                //EditExhibitor editExhibitor = new EditExhibitor(this);
                //editExhibitor.selectedRow = e.RowIndex;
                //editExhibitor.ExhibitorGridView = exhibitorGridView;

                //editExhibitor.Show();
            }
        }

        private void requestWorkshopLabel_Click(object sender, EventArgs e)
        {
            ExhibitorRequestPanel exhibitorRequestPanel = new ExhibitorRequestPanel();
            exhibitorRequestPanel.Show();
            this.Hide();
        }
    }
}
