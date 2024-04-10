// Auth: John O'Neal
// Date: 04/03/2024
// Desc: The main form for the tax application. This form is the entry point for the application and contains the main logic for switching between different user controls.

using System.Windows.Forms;
using TaxApp_v2.Admin_User_Controls;

namespace TaxApp_v2
{
    public partial class TaxAppForm : Form
    {
        // Keep track of the current UserControl being displayed on the form
        private UserControl currentControl;
        private Dictionary<string, UserControl> controls = new Dictionary<string, UserControl>();

        public TaxAppForm()
        {
            InitializeComponent();

            // Create the UserControls and add them to the dictionary
            controls.Add("Login", new LoginControl());
            controls.Add("Registration", new RegistrationControl());
            controls.Add("Dashboard", new DashboardControl());

            // Show the LoginControl when the form is loaded
            SwitchTo("Login");
        }

        public void SwitchTo(string controlName)
        {
            // Remove the current UserControl
            if (currentControl != null)
                this.Controls.Remove(currentControl);

            // Get the new UserControl from the dictionary
            currentControl = controls[controlName];

            // Add the new UserControl to the form
            this.Controls.Add(currentControl);
            if (controlName == "Dashboard")
            {
                currentControl.Dock = DockStyle.Fill;
            }
            else
            {
                Utils.CenterControl(currentControl);

                // focus username
                if (controlName == "Login")
                {
                    ((LoginControl)currentControl).FocusUsername();
                }
                else if (controlName == "Registration")
                {
                    ((RegistrationControl)currentControl).FocusUsername();
                }
            }
        }

        // Getter for current UserControl
        public UserControl CurrentControl
        {
            get { return currentControl; }
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
