// Auth: John O'Neal
// Date: 04/06/2024
// Desc: A user control for the clients tab in the application. This control displays the clients in the database and allows the user to view, add, edit, and delete clients.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxApp_v2.Models.DataLayer;

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class ClientControl : UserControl
    {
        TaxAppContext context = new TaxAppContext();
        Client client;
        public ClientControl()
        {
            InitializeComponent();
            InitializeDataGridView();

            client = context.Clients.FirstOrDefault();
            DisplayClients();
        }



        private void InitializeDataGridView()
        {

            /*DatabaseHelper.BindDatabaseToDataGridView("clients", ClientsDataGridView);
            DatabaseHelper.SetColumnHeaders(ClientsDataGridView, new List<string>
            {
                "Client ID", "First Name", "Middle Name", "Last Name", "Suffix", "SSN",
                "Birth Date", "Home Phone", "Mobile Phone", "Email", "Address Line 1",
                "Address Line 2", "City", "State", "Zip", "Occupation", "Routing Number",
                "Account Number", "Checking", "Savings", "User ID"
            });*/
        }

        private void DisplayClients()
        {
            if (client != null)
            {
                first_nameTextBox.Text = client.FirstName;
                middle_nameTextBox.Text = client.MiddleName;
                last_nameTextBox.Text = client.LastName;
                suffixTextBox.Text = client.Suffix;
                ssnTextBox.Text = client.Ssn;
                birth_dateDateTimePicker.Value = client.BirthDate.HasValue ? client.BirthDate.Value.ToDateTime(TimeOnly.MinValue) : DateTime.Now;
                home_phoneTextBox.Text = client.HomePhone;
                mobile_phoneTextBox.Text = client.MobilePhone;
                emailTextBox.Text = client.Email;
                address_line1TextBox.Text = client.AddressLine1;
                address_line2TextBox.Text = client.AddressLine2;
                cityTextBox.Text = client.City;
                stateTextBox.Text = client.State;
                zipTextBox.Text = client.Zip;
                occupationTextBox.Text = client.Occupation;
                routing_numberTextBox.Text = client.RoutingNumber;
                account_numberTextBox.Text = client.AccountNumber;
                checkingRadioButton.Checked = client.Checking.HasValue ? client.Checking.Value : false;
                savingsRadioButton.Checked = client.Savings.HasValue ? client.Savings.Value : false;
                user_idTextBox.Text = client.UserId.ToString();
            }
        }

        private void SetTextBoxTags()
        {
            first_nameTextBox.Tag = "First Name";
            middle_nameTextBox.Tag = "Middle Name";
            last_nameTextBox.Tag = "Last Name";
            suffixTextBox.Tag = "Suffix";
            ssnTextBox.Tag = "SSN";
            birth_dateDateTimePicker.Tag = "Birth Date";
            home_phoneTextBox.Tag = "Home Phone";
            mobile_phoneTextBox.Tag = "Mobile Phone";
            emailTextBox.Tag = "Email";
            address_line1TextBox.Tag = "Address Line 1";
            address_line2TextBox.Tag = "Address Line 2";
            cityTextBox.Tag = "City";
            stateTextBox.Tag = "State";
            zipTextBox.Tag = "Zip";
            occupationTextBox.Tag = "Occupation";
            routing_numberTextBox.Tag = "Routing Number";
            account_numberTextBox.Tag = "Account Number";
            checkingRadioButton.Tag = "Checking";
            savingsRadioButton.Tag = "Savings";
            user_idTextBox.Tag = "User ID";
        }
    }
}

