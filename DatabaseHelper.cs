// Auth: John O'Neal
// Date: 04/07/2024
// Desc: Helper class for interacting with the database. This class contains methods for executing select and non-select queries, binding data to a DataGridView, and displaying error messages to the user.

//using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TaxApp_v2
{

    public class DatabaseHelper
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog=tax_app_db;uId=root;password=IowaLakesCIS-332";

        // Generic method to bind any table to a DataGridView
/*        public static void BindDatabaseToDataGridView(string tableName, DataGridView dataGridView)
        {
            string query = $"SELECT * FROM {tableName}";
            DataTable table = ExecuteSelectQuery(query);
            dataGridView.DataSource = table;
        }*/

        // Generic method to set the column headers of a DataGridView
        public static void SetColumnHeaders(DataGridView dataGridView, List<string> headers)
        {
            for (int i = 0; i < headers.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = headers[i];
            }
        }

        // Method to execute a non-select query (INSERT, UPDATE, DELETE)
        /*public static void ExecuteNonSelectQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to execute a select query and return the result as a DataTable
        public static DataTable ExecuteSelectQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
        }*/

        // Show a generic database error message to the user.
        public static void ShowDatabaseErrorMessage()
        {
            MessageBox.Show("An error occurred with the database while processing your request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}