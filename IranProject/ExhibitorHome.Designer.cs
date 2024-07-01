namespace IranProject
{
    partial class ExhibitorHome
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
            this.votingSurveyLabel = new System.Windows.Forms.Label();
            this.requestWorkshopLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.votingSurveyLabel);
            this.groupBox1.Controls.Add(this.requestWorkshopLabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1371, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // votingSurveyLabel
            // 
            this.votingSurveyLabel.AutoSize = true;
            this.votingSurveyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votingSurveyLabel.Location = new System.Drawing.Point(285, 27);
            this.votingSurveyLabel.Name = "votingSurveyLabel";
            this.votingSurveyLabel.Size = new System.Drawing.Size(60, 25);
            this.votingSurveyLabel.TabIndex = 2;
            this.votingSurveyLabel.Text = "Vote";
            this.votingSurveyLabel.Click += new System.EventHandler(this.votingSurveyLabel_Click);
            // 
            // requestWorkshopLabel
            // 
            this.requestWorkshopLabel.AutoSize = true;
            this.requestWorkshopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestWorkshopLabel.Location = new System.Drawing.Point(859, 27);
            this.requestWorkshopLabel.Name = "requestWorkshopLabel";
            this.requestWorkshopLabel.Size = new System.Drawing.Size(211, 25);
            this.requestWorkshopLabel.TabIndex = 1;
            this.requestWorkshopLabel.Text = "Request Workshop";
            this.requestWorkshopLabel.Click += new System.EventHandler(this.requestWorkshopLabel_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(58, 167);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(117, 45);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // welcomeTextLabel
            // 
            this.welcomeTextLabel.AutoSize = true;
            this.welcomeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextLabel.Location = new System.Drawing.Point(575, 175);
            this.welcomeTextLabel.Name = "welcomeTextLabel";
            this.welcomeTextLabel.Size = new System.Drawing.Size(151, 37);
            this.welcomeTextLabel.TabIndex = 5;
            this.welcomeTextLabel.Text = "welcome!";
            // 
            // ExhibitorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 827);
            this.Controls.Add(this.welcomeTextLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExhibitorHome";
            this.Text = "ExhibitorHome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label votingSurveyLabel;
        private System.Windows.Forms.Label requestWorkshopLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label welcomeTextLabel;
    }
}