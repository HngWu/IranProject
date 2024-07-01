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
using System.Windows.Forms.DataVisualization.Charting;

namespace IranProject
{
    public partial class SurveyResults : Form
    {
        private Chart chart;


        public SurveyResults()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void SurveyResults_Load(object sender, EventArgs e)
        {
            
                //surveyResultsChart.DataSource = surveyAnswerList;

            
        }

        private void InitializeChart()
        {
            using (var context = new IranProjectContext())
            {
                // Create a new chart
                chart = new Chart();
                chart.Dock = DockStyle.Fill; // Fill the form with the chart
                this.Controls.Add(chart);

                // Create a chart area
                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                // Create a series and add data points to it
                Series series = new Series();
                series.Name = "SampleSeries";
                series.ChartType = SeriesChartType.Bar;


                var surveyAnswerList = context.SurveyAnswer
                    .Where(x => x.SurveyId == CommonAccess.surveyId).ToList();
                var surveyOptionList = context.SurveyOption
                    .Where(x => x.SurveyId == CommonAccess.surveyId).ToList();

                Dictionary<string, int> dataDictionary = new Dictionary<string, int>();

                foreach (var surveyAnswer in surveyAnswerList)
                {
                    dataDictionary[surveyAnswer.SurveyOption.SurveyOptionName] = 0;
                }
                foreach (var surveyOption in surveyOptionList)
                {
                    if (dataDictionary.Keys.Any(x => x == surveyOption.SurveyOptionName))
                    {
                        dataDictionary[surveyOption.SurveyOptionName]++;
                    }
                }

                foreach(var data in dataDictionary)
                {
                    series.Points.AddXY(data.Key, data.Value);
                }

                //series.Points.AddXY("Category1", 10);
                //series.Points.AddXY("Category2", 20);
                //series.Points.AddXY("Category3", 30);
                //series.Points.AddXY("Category4", 40);

                // Add the series to the chart
                chart.Series.Add(series);

                // Customize chart area (optional)
                chartArea.AxisX.Title = "Survey Options";
                chartArea.AxisY.Title = "Number of Entries";

                // Optionally, add titles
                Title chartTitle = new Title();
                chartTitle.Text = "Survey Bar Chart";
                chart.Titles.Add(chartTitle);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
