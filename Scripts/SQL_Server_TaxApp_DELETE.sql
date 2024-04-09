-- Auth: John O'Neal
-- Date: 04/08/2024
-- Desc: This SQL Server script will delete all data from the tables testing purposes.

-- Use tax_app_db database
USE tax_app_db;
GO

-- Delete all rows from each table
DELETE FROM form1040_tax_payments;
DELETE FROM form1040_income;
DELETE FROM form1040_dependents;
DELETE FROM form1040;
DELETE FROM schedule_k1;
DELETE FROM form1098e;
DELETE FROM schedule_d_summary;
DELETE FROM schedule_d_long_term;
DELETE FROM schedule_d_short_term;
DELETE FROM schedule_d_metadata;
DELETE FROM w2;
DELETE FROM appointments;
DELETE FROM invoices;
DELETE FROM clients;
DELETE FROM employees;
DELETE FROM users;