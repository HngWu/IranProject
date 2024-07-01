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
    public partial class ExhibitorRequestPanel : Form
    {
        public ExhibitorRequestPanel()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            PopulateExhibitorRequestGridView();
        }

        public void PopulateExhibitorRequestGridView()
        {
            exhibitorRequestGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (var context = new IranProjectContext())
            {
                var requests = context.WorkshopRequest
                    .Where(x => x.UserId == CommonAccess.user.UserId)
                    .Select(wr=> new
                    {
                        wr.WorkshopRequestId,
                        wr.Saloon.SaloonName,
                        wr.Category.CategoryName,
                        wr.WorkshopTime.Description,
                        wr.Date,
                        wr.Status
                    })
                    .ToList();
                exhibitorRequestGridView.DataSource = requests;
            }
        }

        private void exhibitorRequestGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void createRequestButton_Click(object sender, EventArgs e)
        {
            CommonAccess.exhibitorRequestPanel = this;
            CreateRequest createRequest = new CreateRequest();
            createRequest.Show();
        }

        private void requestWorkshopLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void votingSurveyLabel_Click(object sender, EventArgs e)
        {
            ExhibitorVotingPanel exhibitorVotingPanel = new ExhibitorVotingPanel();
            exhibitorVotingPanel.Show();
            this.Hide();
        }
    }
}
