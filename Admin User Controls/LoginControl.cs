// Auth: John O'Neal
// Date: 04/03/2024
// Desc: Login user control for the tax application. This allows users to log in to the application.

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaxApp_v2.Models.DataLayer;

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
            Utils.SetEnterKeyBehavior(UsernameTextBox, LoginBtn_Click);
            Utils.SetEnterKeyBehavior(PasswordTextBox, LoginBtn_Click);
        }

        TaxAppContext context = new TaxAppContext();
        User user;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                Utils.ShowErrorMessage("Username or Password field is empty.", "Login Failed");
                Utils.ClearAndFocus(UsernameTextBox, PasswordTextBox);
                return;
            }

            user = context.Users.FirstOrDefault(u => u.Username == UsernameTextBox.Text);

            if (user != null)
            {
                string storedPasswordHash = user.PasswordHash;
                if (storedPasswordHash == Utils.ComputeHash(PasswordTextBox.Text))
                {
                    Utils.currentUserId = user.UserId;
                    Utils.currentUsername = user.Username;
                    // Login successful, switch to dashboard
                    ((TaxAppForm)Parent).SwitchTo("Dashboard");
                }
                else
                {
                    Utils.ShowErrorMessage("Incorrect Password.", "Login Failed");
                    Utils.ClearAndFocus(PasswordTextBox);
                }
            }
            else
            {
                Utils.ShowErrorMessage("User does not exist. Please register.", "Login Failed");
                Utils.ClearAndFocus(UsernameTextBox, PasswordTextBox);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            ((TaxAppForm)Parent).SwitchTo("Registration");
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Utils.ShowPassword(PasswordTextBox, ShowPasswordCheckBox);
        }


        // This method is used to set the username text box when it comes from the registration form
        public void SetUsername(string username)
        {
            UsernameTextBox.Text = username;
        }

        public void FocusUsername()
        {
            UsernameTextBox.Focus();
        }
    }
}
