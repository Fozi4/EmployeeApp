# EmployeeApp
# Overview
EmployeeApp is a Windows Forms application designed for managing projects and employees.
It provides separate panels for Admins and Employees, allowing different levels of access and functionality.
Data is stored in a JSON file for simplicity and portability.

# Features
Admin Panel
Add new projects with file or folder attachments.
Assign projects to employees.
Add tasks to projects.
Remove or reassign employees from a project.

# Employee Panel
View all available projects.
Filter projects to show only those assigned to the logged-in employee.
Open project files or related tasks directly from the interface.
Update the project status (e.g., In Work, Done).

# Data Storage
The application stores all project and employee information in projects.json, information about users you can find in users.json.
Each project entry contains:
Project Name
Added By (admin who created the project)
Last Opened By (tracks the last user who opened the project)
Assigned To (employee assigned to the project)
Task (description)
Status (In Work, Done, etc.)


# Requirements
.NET Framework (version 4.7.2 or higher recommended)
Windows OS
Newtonsoft.Json library (via NuGet)

# Installation
Clone this repository:
bash
git clone https://github.com/yourusername/EmployeeApp.git
Open the solution file (.sln) in Visual Studio.
Restore NuGet packages (Newtonsoft.Json).
Build and run the application.

# Usage
Create an account as an employee, or an admin (to create acc as an admin you need the admin code, admin code is 04654).
Login as an admin or employee.
Admins can create and manage projects.
Employees can view assigned projects, open files, and update statuses.
