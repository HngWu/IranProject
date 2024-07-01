namespace IranProject
{
    partial class Home
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
            this.welcomeText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exhibitorManagement = new System.Windows.Forms.Label();
            this.votingManagementLabel = new System.Windows.Forms.Label();
            this.SaloonManagementLabel = new System.Windows.Forms.Label();
            this.evaluateRequestsLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(633, 167);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(145, 33);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Welcome!";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1405, 80);
            this.groupBox1.TabIndex = 2;
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
            this.votingManagementLabel.Click += new System.EventHandler(this.votingManagementLabel_Click);
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
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(84, 164);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(117, 44);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 834);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.welcomeText);
            this.Name = "Home";
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label evaluateRequestsLabel;
        private System.Windows.Forms.Label SaloonManagementLabel;
        private System.Windows.Forms.Label exhibitorManagement;
        private System.Windows.Forms.Label votingManagementLabel;
        private System.Windows.Forms.Button LogoutButton;
    }
}