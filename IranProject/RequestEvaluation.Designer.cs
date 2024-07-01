namespace IranProject
{
    partial class RequestEvaluation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.acceptedRequestsTab = new System.Windows.Forms.TabControl();
            this.pendingRequestPage = new System.Windows.Forms.TabPage();
            this.backButton1 = new System.Windows.Forms.Button();
            this.RequestListView = new System.Windows.Forms.DataGridView();
            this.acceptedRequestsPage = new System.Windows.Forms.TabPage();
            this.backButton2 = new System.Windows.Forms.Button();
            this.acceptedlistView = new System.Windows.Forms.DataGridView();
            this.rejectedRequestsPage = new System.Windows.Forms.TabPage();
            this.rejectedListView = new System.Windows.Forms.DataGridView();
            this.backButton3 = new System.Windows.Forms.Button();
            this.pendingRequestLabel = new System.Windows.Forms.Label();
            this.acceptedRequestsLabel = new System.Windows.Forms.Label();
            this.rejectedRequestLabel = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.acceptedRequestsTab.SuspendLayout();
            this.pendingRequestPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestListView)).BeginInit();
            this.acceptedRequestsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedlistView)).BeginInit();
            this.rejectedRequestsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedListView)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptedRequestsTab
            // 
            this.acceptedRequestsTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptedRequestsTab.Controls.Add(this.pendingRequestPage);
            this.acceptedRequestsTab.Controls.Add(this.acceptedRequestsPage);
            this.acceptedRequestsTab.Controls.Add(this.rejectedRequestsPage);
            this.acceptedRequestsTab.Location = new System.Drawing.Point(0, 0);
            this.acceptedRequestsTab.Name = "acceptedRequestsTab";
            this.acceptedRequestsTab.SelectedIndex = 0;
            this.acceptedRequestsTab.Size = new System.Drawing.Size(1205, 982);
            this.acceptedRequestsTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.acceptedRequestsTab.TabIndex = 8;
            // 
            // pendingRequestPage
            // 
            this.pendingRequestPage.Controls.Add(this.pendingRequestLabel);
            this.pendingRequestPage.Controls.Add(this.backButton1);
            this.pendingRequestPage.Controls.Add(this.RequestListView);
            this.pendingRequestPage.Location = new System.Drawing.Point(8, 39);
            this.pendingRequestPage.Name = "pendingRequestPage";
            this.pendingRequestPage.Padding = new System.Windows.Forms.Padding(3);
            this.pendingRequestPage.Size = new System.Drawing.Size(1189, 935);
            this.pendingRequestPage.TabIndex = 0;
            this.pendingRequestPage.Text = "Pending Requests";
            this.pendingRequestPage.UseVisualStyleBackColor = true;
            // 
            // backButton1
            // 
            this.backButton1.Location = new System.Drawing.Point(16, 16);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(100, 45);
            this.backButton1.TabIndex = 2;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // RequestListView
            // 
            this.RequestListView.AllowUserToOrderColumns = true;
            this.RequestListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RequestListView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RequestListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RequestListView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RequestListView.DefaultCellStyle = dataGridViewCellStyle5;
            this.RequestListView.Location = new System.Drawing.Point(16, 83);
            this.RequestListView.Name = "RequestListView";
            this.RequestListView.RowHeadersWidth = 82;
            this.RequestListView.RowTemplate.Height = 33;
            this.RequestListView.Size = new System.Drawing.Size(1155, 800);
            this.RequestListView.TabIndex = 1;
            this.RequestListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestListView_CellContentClick);
            // 
            // acceptedRequestsPage
            // 
            this.acceptedRequestsPage.Controls.Add(this.generateReportButton);
            this.acceptedRequestsPage.Controls.Add(this.acceptedRequestsLabel);
            this.acceptedRequestsPage.Controls.Add(this.backButton2);
            this.acceptedRequestsPage.Controls.Add(this.acceptedlistView);
            this.acceptedRequestsPage.Location = new System.Drawing.Point(8, 39);
            this.acceptedRequestsPage.Name = "acceptedRequestsPage";
            this.acceptedRequestsPage.Padding = new System.Windows.Forms.Padding(3);
            this.acceptedRequestsPage.Size = new System.Drawing.Size(1189, 935);
            this.acceptedRequestsPage.TabIndex = 1;
            this.acceptedRequestsPage.Text = "Accepted Requests";
            this.acceptedRequestsPage.UseVisualStyleBackColor = true;
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(19, 20);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(100, 45);
            this.backButton2.TabIndex = 4;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // acceptedlistView
            // 
            this.acceptedlistView.AllowUserToOrderColumns = true;
            this.acceptedlistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptedlistView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.acceptedlistView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.acceptedlistView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.acceptedlistView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.acceptedlistView.DefaultCellStyle = dataGridViewCellStyle7;
            this.acceptedlistView.Location = new System.Drawing.Point(19, 84);
            this.acceptedlistView.Name = "acceptedlistView";
            this.acceptedlistView.RowHeadersWidth = 82;
            this.acceptedlistView.RowTemplate.Height = 33;
            this.acceptedlistView.Size = new System.Drawing.Size(1155, 800);
            this.acceptedlistView.TabIndex = 3;
            this.acceptedlistView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.acceptedlistView_CellContentClick);
            // 
            // rejectedRequestsPage
            // 
            this.rejectedRequestsPage.Controls.Add(this.rejectedRequestLabel);
            this.rejectedRequestsPage.Controls.Add(this.rejectedListView);
            this.rejectedRequestsPage.Controls.Add(this.backButton3);
            this.rejectedRequestsPage.Location = new System.Drawing.Point(8, 39);
            this.rejectedRequestsPage.Name = "rejectedRequestsPage";
            this.rejectedRequestsPage.Padding = new System.Windows.Forms.Padding(3);
            this.rejectedRequestsPage.Size = new System.Drawing.Size(1189, 935);
            this.rejectedRequestsPage.TabIndex = 2;
            this.rejectedRequestsPage.Text = "Rejected Requests";
            this.rejectedRequestsPage.UseVisualStyleBackColor = true;
            // 
            // rejectedListView
            // 
            this.rejectedListView.AllowUserToOrderColumns = true;
            this.rejectedListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rejectedListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rejectedListView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rejectedListView.ColumnHeadersHeight = 46;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rejectedListView.DefaultCellStyle = dataGridViewCellStyle8;
            this.rejectedListView.Location = new System.Drawing.Point(17, 81);
            this.rejectedListView.Name = "rejectedListView";
            this.rejectedListView.RowHeadersWidth = 82;
            this.rejectedListView.RowTemplate.Height = 33;
            this.rejectedListView.Size = new System.Drawing.Size(1155, 800);
            this.rejectedListView.TabIndex = 6;
            this.rejectedListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rejectedListView_CellContentClick);
            // 
            // backButton3
            // 
            this.backButton3.Location = new System.Drawing.Point(17, 17);
            this.backButton3.Name = "backButton3";
            this.backButton3.Size = new System.Drawing.Size(100, 45);
            this.backButton3.TabIndex = 5;
            this.backButton3.Text = "Back";
            this.backButton3.UseVisualStyleBackColor = true;
            this.backButton3.Click += new System.EventHandler(this.backButton3_Click);
            // 
            // pendingRequestLabel
            // 
            this.pendingRequestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pendingRequestLabel.AutoSize = true;
            this.pendingRequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingRequestLabel.Location = new System.Drawing.Point(464, 20);
            this.pendingRequestLabel.Name = "pendingRequestLabel";
            this.pendingRequestLabel.Size = new System.Drawing.Size(236, 31);
            this.pendingRequestLabel.TabIndex = 3;
            this.pendingRequestLabel.Text = "Pending Requests";
            this.pendingRequestLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // acceptedRequestsLabel
            // 
            this.acceptedRequestsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptedRequestsLabel.AutoSize = true;
            this.acceptedRequestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedRequestsLabel.Location = new System.Drawing.Point(464, 24);
            this.acceptedRequestsLabel.Name = "acceptedRequestsLabel";
            this.acceptedRequestsLabel.Size = new System.Drawing.Size(251, 31);
            this.acceptedRequestsLabel.TabIndex = 5;
            this.acceptedRequestsLabel.Text = "Accepted Requests";
            this.acceptedRequestsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rejectedRequestLabel
            // 
            this.rejectedRequestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rejectedRequestLabel.AutoSize = true;
            this.rejectedRequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedRequestLabel.Location = new System.Drawing.Point(464, 21);
            this.rejectedRequestLabel.Name = "rejectedRequestLabel";
            this.rejectedRequestLabel.Size = new System.Drawing.Size(245, 31);
            this.rejectedRequestLabel.TabIndex = 7;
            this.rejectedRequestLabel.Text = "Rejected Requests";
            this.rejectedRequestLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateReportButton.Location = new System.Drawing.Point(978, 20);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(196, 45);
            this.generateReportButton.TabIndex = 6;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // RequestEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 982);
            this.Controls.Add(this.acceptedRequestsTab);
            this.Name = "RequestEvaluation";
            this.Text = "RequestEvaluation";
            this.Load += new System.EventHandler(this.RequestEvaluation_Load);
            this.acceptedRequestsTab.ResumeLayout(false);
            this.pendingRequestPage.ResumeLayout(false);
            this.pendingRequestPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestListView)).EndInit();
            this.acceptedRequestsPage.ResumeLayout(false);
            this.acceptedRequestsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedlistView)).EndInit();
            this.rejectedRequestsPage.ResumeLayout(false);
            this.rejectedRequestsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl acceptedRequestsTab;
        private System.Windows.Forms.TabPage pendingRequestPage;
        private System.Windows.Forms.DataGridView RequestListView;
        private System.Windows.Forms.TabPage acceptedRequestsPage;
        private System.Windows.Forms.DataGridView acceptedlistView;
        private System.Windows.Forms.TabPage rejectedRequestsPage;
        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Button backButton3;
        private System.Windows.Forms.DataGridView rejectedListView;
        private System.Windows.Forms.Label pendingRequestLabel;
        private System.Windows.Forms.Label acceptedRequestsLabel;
        private System.Windows.Forms.Label rejectedRequestLabel;
        private System.Windows.Forms.Button generateReportButton;
    }
}