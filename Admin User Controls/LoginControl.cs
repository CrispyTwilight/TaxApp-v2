// Auth: John O'Neal
// Date: 04/03/2024
// Desc: Login user control for the tax application. This allows users to log in to the application.

using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        private void LoginBtn_Click(object sender, EventArgs e)
        {/*
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                Utils.ShowErrorMessage("Username or Password field is empty.", "Login Failed");
                Utils.ClearAndFocus(UsernameTextBox, PasswordTextBox);
                return;
            }

            var parameters = new Dictionary<string, object> { { "@username", UsernameTextBox.Text } };
            var result = DatabaseHelper.ExecuteSelectQuery("SELECT * FROM users WHERE username = @username", parameters);

            if (result.Rows.Count > 0)
            {
                string storedPasswordHash = result.Rows[0]["password_hash"].ToString();
                if (storedPasswordHash == Utils.ComputeHash(PasswordTextBox.Text))
                {
                    Utils.currentUserId = (int)result.Rows[0]["user_id"];
                    ((TaxAppForm)this.Parent).SwitchToDashboard();
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
            }*/
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            ((TaxAppForm)this.Parent).SwitchToRegistration();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Utils.ShowPassword(PasswordTextBox, ShowPasswordCheckBox);
        }

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
