// Auth: John O'Neal
// Date: 04/03/2024
// Desc: Registration control for the tax application. This allows users to register for an account.

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class RegistrationControl : UserControl
    {
        public RegistrationControl()
        {
            InitializeComponent();
            Utils.SetEnterKeyBehavior(UsernameTextBox, RegisterButton_Click);
            Utils.SetEnterKeyBehavior(PasswordTextBox, RegisterButton_Click);
            Utils.SetEnterKeyBehavior(ReEnterPasswordTextBox, RegisterButton_Click);
            RoleComboBox.SelectedIndex = 0;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text) || string.IsNullOrEmpty(ReEnterPasswordTextBox.Text))
            {
                Utils.ShowErrorMessage("Username or Password field is empty.", "Registration Failed");
                Utils.ClearAndFocus(UsernameTextBox, PasswordTextBox, ReEnterPasswordTextBox);
                return;
            }

            var checkParameters = new Dictionary<string, object> { { "@username", UsernameTextBox.Text } };
            var result = DatabaseHelper.ExecuteSelectQuery("SELECT * FROM users WHERE username = @username", checkParameters);

            if (result.Rows.Count > 0)
            {
                Utils.ShowErrorMessage("Username already exists.", "Registration Failed");
                Utils.ClearAndFocus(UsernameTextBox);
                return;
            }

            if (RoleComboBox.SelectedIndex == -1 || UsernameTextBox.Text.Length > 50 || PasswordTextBox.Text != ReEnterPasswordTextBox.Text)
            {
                Utils.ShowErrorMessage("Please correct your input.", "Registration Failed");
                Utils.ClearAndFocus(UsernameTextBox, PasswordTextBox, ReEnterPasswordTextBox);
                return;
            }

            var insertParameters = new Dictionary<string, object>
            {
                { "@username", UsernameTextBox.Text },
                { "@password", Utils.ComputeHash(PasswordTextBox.Text) },
                { "@role", RoleComboBox.Text }
            };

            DatabaseHelper.ExecuteNonSelectQuery("INSERT INTO users (username, password_hash, role) VALUES (@username, @password, @role)", insertParameters);

            MessageBox.Show("Registration Successful.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SwitchToLogin();*/
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            SwitchToLogin();
        }

        private void SwitchToLogin()
        {
            var taxAppForm = (TaxAppForm)this.Parent;
            taxAppForm.SwitchToLogin();
            ((LoginControl)taxAppForm.CurrentControl).SetUsername(UsernameTextBox.Text);
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Utils.ShowPassword(PasswordTextBox, ShowPasswordCheckBox);
            Utils.ShowPassword(ReEnterPasswordTextBox, ShowPasswordCheckBox);
        }

        public void FocusUsername()
        {
            UsernameTextBox.Focus();
        }
    }
}