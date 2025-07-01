using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Final
{
    public partial class YearEditForm : Form
    {
        private readonly DatabaseManager _dbManager = new DatabaseManager();
        private readonly long? _yearId;

        public YearEditForm(long? yearId = null)
        {
            InitializeComponent();
            _yearId = yearId;
            if (yearId.HasValue)
            {
                LoadYearData(yearId.Value);
            }
        }

        private void LoadYearData(long yearId)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=students.db;Version=3;"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand("SELECT * FROM AcademicYears WHERE Id = @Id", connection))
                    {
                        command.Parameters.AddWithValue("@Id", yearId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtYear.Text = reader["Year"].ToString();
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
                if (string.IsNullOrWhiteSpace(txtYear.Text))
                {
                    MessageBox.Show("wybierz rok.");
                    return;
                }

                if (_yearId.HasValue)
                {
                    _dbManager.UpdateAcademicYear(_yearId.Value, txtYear.Text);
                }
                else
                {
                    _dbManager.AddAcademicYear(txtYear.Text);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения года: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}