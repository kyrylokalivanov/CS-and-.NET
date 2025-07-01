
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Final
{
    public partial class StudentEditForm : Form
    {
        private readonly DatabaseManager _dbManager = new DatabaseManager();
        private readonly long? _studentId;

        public StudentEditForm(long? studentId = null)
        {
            InitializeComponent();
            _studentId = studentId;
            LoadCoursesAndYears();
            if (studentId.HasValue)
            {
                LoadStudentData(studentId.Value);
            }
        }

        private void LoadCoursesAndYears()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=students.db;Version=3;"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand("SELECT * FROM Courses", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstCourses.Items.Add(new { Id = reader["Id"], Name = reader["Name"].ToString() });
                            }
                        }
                    }
                    using (var command = new SQLiteCommand("SELECT * FROM AcademicYears", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbYears.Items.Add(new { Id = reader["Id"], Year = reader["Year"].ToString() });
                            }
                        }
                    }
                }
                lstCourses.DisplayMember = "Name";
                cmbYears.DisplayMember = "Year";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void LoadStudentData(long studentId)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=students.db;Version=3;"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand("SELECT * FROM Students WHERE Id = @Id", connection))
                    {
                        command.Parameters.AddWithValue("@Id", studentId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFirstName.Text = reader["FirstName"].ToString();
                                txtLastName.Text = reader["LastName"].ToString();
                                dtpBirthDate.Value = DateTime.Parse(reader["BirthDate"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Poprosze wypełnić pola.");
                    return;
                }

                if (_studentId.HasValue)
                {
                    _dbManager.UpdateStudent(_studentId.Value, txtFirstName.Text, txtLastName.Text, dtpBirthDate.Value.ToString("yyyy-MM-dd"));
                }
                else
                {
                    _dbManager.AddStudent(txtFirstName.Text, txtLastName.Text, dtpBirthDate.Value.ToString("yyyy-MM-dd"));
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCourses.SelectedItem == null || cmbYears.SelectedItem == null)
                {
                    MessageBox.Show("wybierz zajęcie i rok.");
                    return;
                }

                var selectedCourse = (dynamic)lstCourses.SelectedItem;
                var selectedYear = (dynamic)cmbYears.SelectedItem;

                if (_studentId.HasValue)
                {
                    _dbManager.AssignStudentToCourse(_studentId.Value, selectedCourse.Id, selectedYear.Id);
                    MessageBox.Show("Course is inded.");
                }
                else
                {
                    MessageBox.Show("save student.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}