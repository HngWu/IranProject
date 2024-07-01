namespace IranProject
{
    partial class CreateSurvey
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
            this.endDateLabel = new System.Windows.Forms.Label();
            this.createSurveyButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.surveyNameLabel = new System.Windows.Forms.Label();
            this.createSurveyLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.surveyNameTextbox = new System.Windows.Forms.TextBox();
            this.surveyOptionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addoptionButton = new System.Windows.Forms.Button();
            this.surveyOptionLabel = new System.Windows.Forms.Label();
            this.delOptionbutton = new System.Windows.Forms.Button();
            this.endDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(413, 113);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(101, 25);
            this.endDateLabel.TabIndex = 37;
            this.endDateLabel.Text = "End Date";
            this.endDateLabel.Click += new System.EventHandler(this.endDateLabel_Click);
            // 
            // createSurveyButton
            // 
            this.createSurveyButton.Location = new System.Drawing.Point(100, 562);
            this.createSurveyButton.Name = "createSurveyButton";
            this.createSurveyButton.Size = new System.Drawing.Size(605, 46);
            this.createSurveyButton.TabIndex = 33;
            this.createSurveyButton.Text = "Create";
            this.createSurveyButton.UseVisualStyleBackColor = true;
            this.createSurveyButton.Click += new System.EventHandler(this.createSurveyButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(95, 221);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(98, 25);
            this.questionLabel.TabIndex = 36;
            this.questionLabel.Text = "Question";
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // surveyNameLabel
            // 
            this.surveyNameLabel.AutoSize = true;
            this.surveyNameLabel.Location = new System.Drawing.Point(95, 113);
            this.surveyNameLabel.Name = "surveyNameLabel";
            this.surveyNameLabel.Size = new System.Drawing.Size(141, 25);
            this.surveyNameLabel.TabIndex = 35;
            this.surveyNameLabel.Text = "Survey Name";
            this.surveyNameLabel.Click += new System.EventHandler(this.surveyNameLabel_Click);
            // 
            // createSurveyLabel
            // 
            this.createSurveyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createSurveyLabel.AutoSize = true;
            this.createSurveyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSurveyLabel.Location = new System.Drawing.Point(234, 28);
            this.createSurveyLabel.Name = "createSurveyLabel";
            this.createSurveyLabel.Size = new System.Drawing.Size(310, 51);
            this.createSurveyLabel.TabIndex = 34;
            this.createSurveyLabel.Text = "Create Survey";
            this.createSurveyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createSurveyLabel.Click += new System.EventHandler(this.createSurveyLabel_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(100, 264);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(287, 40);
            this.QuestionTextBox.TabIndex = 30;
            this.QuestionTextBox.TextChanged += new System.EventHandler(this.QuestionTextBox_TextChanged);
            // 
            // surveyNameTextbox
            // 
            this.surveyNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyNameTextbox.Location = new System.Drawing.Point(100, 156);
            this.surveyNameTextbox.Name = "surveyNameTextbox";
            this.surveyNameTextbox.Size = new System.Drawing.Size(287, 40);
            this.surveyNameTextbox.TabIndex = 29;
            this.surveyNameTextbox.TextChanged += new System.EventHandler(this.surveyNameTextbox_TextChanged);
            // 
            // surveyOptionFlowLayoutPanel
            // 
            this.surveyOptionFlowLayoutPanel.AutoScroll = true;
            this.surveyOptionFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.surveyOptionFlowLayoutPanel.Location = new System.Drawing.Point(100, 369);
            this.surveyOptionFlowLayoutPanel.Name = "surveyOptionFlowLayoutPanel";
            this.surveyOptionFlowLayoutPanel.Size = new System.Drawing.Size(514, 187);
            this.surveyOptionFlowLayoutPanel.TabIndex = 39;
            this.surveyOptionFlowLayoutPanel.WrapContents = false;
            this.surveyOptionFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Items.AddRange(new object[] {
            "Activate",
            "Deactivate"});
            this.StatusCombobox.Location = new System.Drawing.Point(421, 267);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(287, 37);
            this.StatusCombobox.TabIndex = 40;
            this.StatusCombobox.SelectedIndexChanged += new System.EventHandler(this.StatusCombobox_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(416, 221);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 25);
            this.statusLabel.TabIndex = 41;
            this.statusLabel.Text = "Status";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // addoptionButton
            // 
            this.addoptionButton.Location = new System.Drawing.Point(620, 369);
            this.addoptionButton.Name = "addoptionButton";
            this.addoptionButton.Size = new System.Drawing.Size(96, 45);
            this.addoptionButton.TabIndex = 1;
            this.addoptionButton.Text = "Add";
            this.addoptionButton.UseVisualStyleBackColor = true;
            this.addoptionButton.Click += new System.EventHandler(this.addoptionButton_Click);
            // 
            // surveyOptionLabel
            // 
            this.surveyOptionLabel.AutoSize = true;
            this.surveyOptionLabel.Location = new System.Drawing.Point(98, 331);
            this.surveyOptionLabel.Name = "surveyOptionLabel";
            this.surveyOptionLabel.Size = new System.Drawing.Size(159, 25);
            this.surveyOptionLabel.TabIndex = 42;
            this.surveyOptionLabel.Text = "Survey Options";
            this.surveyOptionLabel.Click += new System.EventHandler(this.surveyOptionLabel_Click);
            // 
            // delOptionbutton
            // 
            this.delOptionbutton.Location = new System.Drawing.Point(620, 420);
            this.delOptionbutton.Name = "delOptionbutton";
            this.delOptionbutton.Size = new System.Drawing.Size(96, 45);
            this.delOptionbutton.TabIndex = 43;
            this.delOptionbutton.Text = "Del";
            this.delOptionbutton.UseVisualStyleBackColor = true;
            this.delOptionbutton.Click += new System.EventHandler(this.delOptionbutton_Click);
            // 
            // endDatedateTimePicker
            // 
            this.endDatedateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatedateTimePicker.Location = new System.Drawing.Point(421, 156);
            this.endDatedateTimePicker.Name = "endDatedateTimePicker";
            this.endDatedateTimePicker.Size = new System.Drawing.Size(284, 38);
            this.endDatedateTimePicker.TabIndex = 44;
            this.endDatedateTimePicker.ValueChanged += new System.EventHandler(this.endDatedateTimePicker_ValueChanged);
            // 
            // CreateSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 631);
            this.Controls.Add(this.endDatedateTimePicker);
            this.Controls.Add(this.delOptionbutton);
            this.Controls.Add(this.surveyOptionLabel);
            this.Controls.Add(this.addoptionButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.surveyOptionFlowLayoutPanel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.createSurveyButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.surveyNameLabel);
            this.Controls.Add(this.createSurveyLabel);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.surveyNameTextbox);
            this.Name = "CreateSurvey";
            this.Text = "CreateSurvey";
            this.Load += new System.EventHandler(this.CreateSurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button createSurveyButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label surveyNameLabel;
        private System.Windows.Forms.Label createSurveyLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.TextBox surveyNameTextbox;
        private System.Windows.Forms.FlowLayoutPanel surveyOptionFlowLayoutPanel;
        private System.Windows.Forms.ComboBox StatusCombobox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button addoptionButton;
        private System.Windows.Forms.Label surveyOptionLabel;
        private System.Windows.Forms.Button delOptionbutton;
        private System.Windows.Forms.DateTimePicker endDatedateTimePicker;
    }
}