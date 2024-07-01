namespace IranProject
{
    partial class ExhibitorDoSurvey
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
            this.submitSurveybutton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.surveyOptionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // submitSurveybutton
            // 
            this.submitSurveybutton.Location = new System.Drawing.Point(232, 232);
            this.submitSurveybutton.Name = "submitSurveybutton";
            this.submitSurveybutton.Size = new System.Drawing.Size(341, 47);
            this.submitSurveybutton.TabIndex = 5;
            this.submitSurveybutton.Text = "Submit";
            this.submitSurveybutton.UseVisualStyleBackColor = true;
            this.submitSurveybutton.Click += new System.EventHandler(this.submitSurveybutton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(225, 98);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(145, 37);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Question";
            // 
            // surveyOptionComboBox
            // 
            this.surveyOptionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyOptionComboBox.FormattingEnabled = true;
            this.surveyOptionComboBox.Location = new System.Drawing.Point(232, 164);
            this.surveyOptionComboBox.Name = "surveyOptionComboBox";
            this.surveyOptionComboBox.Size = new System.Drawing.Size(341, 39);
            this.surveyOptionComboBox.TabIndex = 6;
            // 
            // ExhibitorDoSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.surveyOptionComboBox);
            this.Controls.Add(this.submitSurveybutton);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "ExhibitorDoSurvey";
            this.Text = "ExhibitorDoSurvey";
            this.Load += new System.EventHandler(this.ExhibitorDoSurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitSurveybutton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.ComboBox surveyOptionComboBox;
    }
}