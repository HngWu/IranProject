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
    public partial class Home : Form
    {
        public Home()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void evaluateRequestsLabel_Click(object sender, EventArgs e)
        {
            RequestEvaluation requestEvaluation = new RequestEvaluation();
            requestEvaluation.Show();
            this.Hide();
        }

        

        private void SaloonManagementLabel_Click(object sender, EventArgs e)
        {
            SaloonManagement saloonManagement = new SaloonManagement();
            saloonManagement.Show();
            this.Hide();
        }

        private void exhibitorManagement_Click(object sender, EventArgs e)
        {
            ExhibitorManagement exhibitorManagement = new ExhibitorManagement();
            exhibitorManagement.Show();
            this.Hide();
        }

        private void votingManagementLabel_Click(object sender, EventArgs e)
        {
            VotingManagement votingManagement = new VotingManagement();
            votingManagement.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            CommonAccess.user = null;
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();

        }
    }
}
