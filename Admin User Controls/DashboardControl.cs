// Auth: John O'Neal
// Date: 04/03/2024
// Desc: The dashboard control for the tax application. This control displays the main dashboard for the application and allows users to navigate to different tax forms.

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        // On load, grab the username from the database and display it in the label
        private void DashboardControl_Load(object sender, EventArgs e)
        {
           /* Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@userId", Utils.currentUserId }
                };

            // Execute the query and read the result
            //DataTable result = DatabaseHelper.ExecuteSelectQuery("SELECT username FROM users WHERE user_id = @userId", parameters);

            // Check if result is not null and read the result
            if (result.Rows.Count > 0)
            {
                // If a user is found, display the username in the label
                UsernameLabel.Text = "Welcome, " + result.Rows[0]["username"].ToString() + "!";
            }
            else
            {
                // If no rows are found, display a generic welcome message
                UsernameLabel.Text = "Welcome!";
            }*/

            // Load in the user's tax forms
            LoadTaxUserControls();
        }

        private void LoadTaxUserControls()
        {
            // Load the tax forms for the user
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            // Make the tabbed panel invisible and the admin panel visible
            TaxFormsTabControl.Visible = false;
            AdminPanel.Visible = true;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            // Go back to the LoginControl
            ((TaxAppForm)this.Parent).SwitchToLogin();
        }
    }
}