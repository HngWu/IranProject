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
using System.IO;
using System.Diagnostics; // Make sure this using directive is present

namespace IranProject
{
    public partial class RequestEvaluation : Form
    {
        Home home;
        BindingSource pendingBindingSource = new BindingSource();
        BindingSource acceptedBindingSource = new BindingSource();
        BindingSource rejectedBindingSource = new BindingSource();
        public RequestEvaluation()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            using (var context = new IranProjectContext())
            {
                // Ensure the context is tracking the entities for change notification
                var pendingRequestsQuery = context.WorkshopRequest
                    .Where(x => x.Status == "Pending")
                    .OrderBy(wr => wr.SaloonId) // First sort by SaloonId
                    .ThenBy(wr => wr.WorkshopTimeId)
                    .Select(wr => new
                    {
                        wr.WorkshopRequestId,
                        wr.User.Fullname,
                        wr.Saloon.SaloonName,
                        wr.WorkshopTime.Description,
                        wr.Date,
                    });

                var acceptedRequestsQuery = context.WorkshopRequest

                    .Where(x => x.Status == "Accepted")
                    .OrderBy(wr => wr.SaloonId) // First sort by SaloonId
                    .ThenBy(wr => wr.WorkshopTimeId)
                    .Select(wr => new
                    {
                        wr.WorkshopRequestId,
                        wr.User.Fullname,
                        wr.Saloon.SaloonName,
                        wr.WorkshopTime.Description,
                        wr.Date,
                    });

                var rejectedRequestsQuery = context.WorkshopRequest
                    .OrderBy(wr => wr.SaloonId) // First sort by SaloonId
                    .ThenBy(wr => wr.WorkshopTimeId)
                    .Where(x => x.Status == "Rejected")
                    .Select(wr => new
                    {
                        wr.WorkshopRequestId,
                        wr.User.Fullname,
                        wr.Saloon.SaloonName,
                        wr.WorkshopTime.Description,
                        wr.Date,
                    });

                // Convert the queries to BindingList via ToBindingList for data binding
                var pendingRequests = pendingRequestsQuery.ToList(); // Your existing query
                var acceptedRequests = acceptedRequestsQuery.ToList(); // Your existing query
                var rejectedRequests = rejectedRequestsQuery.ToList(); // Your existing query

                // Create BindingSource instances


                // Assign the query result lists to the BindingSource.DataSource properties
                pendingBindingSource.DataSource = pendingRequests;
                acceptedBindingSource.DataSource = acceptedRequests;
                rejectedBindingSource.DataSource = rejectedRequests;

                // Finally, set the DataGridView.DataSource properties to the respective BindingSource instances
                RequestListView.DataSource = pendingBindingSource;
                acceptedlistView.DataSource = acceptedBindingSource;
                rejectedListView.DataSource = rejectedBindingSource;

                // Add link columns for approve/reject actions
                formatColumn();
                AddLinkColumns();
            }
        }

