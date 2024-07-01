namespace IranProject
{
    partial class CreateSaloon
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
            this.saloonNameTextBox = new System.Windows.Forms.TextBox();
            this.SaloonNameLabel = new System.Windows.Forms.Label();
            this.createSaloonbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saloonNameTextBox
            // 
            this.saloonNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saloonNameTextBox.Location = new System.Drawing.Point(234, 170);
            this.saloonNameTextBox.Name = "saloonNameTextBox";
            this.saloonNameTextBox.Size = new System.Drawing.Size(341, 38);
            this.saloonNameTextBox.TabIndex = 0;
            this.saloonNameTextBox.TextChanged += new System.EventHandler(this.saloonNameTextBox_TextChanged);
            // 
            // SaloonNameLabel
            // 
            this.SaloonNameLabel.AutoSize = true;
            this.SaloonNameLabel.Location = new System.Drawing.Point(229, 120);
            this.SaloonNameLabel.Name = "SaloonNameLabel";
            this.SaloonNameLabel.Size = new System.Drawing.Size(141, 25);
            this.SaloonNameLabel.TabIndex = 1;
            this.SaloonNameLabel.Text = "Saloon Name";
            this.SaloonNameLabel.Click += new System.EventHandler(this.SaloonNameLabel_Click);
            // 
            // createSaloonbutton
            // 
            this.createSaloonbutton.Location = new System.Drawing.Point(234, 237);
            this.createSaloonbutton.Name = "createSaloonbutton";
            this.createSaloonbutton.Size = new System.Drawing.Size(341, 47);
            this.createSaloonbutton.TabIndex = 2;
            this.createSaloonbutton.Text = "Create";
            this.createSaloonbutton.UseVisualStyleBackColor = true;
            this.createSaloonbutton.Click += new System.EventHandler(this.createSaloonbutton_Click);
            // 
            // CreateSaloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.createSaloonbutton);
            this.Controls.Add(this.SaloonNameLabel);
            this.Controls.Add(this.saloonNameTextBox);
            this.Name = "CreateSaloon";
            this.Text = "CreateSaloon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saloonNameTextBox;
        private System.Windows.Forms.Label SaloonNameLabel;
        private System.Windows.Forms.Button createSaloonbutton;
    }
}