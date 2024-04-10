// Auth: John O'Neal
// Date: 04/03/2024
// Desc: Registration control for the tax application. This allows users to register for an account.

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaxApp_v2.Models.DataLayer;

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class RegistrationControl : UserControl
    {
        TaxAppContext context = new TaxAppContext();
        User user;

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
            // Input validation
            if (!ValidateInput())
            {
                return;
            }

            // Create new user
            user = new User
            {
                Username = UsernameTextBox.Text,
                PasswordHash = Utils.ComputeHash(PasswordTextBox.Text),
                Role = RoleComboBox.Text
            };

            // Add user to database
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("An error occurred while registering. Please try again later.", "Registration Failed");
                return;
            }

            MessageBox.Show("Registration Successful.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SwitchToLogin();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                Utils.ShowErrorMessage("Username field is empty.", "Registration Failed");
                Utils.ClearAndFocus(UsernameTextBox);
                return false;
            }

            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                Utils.ShowErrorMessage("Password field is empty.", "Registration Failed");
                Utils.ClearAndFocus(PasswordTextBox);
                return false;
            }

            if (string.IsNullOrEmpty(ReEnterPasswordTextBox.Text))
            {
                Utils.ShowErrorMessage("Re-enter Password field is empty.", "Registration Failed");
                Utils.ClearAndFocus(ReEnterPasswordTextBox);
                return false;
            }

            if (RoleComboBox.SelectedIndex == -1)
            {
                Utils.ShowErrorMessage("Role is not selected.", "Registration Failed");
                RoleComboBox.SelectedIndex = 0;
                return false;
            }

            if (UsernameTextBox.Text.Length > 50)
            {
                Utils.ShowErrorMessage("Username is too long. It should be less than 50 characters.", "Registration Failed");
                Utils.ClearAndFocus(UsernameTextBox);
                return false;
            }

            if (PasswordTextBox.Text != ReEnterPasswordTextBox.Text)
            {
                Utils.ShowErrorMessage("Passwords do not match.", "Registration Failed");
                Utils.ClearAndFocus(PasswordTextBox, ReEnterPasswordTextBox);
                return false;
            }

            // Check if username already exists
            user = context.Users.FirstOrDefault(u => u.Username == UsernameTextBox.Text);

            if (user != null)
            {
                Utils.ShowErrorMessage("Username already exists.", "Registration Failed");
                Utils.ClearAndFocus(UsernameTextBox);
                return false;
            }

            return true;
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            SwitchToLogin();
        }

        private void SwitchToLogin()
        {
            var taxAppForm = (TaxAppForm)Parent;
            ((TaxAppForm)Parent).SwitchTo("Login");
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