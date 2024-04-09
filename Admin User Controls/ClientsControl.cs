// Auth: John O'Neal
// Date: 04/06/2024
// Desc: A user control for the clients tab in the application. This control displays the clients in the database and allows the user to view, add, edit, and delete clients.

using System.Collections.Generic;
using System.Windows.Forms;

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class ClientsControl : UserControl
    {
        public ClientsControl()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {

            //DatabaseHelper.BindDatabaseToDataGridView("clients", ClientsDataGridView);
            DatabaseHelper.SetColumnHeaders(ClientsDataGridView, new List<string>
            {
                "Client ID", "First Name", "Middle Name", "Last Name", "Suffix", "SSN",
                "Birth Date", "Home Phone", "Mobile Phone", "Email", "Address Line 1",
                "Address Line 2", "City", "State", "Zip", "Occupation", "Routing Number",
                "Account Number", "Checking", "Savings", "User ID"
            });
        }
    }
}
