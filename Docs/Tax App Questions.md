Auth: John O'Neal  
Meeting Date: 03/28/2024

# Questions for tax app

1.  What roles do the application users have (e.g., regular employees, managers, admins)?  
    **Equity partner, Non-equity partner, Intern, Manager, Secretary**

2.	What actions can each user role perform within the application? Are there any differences?  
    **Equity partner - access to their own clients, some NEP clients, and intern clients**  
    **Non-equity partner - access to their own clients and intern clients**  
    **Intern - access to their own clients**  
    **Manager - Basic contact/billing information**  
    **Secretary - Basic contact/billing information**  

3.	Should all tax information be accessible by any user, or do users has specific clients.  
    **Users have their own clients, but there is some overlap as described above.**

4.	Specifically what tax information needs to be calculated? (e.g., income tax, property tax, capital gains tax, inheritance tax).  
    **Inputs/attachments - W2, Schedule D (capital gains), 1098-E (student loan payments), 1099(all), 1098(all), Schedule K-1 (1041 - estates and trusts)**  
    **Outputs - 1040, 1040EZ, 1040A**

5.	Describe the current workflow in detail. Are we replicating this workflow digitally or creating a new system?  
    **The company is a 2-person startup with our client and his partner. Our client handles the business administration side, and the partner meets with clients. The current workflow is that a client calls the business the schedule an appointment, they come in to meet face-to-face, the partner enters the client information into the system, and hits a button to create a tax return.**

6.	Are there any specific tax formulas or rules that need to be applied?

7.	What year’s tax code is this application being written for?  
    **2024**

8.	Do we need to support different tax jurisdictions (federal, state), or is it specific to one?  
    **Focus on Iowa, expand into Minnesota. Needs to output both state and federal.**

9.	Can you provide more details on how the inheritance tax should be handled?

10.	Are there specific rules or regulations regarding inheritance tax that must be implemented? Do you have any documents we can reference?

11.	Will the application need to generate reports or documentation related to wills and inheritance tax or just the resulting 1040 tax return?

12.	What user details are being collected and will need to be stored? (e.g., name, address, email, phone, payment history, bank account info)

13.	How will user information be collected and managed? Is this information entered by an employee?

14.	Will the application need to integrate with any external systems or databases, or is this system entirely self-contained? Describe.  
    **Self contained for security for now.**

15.	Do we need to import/export data from/to other systems?  
    **Importing via scan would be good, but manually typed in is fine for now. Returns should be generated and printable as a doc or pdf.**

16.	Can you provide insights into the preferred user interface design or workflow?

17.	Are there any specific features or functionalities that users expect to see in the application?  
    **None others for now.**

18.	How should users navigate through different sections or tasks within the application?

19.	Should there be only one path from start to finish, or can the user begin anywhere in the application?

20.	What are the expectations regarding testing before deployment? Who can we contact for beta testing and feedback?  
    **The final testing/feedback will be given by the partner.**

21.	Are there any specific performance or scalability requirements for the application?

22.	Will documentation be required for users or administrators of the application?  
    **Basic documentation required.**

23.	Who is responsible for user training?  
    **We will need to train him and partner; they will do all other training.**