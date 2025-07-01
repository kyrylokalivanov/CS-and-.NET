
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Final
{
    public partial class CourseEditForm : Form
    {
        private readonly DatabaseManager _dbManager = new DatabaseManager();
        private readonly long? _courseId;

        public CourseEditForm(long? courseId = null)
        {
            InitializeComponent();
            _courseId = courseId;
            if (_courseId.HasValue)
            {
                LoadCourseData(courseId.Value);
            }
        }

        private void LoadCourseData(long courseId)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=students.db;Version=3;"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand("SELECT * FROM Courses WHERE Id = @Id", connection))
                    {
                        command.Parameters.AddWithValue("@Id", courseId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["Name"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"błąd: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Wpisz nazwe kursu");
                    return;
                }

                if (_courseId.HasValue)
                {
                    _dbManager.UpdateCourse(_courseId.Value, txtName.Text);
                }
                else
                {
                    _dbManager.AddCourse(txtName.Text);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving course: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}