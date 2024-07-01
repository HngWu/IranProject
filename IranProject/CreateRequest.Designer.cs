namespace IranProject
{
    partial class CreateRequest
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
            this.createRequestLabel = new System.Windows.Forms.Label();
            this.saloonComboBox = new System.Windows.Forms.ComboBox();
            this.SaloonLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.workshopTimeLabel = new System.Windows.Forms.Label();
            this.workshoptimeComboBox = new System.Windows.Forms.ComboBox();
            this.workshopDateLabel = new System.Windows.Forms.Label();
            this.submitRequestbutton = new System.Windows.Forms.Button();
            this.workshopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // createRequestLabel
            // 
            this.createRequestLabel.AutoSize = true;
            this.createRequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRequestLabel.Location = new System.Drawing.Point(270, 40);
            this.createRequestLabel.Name = "createRequestLabel";
            this.createRequestLabel.Size = new System.Drawing.Size(238, 37);
            this.createRequestLabel.TabIndex = 0;
            this.createRequestLabel.Text = "Create Request";
            // 
            // saloonComboBox
            // 
            this.saloonComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saloonComboBox.FormattingEnabled = true;
            this.saloonComboBox.Location = new System.Drawing.Point(153, 157);
            this.saloonComboBox.Name = "saloonComboBox";
            this.saloonComboBox.Size = new System.Drawing.Size(214, 39);
            this.saloonComboBox.TabIndex = 1;
            // 
            // SaloonLabel
            // 
            this.SaloonLabel.AutoSize = true;
            this.SaloonLabel.Location = new System.Drawing.Point(148, 117);
            this.SaloonLabel.Name = "SaloonLabel";
            this.SaloonLabel.Size = new System.Drawing.Size(145, 25);
            this.SaloonLabel.TabIndex = 2;
            this.SaloonLabel.Text = "Select Saloon";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(426, 117);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(165, 25);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Select Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(431, 157);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(214, 39);
            this.CategoryComboBox.TabIndex = 3;
            // 
            // workshopTimeLabel
            // 
            this.workshopTimeLabel.AutoSize = true;
            this.workshopTimeLabel.Location = new System.Drawing.Point(426, 242);
            this.workshopTimeLabel.Name = "workshopTimeLabel";
            this.workshopTimeLabel.Size = new System.Drawing.Size(228, 25);
            this.workshopTimeLabel.TabIndex = 8;
            this.workshopTimeLabel.Text = "Select Workshop Time";
            // 
            // workshoptimeComboBox
            // 
            this.workshoptimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshoptimeComboBox.FormattingEnabled = true;
            this.workshoptimeComboBox.Location = new System.Drawing.Point(431, 282);
            this.workshoptimeComboBox.Name = "workshoptimeComboBox";
            this.workshoptimeComboBox.Size = new System.Drawing.Size(214, 39);
            this.workshoptimeComboBox.TabIndex = 7;
            // 
            // workshopDateLabel
            // 
            this.workshopDateLabel.AutoSize = true;
            this.workshopDateLabel.Location = new System.Drawing.Point(148, 242);
            this.workshopDateLabel.Name = "workshopDateLabel";
            this.workshopDateLabel.Size = new System.Drawing.Size(226, 25);
            this.workshopDateLabel.TabIndex = 6;
            this.workshopDateLabel.Text = "Select Workshop Date";
            // 
            // submitRequestbutton
            // 
            this.submitRequestbutton.Location = new System.Drawing.Point(545, 367);
            this.submitRequestbutton.Name = "submitRequestbutton";
            this.submitRequestbutton.Size = new System.Drawing.Size(99, 44);
            this.submitRequestbutton.TabIndex = 9;
            this.submitRequestbutton.Text = "Submit";
            this.submitRequestbutton.UseVisualStyleBackColor = true;
            this.submitRequestbutton.Click += new System.EventHandler(this.submitRequestbutton_Click);
            // 
            // workshopDateTimePicker
            // 
            this.workshopDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopDateTimePicker.Location = new System.Drawing.Point(153, 283);
            this.workshopDateTimePicker.Name = "workshopDateTimePicker";
            this.workshopDateTimePicker.Size = new System.Drawing.Size(214, 38);
            this.workshopDateTimePicker.TabIndex = 10;
            // 
            // CreateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workshopDateTimePicker);
            this.Controls.Add(this.submitRequestbutton);
            this.Controls.Add(this.workshopTimeLabel);
            this.Controls.Add(this.workshoptimeComboBox);
            this.Controls.Add(this.workshopDateLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.SaloonLabel);
            this.Controls.Add(this.saloonComboBox);
            this.Controls.Add(this.createRequestLabel);
            this.Name = "CreateRequest";
            this.Text = "CreateRequest";
            this.Load += new System.EventHandler(this.CreateRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createRequestLabel;
        private System.Windows.Forms.ComboBox saloonComboBox;
        private System.Windows.Forms.Label SaloonLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label workshopTimeLabel;
        private System.Windows.Forms.ComboBox workshoptimeComboBox;
        private System.Windows.Forms.Label workshopDateLabel;
        private System.Windows.Forms.Button submitRequestbutton;
        private System.Windows.Forms.DateTimePicker workshopDateTimePicker;
    }
}