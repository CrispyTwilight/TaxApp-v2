using Microsoft.SqlServer.Management.Smo;
using System;
using System.Configuration.Provider;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace TaxApp_v2
{
    public class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager(IConfiguration configuration)
        {
            // This connection string will need to be updated to the path of the database on your local machine. Check appsettings.json for the connection string
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        // Tables are being deleted and overwritten with test data each time the application is run. This code is in Program.cs

        public void CreateTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the order in which tables should be dropped
                string[] tablesToDrop = new string[] {
                    "form1040_tax_payments",
                    "form1040_income",
                    "form1040_dependents",
                    "form1040",
                    "schedule_k1",
                    "form1098e",
                    "schedule_d_summary",
                    "schedule_d_long_term",
                    "schedule_d_short_term",
                    "schedule_d_metadata",
                    "w2",
                    "appointments",
                    "invoices",
                    "clients",
                    "employees",
                    "users"
                };

                foreach (string tableName in tablesToDrop)
                {
                    // Drop each table
                    using (SqlCommand command = new SqlCommand($"IF OBJECT_ID('dbo.{tableName}', 'U') IS NOT NULL DROP TABLE dbo.{tableName}", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                // Create tables
                string script = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\Scripts\\SQL_Server_TaxApp_CREATE.sql"));
                ExecuteScript(connection, script);

                // Insert data testing into all tables
                script = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\Scripts\\SQL_Server_TaxApp_INSERT.sql"));
                ExecuteScript(connection, script);
            }
        }

        // Execute a script that contains multiple SQL commands separated by "GO"
        private void ExecuteScript(SqlConnection connection, string script)
        {
            string[] commands = script.Split(new string[] { "GO\r\n", "GO ", "GO\t" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string command in commands)
            {
                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}