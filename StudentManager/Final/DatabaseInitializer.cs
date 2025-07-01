using System.Data.SQLite;
using System.IO;

namespace Final
{
    public class DatabaseInitializer
    {
        private readonly string _connectionString = "Data Source=students.db;Version=3;";

        public void InitializeDatabase()
        {
            if (!File.Exists("students.db"))
            {
                SQLiteConnection.CreateFile("students.db");
            }

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string createStudentsTable = @"
                    CREATE TABLE IF NOT EXISTS Students (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        BirthDate TEXT
                    )";
                string createAcademicYearsTable = @"
                    CREATE TABLE IF NOT EXISTS AcademicYears (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Year TEXT NOT NULL
                    )";
                string createCoursesTable = @"
                    CREATE TABLE IF NOT EXISTS Courses (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL
                    )";
                string createStudentCoursesTable = @"
                    CREATE TABLE IF NOT EXISTS StudentCourses (
                        StudentId INTEGER,
                        CourseId INTEGER,
                        YearId INTEGER,
                        PRIMARY KEY (StudentId, CourseId, YearId),
                        FOREIGN KEY (StudentId) REFERENCES Students(Id),
                        FOREIGN KEY (CourseId) REFERENCES Courses(Id),
                        FOREIGN KEY (YearId) REFERENCES AcademicYears(Id)
                    )";

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = createStudentsTable;
                    command.ExecuteNonQuery();
                    command.CommandText = createAcademicYearsTable;
                    command.ExecuteNonQuery();
                    command.CommandText = createCoursesTable;
                    command.ExecuteNonQuery();
                    command.CommandText = createStudentCoursesTable;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}