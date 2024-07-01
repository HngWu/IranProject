namespace IranProject
{
    partial class Signup
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
            this.loginLinkLabel = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.telLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.SignupLabel = new System.Windows.Forms.Label();
            this.telephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLinkLabel
            // 
            this.loginLinkLabel.AutoSize = true;
            this.loginLinkLabel.Location = new System.Drawing.Point(372, 302);
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.Size = new System.Drawing.Size(321, 25);
            this.loginLinkLabel.TabIndex = 13;
            this.loginLinkLabel.Text = "Already have an account? Login";
            this.loginLinkLabel.Click += new System.EventHandler(this.loginLinkLabel_Click);
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(88, 350);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(605, 46);
            this.signupButton.TabIndex = 5;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(83, 206);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(195, 25);
            this.telLabel.TabIndex = 11;
            this.telLabel.Text = "Telephone Number";
            this.telLabel.Click += new System.EventHandler(this.telLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(83, 98);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(110, 25);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLabel.Location = new System.Drawing.Point(307, 21);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(163, 51);
            this.SignupLabel.TabIndex = 9;
            this.SignupLabel.Text = "Signup";
            this.SignupLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SignupLabel.Click += new System.EventHandler(this.SignupLabel_Click);
            // 
            // telephoneNumberTextBox
            // 
            this.telephoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telephoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneNumberTextBox.Location = new System.Drawing.Point(88, 249);
            this.telephoneNumberTextBox.Name = "telephoneNumberTextBox";
            this.telephoneNumberTextBox.Size = new System.Drawing.Size(287, 40);
            this.telephoneNumberTextBox.TabIndex = 2;
            this.telephoneNumberTextBox.TextChanged += new System.EventHandler(this.telephoneNumberTextBox_TextChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(88, 141);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(287, 40);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(401, 206);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 25);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(401, 98);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(109, 25);
            this.fullNameLabel.TabIndex = 16;
            this.fullNameLabel.Text = "Full Name";
            this.fullNameLabel.Click += new System.EventHandler(this.fullNameLabel_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(406, 249);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(287, 40);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTextBox.Location = new System.Drawing.Point(406, 141);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(287, 40);
            this.fullNameTextBox.TabIndex = 3;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.fullNameTextBox_TextChanged);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.loginLinkLabel);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.SignupLabel);
            this.Controls.Add(this.telephoneNumberTextBox);
            this.Controls.Add(this.usernameTextbox);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLinkLabel;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label SignupLabel;
        private System.Windows.Forms.TextBox telephoneNumberTextBox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}