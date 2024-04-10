namespace TaxApp_v2.Admin_User_Controls
{
    partial class LoginControl
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
            LoginTitleLabel = new Label();
            ShowPasswordCheckBox = new CheckBox();
            RegisterButton = new Button();
            LoginButton = new Button();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            SuspendLayout();
            // 
            // LoginTitleLabel
            // 
            LoginTitleLabel.AutoSize = true;
            LoginTitleLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTitleLabel.Location = new Point(97, 0);
            LoginTitleLabel.Margin = new Padding(4, 0, 4, 0);
            LoginTitleLabel.Name = "LoginTitleLabel";
            LoginTitleLabel.Size = new Size(72, 24);
            LoginTitleLabel.TabIndex = 9;
            LoginTitleLabel.Text = "LOGIN";
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Location = new Point(168, 92);
            ShowPasswordCheckBox.Margin = new Padding(4, 4, 4, 4);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(108, 19);
            ShowPasswordCheckBox.TabIndex = 14;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(144, 119);
            RegisterButton.Margin = new Padding(4, 4, 4, 4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(88, 26);
            RegisterButton.TabIndex = 16;
            RegisterButton.Text = "&Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(49, 119);
            LoginButton.Margin = new Padding(4, 4, 4, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(88, 26);
            LoginButton.TabIndex = 15;
            LoginButton.Text = "&Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginBtn_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(1, 66);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 12;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(68, 62);
            PasswordTextBox.Margin = new Padding(4, 4, 4, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(210, 23);
            PasswordTextBox.TabIndex = 13;
            PasswordTextBox.Text = "testing";
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(1, 36);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 10;
            UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(68, 32);
            UsernameTextBox.Margin = new Padding(4, 4, 4, 4);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(210, 23);
            UsernameTextBox.TabIndex = 11;
            UsernameTextBox.Text = "testing";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoginTitleLabel);
            Controls.Add(ShowPasswordCheckBox);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameTextBox);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginControl";
            RightToLeft = RightToLeft.No;
            Size = new Size(280, 146);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
    }
}
