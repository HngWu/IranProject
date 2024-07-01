namespace IranProject
{
    partial class ExhibitorRequestPanel
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
            this.exhibitorRequestGridView = new System.Windows.Forms.DataGridView();
            this.createRequestButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitorRequestGridView)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1355, 80);
            this.groupBox1.TabIndex = 4;
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
            // exhibitorRequestGridView
            // 
            this.exhibitorRequestGridView.AllowUserToOrderColumns = true;
            this.exhibitorRequestGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exhibitorRequestGridView.ColumnHeadersHeight = 30;
            this.exhibitorRequestGridView.Location = new System.Drawing.Point(22, 174);
            this.exhibitorRequestGridView.Name = "exhibitorRequestGridView";
            this.exhibitorRequestGridView.RowHeadersWidth = 82;
            this.exhibitorRequestGridView.RowTemplate.Height = 33;
            this.exhibitorRequestGridView.Size = new System.Drawing.Size(1303, 644);
            this.exhibitorRequestGridView.TabIndex = 5;
            this.exhibitorRequestGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exhibitorRequestGridView_CellContentClick);
            // 
            // createRequestButton
            // 
            this.createRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createRequestButton.Location = new System.Drawing.Point(1193, 105);
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Size = new System.Drawing.Size(132, 46);
            this.createRequestButton.TabIndex = 6;
            this.createRequestButton.Text = "Create";
            this.createRequestButton.UseVisualStyleBackColor = true;
            this.createRequestButton.Click += new System.EventHandler(this.createRequestButton_Click);
            // 
            // ExhibitorRequestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 840);
            this.Controls.Add(this.createRequestButton);
            this.Controls.Add(this.exhibitorRequestGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExhibitorRequestPanel";
            this.Text = "ExhibitorRequestPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitorRequestGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label votingSurveyLabel;
        private System.Windows.Forms.Label requestWorkshopLabel;
        private System.Windows.Forms.DataGridView exhibitorRequestGridView;
        private System.Windows.Forms.Button createRequestButton;
    }
}