        private void formatColumn()
        {
            RequestListView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RequestListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            acceptedlistView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            acceptedlistView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rejectedListView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rejectedListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void AddLinkColumns()
        {// Create and add approve and reject link columns for RequestListView
            DataGridViewLinkColumn acceptLink1 = new DataGridViewLinkColumn();
            acceptLink1.UseColumnTextForLinkValue = true;
            acceptLink1.HeaderText = "Accept";
            acceptLink1.Text = "Accept";
            acceptLink1.Name = "Accept";

            DataGridViewLinkColumn rejectLink1 = new DataGridViewLinkColumn();
            rejectLink1.UseColumnTextForLinkValue = true;
            rejectLink1.HeaderText = "Reject";
            rejectLink1.Text = "Reject";
            rejectLink1.Name = "Reject";

            RequestListView.Columns.Add(acceptLink1);
            RequestListView.Columns.Add(rejectLink1);

            // Create and add approve and reject link columns for acceptedListView


            DataGridViewLinkColumn rejectLink2 = new DataGridViewLinkColumn();
            rejectLink2.UseColumnTextForLinkValue = true;
            rejectLink2.HeaderText = "Reject";
            rejectLink2.Text = "Reject";
            rejectLink2.Name = "Reject";

            acceptedlistView.Columns.Add(rejectLink2);

            // Create and add approve and reject link columns for rejectedListView
            DataGridViewLinkColumn approveLink3 = new DataGridViewLinkColumn();
            approveLink3.UseColumnTextForLinkValue = true;
            approveLink3.HeaderText = "Accept";
            approveLink3.Text = "Accept";
            approveLink3.Name = "Accept";



            rejectedListView.Columns.Add(approveLink3);

        }


        private void RequestListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new IranProjectContext())
            {
                if (RequestListView.Rows[e.RowIndex] != null && e.ColumnIndex == RequestListView.Columns["Accept"].Index)
                {
                    DataGridViewRow selectedRow = RequestListView.Rows[e.RowIndex];
                    int workshopRequestId = Convert.ToInt32(selectedRow.Cells["WorkshopRequestId"].Value);
                    string saloonName = selectedRow.Cells["SaloonName"].Value.ToString();
                    string Description = selectedRow.Cells["Description"].Value.ToString();
                    var date = DateTime.Parse(selectedRow.Cells["Date"].Value.ToString());
                    var check = context.WorkshopRequest
                        .Where(x=> x.Status == "Accepted")
                        .Where(x => x.Date == date)
                        .Where(x => x.Saloon.SaloonName == saloonName)
                        .Where(x => x.WorkshopTime.Description == Description)
                        .Any();

                    if (check)
                    {
                        MessageBox.Show("An existing workshop has alr booked the saloon at the stated time");
                    }
                    else
                    {

                        DialogResult result = MessageBox.Show("Are you sure you want to perform this action?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Process the result of the confirmation box
                        if (result == DialogResult.Yes)
                        {
                            //DataGridViewRow selectedRow = RequestListView.Rows[e.RowIndex];

                            {
                                WorkshopRequest workshopRequest = context.WorkshopRequest.FirstOrDefault(wr => wr.WorkshopRequestId == workshopRequestId);
                                if (workshopRequest != null)
                                {
                                    workshopRequest.Status = "Accepted";
                                    context.SaveChanges();
                                }


                                // Update the status in the DataGridView
                                RefreshPendingRequests();
                                RefreshAcceptedRequests();
                                RefreshRejectedRequests();
                            }
                        }
                    }


                }
                else if (RequestListView.Rows[e.RowIndex] != null && e.ColumnIndex == RequestListView.Columns["Reject"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to perform this action?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Process the result of the confirmation box
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = RequestListView.Rows[e.RowIndex];
                        int workshopRequestId = Convert.ToInt32(selectedRow.Cells["WorkshopRequestId"].Value);

                        //using (var context = new IranProjectContext())
                        {
                            WorkshopRequest workshopRequest = context.WorkshopRequest.FirstOrDefault(wr => wr.WorkshopRequestId == workshopRequestId);
                            if (workshopRequest != null)
                            {
                                workshopRequest.Status = "Rejected";
                                context.SaveChanges();
                            }
                        }

                        // Update the status in the DataGridView
                        RefreshPendingRequests();
                        RefreshAcceptedRequests();
                        RefreshRejectedRequests();
                    }
                }
            }
        }
        private void acceptedlistView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (acceptedlistView.Rows[e.RowIndex] != null && e.ColumnIndex == acceptedlistView.Columns["Reject"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to perform this action?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Process the result of the confirmation box
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = acceptedlistView.Rows[e.RowIndex];
                        int workshopRequestId = Convert.ToInt32(selectedRow.Cells["WorkshopRequestId"].Value);

                        using (var context = new IranProjectContext())
                        {
                            WorkshopRequest workshopRequest = context.WorkshopRequest.FirstOrDefault(wr => wr.WorkshopRequestId == workshopRequestId);
                            if (workshopRequest != null)
                            {
                                workshopRequest.Status = "Rejected";
                                context.SaveChanges();
                            }
                        }

                        // Update the status in the DataGridView
                        RefreshPendingRequests();
                        RefreshAcceptedRequests();
                        RefreshRejectedRequests();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }

        }
        private void rejectedListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (rejectedListView.Rows[e.RowIndex] != null && e.ColumnIndex == rejectedListView.Columns["Accept"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to perform this action?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Process the result of the confirmation box
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = rejectedListView.Rows[e.RowIndex];
                        int workshopRequestId = Convert.ToInt32(selectedRow.Cells["WorkshopRequestId"].Value);

                        using (var context = new IranProjectContext())
                        {
                            WorkshopRequest workshopRequest = context.WorkshopRequest.FirstOrDefault(wr => wr.WorkshopRequestId == workshopRequestId);
                            if (workshopRequest != null)
                            {
                                workshopRequest.Status = "Accepted";
                                context.SaveChanges();
                            }
                        }

                        // Update the status in the DataGridView
                        RefreshPendingRequests();
                        RefreshAcceptedRequests();
                        RefreshRejectedRequests();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }

        }

