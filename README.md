# CIS285Project
# Student Grade Book Application

## Project Overview
The Student Grade Book Application is a Windows Forms application developed for CIS 285.
It allows instructors to manage student records, enter grades, calculate averages, and
view class-level statistics through a user-friendly graphical interface.

The application supports adding, editing, deleting, saving, and loading student records,
as well as maintaining notes for each student.


## Features
- Add, edit, and delete students
- Support for **8 grades per student**
- Automatic calculation of student averages
- Class summary statistics:
  - Total students
  - Class average
  - Highest and lowest averages
  - Passing student count (>= 70)
- Live input validation for grade fields
- Notes section for each student
- Save and load student data using XML files
- Clean, styled WinForms UI with hover effects


## Technologies Used
- C#
- .NET Windows Forms
- XML Serialization
- LINQ
- Visual Studio


## Project Structure
- **MainForm.cs** – Application logic, event handling, validation, and UI interaction
- **MainForm.Designer.cs** – Auto-generated UI layout and control configuration
- **Models/**
  - `StudentRecord.cs` – Student data model
  - `GradeBook.cs` – Business logic and calculations
- **Services/**
  - `FileStorageService.cs` – XML save/load functionality


## How to Run the Project
1. Open the solution in **Visual Studio**
2. Build the solution
3. Run the project (`Start` button)
4. Use the interface to add students, enter grades, and calculate summaries


## Source Code Reference
This project was developed by the group and was **not adapted from any external
repository or tutorial project**.


## Changes and Enhancements
- Expanded grade support to 8 grades per student
- Added live grade validation with visual feedback
- Implemented class summary statistics using LINQ
- Added XML save/load functionality
- Added per-student notes feature
- Improved UI layout, colors, and usability


## Authors
- Wesley Walling

