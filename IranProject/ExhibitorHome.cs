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
    public partial class ExhibitorHome : Form
    {
        public ExhibitorHome()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void votingSurveyLabel_Click(object sender, EventArgs e)
        {
            ExhibitorVotingPanel exhibitorVotingPanel = new ExhibitorVotingPanel();
            exhibitorVotingPanel.Show();
            this.Hide();
        }

        private void requestWorkshopLabel_Click(object sender, EventArgs e)
        {
            ExhibitorRequestPanel exhibitorRequestPanel = new ExhibitorRequestPanel();
            exhibitorRequestPanel.Show();
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
