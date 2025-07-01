# StudentManager

A Windows Forms application for managing student records, academic years, and courses using SQLite as the backend database. The application features a hierarchical TreeView for navigation and a ListView for displaying data, with forms for adding, editing, and deleting records.

## Description

StudentManager is a desktop application built with C# and Windows Forms. It allows users to:

- Manage student information (first name, last name, birth date).
- Manage academic years and courses.
- Assign students to courses for specific academic years.
- View and edit data through a user-friendly interface with a TreeView and ListView.

The application uses SQLite for data storage and follows a simple, intuitive design inspired by the Windows File Explorer, with separate forms for editing data.

## Features

- **Hierarchical Navigation**: Use a TreeView to navigate between Students, Academic Years, and Courses.
- **Data Management**: Add, edit, and delete students, academic years, and courses.
- **Course Assignment**: Assign students to courses for specific academic years.
- **SQLite Database**: Persistent storage of all data in a local SQLite database (`students.db`).
- **Error Handling**: User-friendly error messages for invalid inputs or database issues.
- **Multi-language Support**: Interface includes Polish error messages and prompts.

## Requirements

- .NET Framework (version compatible with the project, e.g., .NET 4.8 or later)
- SQLite (included as `System.Data.SQLite`)
- Windows operating system

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/StudentManager.git
   ```
2. **Open the Project**:
   - Open the solution file (`StudentManager.sln`) in Visual Studio.
3. **Restore Dependencies**:
   - Ensure the `System.Data.SQLite` NuGet package is installed. Run the following in the Package Manager Console:
     ```bash
     Install-Package System.Data.SQLite
     ```
4. **Build and Run**:
   - Build the solution in Visual Studio and run the application.
   - The application will automatically create a `students.db` SQLite database file in the project directory if it doesn't exist.

## Usage

1. **Launch the Application**:
   - Run the application to open the main window with a TreeView on the left and a ListView in the center.
2. **Navigate Categories**:
   - Click on "Students," "Years," or "Courses" in the TreeView to display corresponding data in the ListView.
3. **Manage Data**:
   - Click **Add** to create a new record.
   - Select an item in the ListView and click **Edit** to modify it.
   - Select an item and click **Delete** to remove it (with confirmation).
4. **Assign Courses**:
   - In the Student Edit form, select a course and academic year to assign a student to a course.
5. **Save or Cancel**:
   - Use the Save button to persist changes or Cancel to discard them.

## Database Structure

The application uses a SQLite database (`students.db`) with the following tables:

- **Students**: Stores student information (Id, FirstName, LastName, BirthDate).
- **AcademicYears**: Stores academic years (Id, Year).
- **Courses**: Stores course information (Id, Name).
- **StudentCourses**: Links students to courses and academic years (StudentId, CourseId, YearId).

## Project Structure

- `Form1.cs`: Main form with TreeView and ListView for navigation and data display.
- `StudentEditForm.cs`: Form for adding/editing student details and assigning courses.
- `CourseEditForm.cs`: Form for adding/editing courses.
- `YearEditForm.cs`: Form for adding/editing academic years.
- `DatabaseInitializer.cs`: Initializes the SQLite database and creates tables.
- `DatabaseManager.cs`: (Assumed) Contains methods for database operations (e.g., AddStudent, UpdateCourse).

## Notes

- The application assumes the presence of a `DatabaseManager` class (not provided in the code) that handles database operations like `AddStudent`, `UpdateCourse`, etc.
- Error messages are in Polish (e.g., "Błąd", "Wybierz kategorię") to align with the project requirements.
- The project fulfills the requirements outlined in the "Programowanie pod Windows" course assignment, using Windows Forms, SQLite, TreeView, and ListView.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes. Ensure that any changes align with the project requirements and include appropriate tests.

## License

This project is for educational purposes and does not include a specific license. Feel free to use and modify the code for learning or personal projects.