        private void RefreshPendingRequests()
        {
            using (var context = new IranProjectContext())
            {
                var pendingRequestsQuery = context.WorkshopRequest
                    .Where(x => x.Status == "Pending")
                    .OrderBy(wr => wr.SaloonId) // First sort by SaloonId
                    .ThenBy(wr => wr.WorkshopTimeId)
                    .Select(wr => new
                    {
                        wr.WorkshopRequestId,
                        wr.User.Fullname,
                        wr.Saloon.SaloonName,
                        wr.WorkshopTime.Description,
                        wr.Date,
                    }).ToList();

                // Assuming pendingBindingSource is accessible at the class level
                pendingBindingSource.DataSource = pendingRequestsQuery;
                RequestListView.DataSource = pendingBindingSource;
            }
        }
        private void RefreshAcceptedRequests()
        {
            using (var context = new IranProjectContext())
            {
                var acceptedRequestsQuery = context.WorkshopRequest
                    .Where(x => x.Status == "Accepted")
                    .OrderBy(wr => wr.SaloonId) // First sort by SaloonId
                    .ThenBy(wr => wr.WorkshopTimeId)
                    .Select(wr => new
                    {
                        wr.WorkshopRequestId,
                        wr.User.Fullname,
                        wr.Saloon.SaloonName,
                        wr.WorkshopTime.Description,
                        wr.Date,
                    }).ToList();

                // Assuming acceptedBindingSource is accessible at the class level
                acceptedBindingSource.DataSource = acceptedRequestsQuery;
                acceptedlistView.DataSource = acceptedBindingSource;
            }
        }

        private void RefreshRejectedRequests()
        {
            using (var context = new IranProjectContext())
            {
                var rejectedRequestsQuery = context.WorkshopRequest
                    .Where(x => x.Status == "Rejected")
                    .Select(wr => new
                    {
                        wr.WorkshopRequestId,
                        wr.User.Fullname,
                        wr.Saloon.SaloonName,
                        wr.WorkshopTime.Description,
                        wr.Date,
                    }).ToList();

                // Assuming rejectedBindingSource is accessible at the class level
                rejectedBindingSource.DataSource = rejectedRequestsQuery;
                rejectedListView.DataSource = rejectedBindingSource;
            }
        }


        private void RequestEvaluation_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rejectedRequestLabel_Click(object sender, EventArgs e)
        {

        }



        private void backButton1_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Home();

            }
            home.Show();
            this.Hide();
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Home();

            }
            home.Show();
            this.Hide();

        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Home();

            }
            home.Show();
            this.Hide();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            using (var context = new IranProjectContext())
            {
                var acceptedRequestsQuery = context.WorkshopRequest
                      .Where(x => x.Status == "Accepted")
                      .OrderBy(wr => wr.SaloonId) // First sort by SaloonId
                      .ThenBy(wr => wr.WorkshopTimeId)
                      .Select(wr => new
                      {
                          wr.WorkshopRequestId,
                          wr.User.Fullname,
                          wr.Saloon.SaloonName,
                          wr.WorkshopTime.Description,
                          wr.Date,
                      });
                var fileId = Guid.NewGuid().ToString().Substring(0, 10);



                string folderPath = "C:\\Users\\hngwu\\OneDrive\\School\\WorldSkills\\Winform\\IranProject\\IranProject\\Reports";
                //string folderPath = "../../Reports";
                //string filePath = Path.Combine(folderPath, $"AcceptedRequests-{DateTime.Now.Date.toString()}-{fileId}.csv");
                string formattedDate = DateTime.Now.Date.ToString();
                string filePath = $"AcceptedRequests-{DateTime.Now.Date.ToString("yyyy-MM-dd")}-{fileId}.csv";
                string combinedPath = Path.Combine(folderPath, filePath);
                try
                {
                    using (StreamWriter writer = new StreamWriter(combinedPath))
                    {
                        // Write header
                        writer.WriteLine("WorkshopRequestId,Fullname,SaloonName,Time,Date");

                        // Write data
                        foreach (var entry in acceptedRequestsQuery)
                        {
                            writer.WriteLine($"{entry.WorkshopRequestId},{entry.Fullname},{entry.SaloonName},{entry.Description},{entry.Date}");
                        }
                    }
                    Process.Start(new ProcessStartInfo(combinedPath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating or opening the CSV file: " + ex.Message);
                    //MessageBox.Show(ex.InnerException.ToString);
                }


            }
        }
    }
}
