-- Auth: John O'Neal
-- Date: 04/08/2024
-- Desc: This SQL Server script will select all data from the tables in the database for testing purposes.

-- Use tax_app_db database
USE tax_app_db;
GO

-- Select all rows from each table
SELECT * FROM users;
SELECT * FROM employees;
SELECT * FROM clients;
SELECT * FROM invoices;
SELECT * FROM appointments;
SELECT * FROM w2;
SELECT * FROM schedule_d_metadata;
SELECT * FROM schedule_d_short_term;
SELECT * FROM schedule_d_long_term;
SELECT * FROM schedule_d_summary;
SELECT * FROM form1098e;
SELECT * FROM schedule_k1;
SELECT * FROM form1040;
SELECT * FROM form1040_dependents;
SELECT * FROM form1040_income;
SELECT * FROM form1040_tax_payments;