# Tax App

## Authors
This application was written by John O'Neal and Christian Baack

## Description

This is a .NET Framework application for managing tax forms.

## Installation

1. Clone the repository: `git clone https://github.com/CrispyTwilight/Tax_Application`
2. Open the solution in Visual Studio.
3. Build the solution.

## Usage

### Instructions
1. Open MySQL Workbench and run the SQL script located at Database/TaxApp_CREATE.sql to create the database and tables.
2. Next, open Database/TaxApp_lNSERT_Example.sql and run the script to insert testing data.
3. Pull up Task Manager and make sure a process called "mysqld" is running. It should be, but if it is not, start it by running the command "net start mysqld" in an admin command prompt.
	a. This is a MySQL service that is required for the application to run. If it is not running, the application will not be able to connect to the database.
4. Ensure there is a user called "root" with the password "IowaLakesCIS-332" in the MySQL database. This user should have full access to the database with all privileges.
5. Open the solution in Visual Studio.
6. Click the green "Start" button in Visual Studio to run the application.		
7. Register a new user by clicking the "Register" button on the login screen.
9. Log in with the new user credentials.
10. You can also just click login, as the login prefills with credentials already in the database.

## License

[MIT](https://choosealicense.com/licenses/mit/)
