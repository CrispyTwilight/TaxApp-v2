// Auth: John O'Neal
// Date: 04/06/2024
// Desc: A user control for the clients tab in the application. This control displays the clients in the database and allows the user to view, add, edit, and delete clients.

using Microsoft.EntityFrameworkCore;
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
using Microsoft.Data.SqlClient;

namespace TaxApp_v2.Admin_User_Controls
{
    public partial class ClientControl : UserControl
    {

        // Create a new instance of the TaxAppContext and a client
        TaxAppContext context = new TaxAppContext();
        Client client;

        public ClientControl()
        {
            InitializeComponent();
            InitializeDataGridView();
            SetTextBoxTags();

            client = context.Clients.FirstOrDefault();
            DisplayClients();
        }

        // Set the tags for the textboxes to be used in message boxes
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
            zipTextBox.Tag = "ZIP";
            occupationTextBox.Tag = "Occupation";
            routing_numberTextBox.Tag = "Routing Number";
            account_numberTextBox.Tag = "Account Number";
            checkingRadioButton.Tag = "Checking";
            savingsRadioButton.Tag = "Savings";
            user_idTextBox.Tag = "User ID";
        }

        // Rename the columns in the DataGridView  to make them more user-friendly
        private void InitializeDataGridView()
        {
            DatabaseHelper.SetColumnHeaders(ClientDataGridView, new List<string>
            {
                "Client ID", "First Name", "Middle Name", "Last Name", "Suffix", "SSN",
                "Birth Date", "Home Phone", "Mobile Phone", "Email", "Address Line 1",
                "Address Line 2", "City", "State", "Zip", "Occupation", "Routing Number",
                "Account Number", "Checking", "Savings", "User ID"
            });
        }

        // Refresh the DataGridView with the latest data
        private void RefreshDataGridView()
        {
            ClientDataGridView.DataSource = context.Clients.ToList();
        }

        // Display the client data in the textboxes
        private void DisplayClients()
        {
            if (client != null)
            {
                client_idTextBox.Text = client.ClientId.ToString();
                first_nameTextBox.Text = client.FirstName;
                middle_nameTextBox.Text = client.MiddleName;
                last_nameTextBox.Text = client.LastName;
                suffixTextBox.Text = client.Suffix;
                ssnTextBox.Text = client.Ssn;
                // fix for .net 7 birth_dateDateTimePicker.Value = client.BirthDate.HasValue ? client.BirthDate.Value.ToDateTime(TimeOnly.MinValue) : DateTime.Now;
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
                RefreshDataGridView();
            }
        }

        private bool ValidateTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show($"{textBox.Tag} is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            // Create a new client
            client = new Client();
            // Put the client ID in the client ID textbox and the user ID in the user ID textbox
            client_idTextBox.Text = client.ClientId.ToString();
            user_idTextBox.Text = client.UserId.ToString();
            ClearControls();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Load the client from the database
            client = context.Clients.Find(client.ClientId);

            // Delete the client
            context.Clients.Remove(client);
            context.SaveChanges();

            // Refresh the DataGridView
            RefreshDataGridView();
        }

        private void LoadOptions()
        {
            // Load the client at the selected client ID
            client = context.Clients.Find(int.Parse(client_idTextBox.Text));
            DisplayClients();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateTextBoxes())
                {
                    MessageBox.Show("Some fields are empty. Do you want to save the data?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                LoadOptions();
                context.SaveChanges();
                ShowSuccessMessage();
            }
            catch (DbUpdateException ex)
            {
                HandleDatabaseError(ex);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            // Refresh the data
            DisplayClients();
            RefreshDataGridView();
        }

        // Update the client data when a cell is clicked in the DataGridView
        private void ClientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ClientDataGridView.Rows[e.RowIndex];

                client = context.Clients.Find(int.Parse(row.Cells["ClientId"].Value.ToString()));
                DisplayClients();
            }
        }

        private void ClearControls()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        // Search bar functionality
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTextBox.Text;
            var clients = context.Clients.Where(c => c.FirstName.Contains(searchValue) ||
                           c.LastName.Contains(searchValue) || c.Ssn.Contains(searchValue) || c.Email.Contains(searchValue)).ToList();
            ClientDataGridView.DataSource = clients;
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            // Show a generic database error message to the user
            DatabaseHelper.ShowDatabaseErrorMessage();

            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlException error in sqlException.Errors)
            {
                errorMessage += $"Error Number: {error.Number}\n" +
                    $"Error Message: {error.Message}\n" +
                    $"Error Procedure: {error.Procedure}\n" +
                    $"Error Line Number: {error.LineNumber}\n\n";
            }
            MessageBox.Show(errorMessage, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage()
        {
            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void TaxFormsButton_Click(object sender, EventArgs e)
        {
            // Create form to display the tax forms
            TabbedTaxFormsForm taxFormsForm = new TabbedTaxFormsForm();
            taxFormsForm.ShowDialog();

        }
    }
}
