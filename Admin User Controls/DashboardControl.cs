// Auth: John O'Neal
// Date: 04/03/2024
// Desc: The dashboard control for the tax application. This control displays the main dashboard for the application and allows users to navigate to different tax forms.

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        // On load, grab the username from utils  and display it in the label
        private void DashboardControl_Load(object sender, EventArgs e)
        {
            // Use the stored username
            UsernameLabel.Text = "Welcome, " + Utils.currentUsername + "!";

            // Load in the appointments view by default
            AppointmentsButton_Click(sender, e);

        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            ClearAdminPanel();
            AppointmentControl appointmentsControl = new AppointmentControl();
            AdminPanel.Controls.Add(appointmentsControl);
            appointmentsControl.Dock = DockStyle.Fill;
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ClearAdminPanel();
            ClientControl clientControl = new ClientControl();
            AdminPanel.Controls.Add(clientControl);
            clientControl.Dock = DockStyle.Fill;
        }


        private void InvoicesButton_Click(object sender, EventArgs e)
        {
            ClearAdminPanel();
            InvoiceControl invoicesControl = new InvoiceControl();
            AdminPanel.Controls.Add(invoicesControl);
            invoicesControl.Dock = DockStyle.Fill;
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            ClearAdminPanel();
            EmployeeControl employeeControl = new EmployeeControl();
            AdminPanel.Controls.Add(employeeControl);
            employeeControl.Dock = DockStyle.Fill;
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            ClearAdminPanel();
            UserControl userControl = new UserControl();
            AdminPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void ClearAdminPanel()
        {
            AdminPanel.Controls.Clear();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            // Display a message box and get the user's response
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Cancel the closing operation if the user clicked No
            if (result == DialogResult.Yes)
            {
                // Go back to the LoginControl
                ((TaxAppForm)Parent).SwitchTo("Login");
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement help button
        }
    }
}