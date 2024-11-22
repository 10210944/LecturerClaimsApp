Lecturer Claims Application
Overview
The Lecturer Claims Application is a web-based tool designed for lecturers to submit, manage, and review claims for hours worked. It supports functionalities such as creating claims, auto-approvals for certain conditions, and maintaining secure user-specific data.

This application includes:

User registration and authentication
Persistent data storage using SQL Server
Interactive calculation of claims with automated logic for approvals/rejections
Modular design for scalability and future enhancements
Setup Instructions
1. Clone the Repository
2. Configure Database
Open the appsettings.json file and update the connection string
3. Run the Application
Open the solution in Visual Studio.
Set the Startup Project to LecturerClaimsApp.
Run the application:
Press F5 or click Start.
4. Access the Web App
The application will open in your default browser (typically at https://localhost:5001).
Register a new user and start creating claims.
Usage Instructions
User Registration
Navigate to the Register page.
Enter your details and create an account.
Creating a Claim
After logging in, click on Create New Claim.
Fill in the required details:
Lecturer Name: Your name.
Hours Worked: Number of hours worked.
Hourly Rate: Hourly payment rate.
Submit the form to save your claim.
Viewing Claims
The dashboard displays a list of all submitted claims.
Each claim shows:
Total amount
Status (Pending, Approved, Rejected)
Rejection reason, if applicable
Approving/Rejecting Claims
Admin users can approve or reject claims manually via the claims management interface.
Technical Details
Application Structure
Frontend: Razor Pages for dynamic UI
Backend: ASP.NET Core MVC
Database: SQL Server for data persistence
Authentication: ASP.NET Core Identity
Key Libraries Used
Entity Framework Core: For database interactions
Chart.js (Optional): For graphical data visualization
ASP.NET Core Identity: For user management and authentication
