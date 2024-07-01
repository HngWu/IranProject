namespace IranProject
{
    partial class VotingManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exhibitorManagement = new System.Windows.Forms.Label();
            this.votingManagementLabel = new System.Windows.Forms.Label();
            this.SaloonManagementLabel = new System.Windows.Forms.Label();
            this.evaluateRequestsLabel = new System.Windows.Forms.Label();
            this.votingGridView = new System.Windows.Forms.DataGridView();
            this.createSurveyButton = new System.Windows.Forms.Button();
            this.viewSurveyResultButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.votingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.exhibitorManagement);
            this.groupBox1.Controls.Add(this.votingManagementLabel);
            this.groupBox1.Controls.Add(this.SaloonManagementLabel);
            this.groupBox1.Controls.Add(this.evaluateRequestsLabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1394, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // exhibitorManagement
            // 
            this.exhibitorManagement.AutoSize = true;
            this.exhibitorManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exhibitorManagement.Location = new System.Drawing.Point(573, 27);
            this.exhibitorManagement.Name = "exhibitorManagement";
            this.exhibitorManagement.Size = new System.Drawing.Size(247, 25);
            this.exhibitorManagement.TabIndex = 3;
            this.exhibitorManagement.Text = "Exhibitor Management";
            this.exhibitorManagement.Click += new System.EventHandler(this.exhibitorManagement_Click);
            // 
            // votingManagementLabel
            // 
            this.votingManagementLabel.AutoSize = true;
            this.votingManagementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votingManagementLabel.Location = new System.Drawing.Point(45, 27);
            this.votingManagementLabel.Name = "votingManagementLabel";
            this.votingManagementLabel.Size = new System.Drawing.Size(221, 25);
            this.votingManagementLabel.TabIndex = 2;
            this.votingManagementLabel.Text = "Voting Management";
            // 
            // SaloonManagementLabel
            // 
            this.SaloonManagementLabel.AutoSize = true;
            this.SaloonManagementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaloonManagementLabel.Location = new System.Drawing.Point(305, 27);
            this.SaloonManagementLabel.Name = "SaloonManagementLabel";
            this.SaloonManagementLabel.Size = new System.Drawing.Size(227, 25);
            this.SaloonManagementLabel.TabIndex = 1;
            this.SaloonManagementLabel.Text = "Saloon Management";
            this.SaloonManagementLabel.Click += new System.EventHandler(this.SaloonManagementLabel_Click);
            // 
            // evaluateRequestsLabel
            // 
            this.evaluateRequestsLabel.AutoSize = true;
            this.evaluateRequestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluateRequestsLabel.Location = new System.Drawing.Point(857, 27);
            this.evaluateRequestsLabel.Name = "evaluateRequestsLabel";
            this.evaluateRequestsLabel.Size = new System.Drawing.Size(217, 25);
            this.evaluateRequestsLabel.TabIndex = 0;
            this.evaluateRequestsLabel.Text = "Request Evaluation";
            this.evaluateRequestsLabel.Click += new System.EventHandler(this.evaluateRequestsLabel_Click);
            // 
            // votingGridView
            // 
            this.votingGridView.AllowUserToOrderColumns = true;
            this.votingGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.votingGridView.ColumnHeadersHeight = 30;
            this.votingGridView.Location = new System.Drawing.Point(42, 217);
            this.votingGridView.Name = "votingGridView";
            this.votingGridView.RowHeadersWidth = 82;
            this.votingGridView.RowTemplate.Height = 33;
            this.votingGridView.Size = new System.Drawing.Size(1303, 600);
            this.votingGridView.TabIndex = 5;
            this.votingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.votingGridView_CellContentClick);
            // 
            // createSurveyButton
            // 
            this.createSurveyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSurveyButton.Location = new System.Drawing.Point(1213, 132);
            this.createSurveyButton.Name = "createSurveyButton";
            this.createSurveyButton.Size = new System.Drawing.Size(132, 46);
            this.createSurveyButton.TabIndex = 6;
            this.createSurveyButton.Text = "Create";
            this.createSurveyButton.UseVisualStyleBackColor = true;
            this.createSurveyButton.Click += new System.EventHandler(this.createSurveyButton_Click);
            // 
            // viewSurveyResultButton
            // 
            this.viewSurveyResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSurveyResultButton.Location = new System.Drawing.Point(1002, 132);
            this.viewSurveyResultButton.Name = "viewSurveyResultButton";
            this.viewSurveyResultButton.Size = new System.Drawing.Size(178, 46);
            this.viewSurveyResultButton.TabIndex = 7;
            this.viewSurveyResultButton.Text = "View Results";
            this.viewSurveyResultButton.UseVisualStyleBackColor = true;
            // 
            // VotingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 866);
            this.Controls.Add(this.viewSurveyResultButton);
            this.Controls.Add(this.createSurveyButton);
            this.Controls.Add(this.votingGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "VotingManagement";
            this.Text = "VotingManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.votingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label exhibitorManagement;
        private System.Windows.Forms.Label votingManagementLabel;
        private System.Windows.Forms.Label SaloonManagementLabel;
        private System.Windows.Forms.Label evaluateRequestsLabel;
        private System.Windows.Forms.DataGridView votingGridView;
        private System.Windows.Forms.Button createSurveyButton;
        private System.Windows.Forms.Button viewSurveyResultButton;
    }
}