// Auth: John O'Neal
// Date: 04/03/2024
// Desc: The main form for the tax application. This form is the entry point for the application and contains the main logic for switching between different user controls.

using System.Windows.Forms;

namespace TaxApp_v2
{
    public partial class TaxAppForm : Form
    {
        // Keep track of the current UserControl being displayed on the form
        private UserControl currentControl;

        public TaxAppForm()
        {
            InitializeComponent();

            // Show the LoginControl when the form is loaded
            SwitchToLogin();
        }

        // Getter for current UserControl
        public UserControl CurrentControl
        {
            get { return currentControl; }
        }

        public void SwitchToRegistration()
        {
            // Remove the current UserControl
            if (currentControl != null)
                this.Controls.Remove(currentControl);

            // Show the RegistrationControl
            currentControl = new RegistrationControl();
            this.Controls.Add(currentControl);

            // Center the UserControl within the Form
            Utils.CenterControl(currentControl);

            // Set the focus to the UsernameTextBox
            ((RegistrationControl)currentControl).FocusUsername();
        }

        public void SwitchToLogin()
        {
            // Remove the current UserControl
            if (currentControl != null)
                this.Controls.Remove(currentControl);

            // Show the LoginControl
            currentControl = new LoginControl();
            this.Controls.Add(currentControl);

            // Center the UserControl within the Form
            Utils.CenterControl(currentControl);

            // Set the focus to the UsernameTextBox
            ((LoginControl)currentControl).FocusUsername();
        }

        public void SwitchToDashboard()
        {
            // Remove the current UserControl
            if (currentControl != null)
                this.Controls.Remove(currentControl);

            // Show the DashboardControl
            currentControl = new DashboardControl();
            this.Controls.Add(currentControl);
        }

        private void TaxAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a message box and get the user's response
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Cancel the closing operation if the user clicked No
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
