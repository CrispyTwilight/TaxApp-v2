namespace TaxApp_v2.Admin_User_Controls
{
    partial class RegistrationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.ReEnterPasswordLabel = new System.Windows.Forms.Label();
            this.ReEnterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterTitleLabel = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.BackToLoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Equity partner",
            "Non-equity partner",
            "Intern",
            "Manager",
            "Secretary"});
            this.RoleComboBox.Location = new System.Drawing.Point(104, 107);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(181, 21);
            this.RoleComboBox.TabIndex = 24;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(69, 110);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(29, 13);
            this.RoleLabel.TabIndex = 23;
            this.RoleLabel.Text = "Role";
            // 
            // ReEnterPasswordLabel
            // 
            this.ReEnterPasswordLabel.AutoSize = true;
            this.ReEnterPasswordLabel.Location = new System.Drawing.Point(0, 83);
            this.ReEnterPasswordLabel.Name = "ReEnterPasswordLabel";
            this.ReEnterPasswordLabel.Size = new System.Drawing.Size(98, 13);
            this.ReEnterPasswordLabel.TabIndex = 18;
            this.ReEnterPasswordLabel.Text = "Re-Enter Password";
            // 
            // ReEnterPasswordTextBox
            // 
            this.ReEnterPasswordTextBox.Location = new System.Drawing.Point(104, 80);
            this.ReEnterPasswordTextBox.Name = "ReEnterPasswordTextBox";
            this.ReEnterPasswordTextBox.Size = new System.Drawing.Size(181, 20);
            this.ReEnterPasswordTextBox.TabIndex = 19;
            this.ReEnterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterTitleLabel
            // 
            this.RegisterTitleLabel.AutoSize = true;
            this.RegisterTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTitleLabel.Location = new System.Drawing.Point(85, 0);
            this.RegisterTitleLabel.Name = "RegisterTitleLabel";
            this.RegisterTitleLabel.Size = new System.Drawing.Size(112, 24);
            this.RegisterTitleLabel.TabIndex = 13;
            this.RegisterTitleLabel.Text = "REGISTER";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(183, 136);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ShowPasswordCheckBox.TabIndex = 20;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(148, 157);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 22;
            this.RegisterButton.Text = "&Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BackToLoginButton
            // 
            this.BackToLoginButton.Location = new System.Drawing.Point(48, 157);
            this.BackToLoginButton.Name = "BackToLoginButton";
            this.BackToLoginButton.Size = new System.Drawing.Size(94, 23);
            this.BackToLoginButton.TabIndex = 21;
            this.BackToLoginButton.Text = "Back to &Login";
            this.BackToLoginButton.UseVisualStyleBackColor = true;
            this.BackToLoginButton.Click += new System.EventHandler(this.BackToLoginButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(45, 57);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 16;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(104, 54);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(181, 20);
            this.PasswordTextBox.TabIndex = 17;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(43, 31);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 14;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(104, 28);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(181, 20);
            this.UsernameTextBox.TabIndex = 15;
            // 
            // RegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.ReEnterPasswordLabel);
            this.Controls.Add(this.ReEnterPasswordTextBox);
            this.Controls.Add(this.RegisterTitleLabel);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.BackToLoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Name = "RegistrationControl";
            this.Size = new System.Drawing.Size(287, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label ReEnterPasswordLabel;
        private System.Windows.Forms.TextBox ReEnterPasswordTextBox;
        private System.Windows.Forms.Label RegisterTitleLabel;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button BackToLoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
    }
}
