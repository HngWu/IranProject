namespace IranProject
{
    partial class ExhibitorVotingPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.votingSurveyLabel = new System.Windows.Forms.Label();
            this.requestWorkshopLabel = new System.Windows.Forms.Label();
            this.ExhibitorVotingGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExhibitorVotingGridView)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1334, 80);
            this.groupBox1.TabIndex = 5;
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
            // ExhibitorVotingGridView
            // 
            this.ExhibitorVotingGridView.AllowUserToOrderColumns = true;
            this.ExhibitorVotingGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExhibitorVotingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExhibitorVotingGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ExhibitorVotingGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExhibitorVotingGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExhibitorVotingGridView.Location = new System.Drawing.Point(26, 165);
            this.ExhibitorVotingGridView.Name = "ExhibitorVotingGridView";
            this.ExhibitorVotingGridView.RowHeadersWidth = 82;
            this.ExhibitorVotingGridView.RowTemplate.Height = 33;
            this.ExhibitorVotingGridView.Size = new System.Drawing.Size(1276, 676);
            this.ExhibitorVotingGridView.TabIndex = 6;
            this.ExhibitorVotingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExhibitorVotingGridView_CellContentClick);
            // 
            // ExhibitorVotingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 871);
            this.Controls.Add(this.ExhibitorVotingGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExhibitorVotingPanel";
            this.Text = "ExhibitorVotingPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExhibitorVotingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label votingSurveyLabel;
        private System.Windows.Forms.Label requestWorkshopLabel;
        private System.Windows.Forms.DataGridView ExhibitorVotingGridView;
    }
}