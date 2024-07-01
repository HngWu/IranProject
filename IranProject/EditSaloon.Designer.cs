namespace IranProject
{
    partial class EditSaloon
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
            this.editSaloonbutton = new System.Windows.Forms.Button();
            this.SaloonNameLabel = new System.Windows.Forms.Label();
            this.saloonNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editSaloonbutton
            // 
            this.editSaloonbutton.Location = new System.Drawing.Point(232, 260);
            this.editSaloonbutton.Name = "editSaloonbutton";
            this.editSaloonbutton.Size = new System.Drawing.Size(341, 47);
            this.editSaloonbutton.TabIndex = 5;
            this.editSaloonbutton.Text = "Edit";
            this.editSaloonbutton.UseVisualStyleBackColor = true;
            this.editSaloonbutton.Click += new System.EventHandler(this.editSaloonbutton_Click);
            // 
            // SaloonNameLabel
            // 
            this.SaloonNameLabel.AutoSize = true;
            this.SaloonNameLabel.Location = new System.Drawing.Point(227, 143);
            this.SaloonNameLabel.Name = "SaloonNameLabel";
            this.SaloonNameLabel.Size = new System.Drawing.Size(141, 25);
            this.SaloonNameLabel.TabIndex = 4;
            this.SaloonNameLabel.Text = "Saloon Name";
            // 
            // saloonNameTextBox
            // 
            this.saloonNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saloonNameTextBox.Location = new System.Drawing.Point(232, 193);
            this.saloonNameTextBox.Name = "saloonNameTextBox";
            this.saloonNameTextBox.Size = new System.Drawing.Size(341, 38);
            this.saloonNameTextBox.TabIndex = 3;
            // 
            // EditSaloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editSaloonbutton);
            this.Controls.Add(this.SaloonNameLabel);
            this.Controls.Add(this.saloonNameTextBox);
            this.Name = "EditSaloon";
            this.Text = "EditSaloon";
            this.Load += new System.EventHandler(this.EditSaloon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editSaloonbutton;
        private System.Windows.Forms.Label SaloonNameLabel;
        private System.Windows.Forms.TextBox saloonNameTextBox;
    }
}