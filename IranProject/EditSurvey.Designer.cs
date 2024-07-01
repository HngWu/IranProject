namespace IranProject
{
    partial class EditSurvey
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
            this.endDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.delOptionbutton = new System.Windows.Forms.Button();
            this.surveyOptionLabel = new System.Windows.Forms.Label();
            this.addoptionButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.surveyOptionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.editSurveyButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.surveyNameLabel = new System.Windows.Forms.Label();
            this.editSurveyLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.surveyNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // endDatedateTimePicker
            // 
            this.endDatedateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatedateTimePicker.Location = new System.Drawing.Point(416, 152);
            this.endDatedateTimePicker.Name = "endDatedateTimePicker";
            this.endDatedateTimePicker.Size = new System.Drawing.Size(284, 38);
            this.endDatedateTimePicker.TabIndex = 58;
            // 
            // delOptionbutton
            // 
            this.delOptionbutton.Location = new System.Drawing.Point(615, 416);
            this.delOptionbutton.Name = "delOptionbutton";
            this.delOptionbutton.Size = new System.Drawing.Size(96, 45);
            this.delOptionbutton.TabIndex = 57;
            this.delOptionbutton.Text = "Del";
            this.delOptionbutton.UseVisualStyleBackColor = true;
            this.delOptionbutton.Click += new System.EventHandler(this.delOptionbutton_Click);
            // 
            // surveyOptionLabel
            // 
            this.surveyOptionLabel.AutoSize = true;
            this.surveyOptionLabel.Location = new System.Drawing.Point(93, 327);
            this.surveyOptionLabel.Name = "surveyOptionLabel";
            this.surveyOptionLabel.Size = new System.Drawing.Size(159, 25);
            this.surveyOptionLabel.TabIndex = 56;
            this.surveyOptionLabel.Text = "Survey Options";
            // 
            // addoptionButton
            // 
            this.addoptionButton.Location = new System.Drawing.Point(615, 365);
            this.addoptionButton.Name = "addoptionButton";
            this.addoptionButton.Size = new System.Drawing.Size(96, 45);
            this.addoptionButton.TabIndex = 45;
            this.addoptionButton.Text = "Add";
            this.addoptionButton.UseVisualStyleBackColor = true;
            this.addoptionButton.Click += new System.EventHandler(this.addoptionButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(411, 217);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 25);
            this.statusLabel.TabIndex = 55;
            this.statusLabel.Text = "Status";
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Items.AddRange(new object[] {
            "Activate",
            "Deactivate"});
            this.StatusCombobox.Location = new System.Drawing.Point(416, 263);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(287, 37);
            this.StatusCombobox.TabIndex = 54;
            // 
            // surveyOptionFlowLayoutPanel
            // 
            this.surveyOptionFlowLayoutPanel.AutoScroll = true;
            this.surveyOptionFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.surveyOptionFlowLayoutPanel.Location = new System.Drawing.Point(95, 365);
            this.surveyOptionFlowLayoutPanel.Name = "surveyOptionFlowLayoutPanel";
            this.surveyOptionFlowLayoutPanel.Size = new System.Drawing.Size(514, 187);
            this.surveyOptionFlowLayoutPanel.TabIndex = 53;
            this.surveyOptionFlowLayoutPanel.WrapContents = false;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(408, 109);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(101, 25);
            this.endDateLabel.TabIndex = 52;
            this.endDateLabel.Text = "End Date";
            // 
            // editSurveyButton
            // 
            this.editSurveyButton.Location = new System.Drawing.Point(95, 558);
            this.editSurveyButton.Name = "editSurveyButton";
            this.editSurveyButton.Size = new System.Drawing.Size(605, 46);
            this.editSurveyButton.TabIndex = 48;
            this.editSurveyButton.Text = "Edit";
            this.editSurveyButton.UseVisualStyleBackColor = true;
            this.editSurveyButton.Click += new System.EventHandler(this.editSurveyButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(90, 217);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(98, 25);
            this.questionLabel.TabIndex = 51;
            this.questionLabel.Text = "Question";
            // 
            // surveyNameLabel
            // 
            this.surveyNameLabel.AutoSize = true;
            this.surveyNameLabel.Location = new System.Drawing.Point(90, 109);
            this.surveyNameLabel.Name = "surveyNameLabel";
            this.surveyNameLabel.Size = new System.Drawing.Size(141, 25);
            this.surveyNameLabel.TabIndex = 50;
            this.surveyNameLabel.Text = "Survey Name";
            // 
            // editSurveyLabel
            // 
            this.editSurveyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSurveyLabel.AutoSize = true;
            this.editSurveyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSurveyLabel.Location = new System.Drawing.Point(229, 24);
            this.editSurveyLabel.Name = "editSurveyLabel";
            this.editSurveyLabel.Size = new System.Drawing.Size(254, 51);
            this.editSurveyLabel.TabIndex = 49;
            this.editSurveyLabel.Text = "Edit Survey";
            this.editSurveyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(95, 260);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(287, 40);
            this.QuestionTextBox.TabIndex = 47;
            // 
            // surveyNameTextbox
            // 
            this.surveyNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyNameTextbox.Location = new System.Drawing.Point(95, 152);
            this.surveyNameTextbox.Name = "surveyNameTextbox";
            this.surveyNameTextbox.Size = new System.Drawing.Size(287, 40);
            this.surveyNameTextbox.TabIndex = 46;
            // 
            // EditSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.endDatedateTimePicker);
            this.Controls.Add(this.delOptionbutton);
            this.Controls.Add(this.surveyOptionLabel);
            this.Controls.Add(this.addoptionButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.surveyOptionFlowLayoutPanel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.editSurveyButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.surveyNameLabel);
            this.Controls.Add(this.editSurveyLabel);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.surveyNameTextbox);
            this.Name = "EditSurvey";
            this.Text = "EditSurvey";
            this.Load += new System.EventHandler(this.EditSurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDatedateTimePicker;
        private System.Windows.Forms.Button delOptionbutton;
        private System.Windows.Forms.Label surveyOptionLabel;
        private System.Windows.Forms.Button addoptionButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox StatusCombobox;
        private System.Windows.Forms.FlowLayoutPanel surveyOptionFlowLayoutPanel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button editSurveyButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label surveyNameLabel;
        private System.Windows.Forms.Label editSurveyLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.TextBox surveyNameTextbox;
    }
}