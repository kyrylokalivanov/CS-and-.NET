using System.Data.SQLite;

namespace Final
{
    public class DatabaseManager
    {
        private readonly string _connectionString = "Data Source=students.db;Version=3;";

        public void AddStudent(string firstName, string lastName, string birthDate)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Students (FirstName, LastName, BirthDate) VALUES (@FirstName, @LastName, @BirthDate)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось добавить студента", ex);
            }
        }

        public void UpdateStudent(long studentId, string firstName, string lastName, string birthDate)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate WHERE Id = @Id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@Id", studentId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }


        public void AddAcademicYear(string year)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO AcademicYears (Year) VALUES (@Year)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Year", year);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }

        public void UpdateAcademicYear(long yearId, string year)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "UPDATE AcademicYears SET Year = @Year WHERE Id = @Id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Id", yearId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }

        public void DeleteStudent(long studentId)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Students WHERE Id = @Id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", studentId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }

        public void DeleteAcademicYear(long yearId)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM AcademicYears WHERE Id = @Id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", yearId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }

        public void AddCourse(string name)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Courses (Name) VALUES (@Name)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }

        public void UpdateCourse(long courseId, string name)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Courses SET Name = @Name WHERE Id = @Id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Id", courseId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }

        public void DeleteCourse(long courseId)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Courses WHERE Id = @Id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", courseId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }

        public void AssignStudentToCourse(long studentId, long courseId, long yearId)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string query = "INSERT OR IGNORE INTO StudentCourses (StudentId, CourseId, YearId) VALUES (@StudentId, @CourseId, @YearId)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        command.Parameters.AddWithValue("@YearId", yearId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("błąd", ex);
            }
        }
    }
}