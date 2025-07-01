using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Final
{
    public partial class Form1 : Form
    {
        private readonly DatabaseManager _dbManager = new DatabaseManager();

        public Form1()
        {
            InitializeComponent();
            InitializeTreeView();
            listView1.View = View.Details;
            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Name", 100);
                listView1.Columns.Add("Surname", 100);
                listView1.Columns.Add("BirthDay", 120);
            }
        }

        private void InitializeTreeView()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Students", "Students");
            treeView1.Nodes.Add("Years", "Years");
            treeView1.Nodes.Add("Courses", "Courses");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                using (var connection = new SQLiteConnection("Data Source=students.db;Version=3;"))
                {
                    connection.Open();
                    if (e.Node.Name == "Students")
                    {
                        listView1.Columns.Clear();
                        listView1.Columns.Add("Name", 100);
                        listView1.Columns.Add("Surname", 100);
                        listView1.Columns.Add("BirthDate", 120);
                        using (var command = new SQLiteCommand("SELECT * FROM Students", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var item = new ListViewItem(reader["FirstName"].ToString());
                                    item.SubItems.Add(reader["LastName"].ToString());
                                    item.SubItems.Add(reader["BirthDate"].ToString());
                                    item.Tag = reader["Id"];
                                    listView1.Items.Add(item);
                                }
                            }
                        }
                    }
                    else if (e.Node.Name == "Years")
                    {
                        listView1.Columns.Clear();
                        listView1.Columns.Add("Year", 200);
                        using (var command = new SQLiteCommand("SELECT * FROM AcademicYears", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var item = new ListViewItem(reader["Year"].ToString());
                                    item.Tag = reader["Id"];
                                    listView1.Items.Add(item);
                                }
                            }
                        }
                    }
                    else if (e.Node.Name == "Courses")
                    {
                        listView1.Columns.Clear();
                        listView1.Columns.Add("Name", 200);
                        using (var command = new SQLiteCommand("SELECT * FROM Courses", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var item = new ListViewItem(reader["Name"].ToString());
                                    item.Tag = reader["Id"];
                                    listView1.Items.Add(item);
                                }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode?.Name == "Students")
                {
                    var editForm = new StudentEditForm();
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
                    }
                }
                else if (treeView1.SelectedNode?.Name == "Years")
                {
                    var yearForm = new YearEditForm();
                    if (yearForm.ShowDialog() == DialogResult.OK)
                    {
                        treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
                    }
                }
                else if (treeView1.SelectedNode?.Name == "Courses")
                {
                    var courseForm = new CourseEditForm();
                    if (courseForm.ShowDialog() == DialogResult.OK)
                    {
                        treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
                    }
                }
                else
                {
                    MessageBox.Show("Choose the category");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    if (treeView1.SelectedNode?.Name == "Students")
                    {
                        long studentId = (long)listView1.SelectedItems[0].Tag; 
                        var editForm = new StudentEditForm(studentId);
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
                        }
                    }
                    else if (treeView1.SelectedNode?.Name == "Years")
                    {
                        long yearId = (long)listView1.SelectedItems[0].Tag;
                        var yearForm = new YearEditForm(yearId);
                        if (yearForm.ShowDialog() == DialogResult.OK)
                        {
                            treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
                        }
                    }
                    else if (treeView1.SelectedNode?.Name == "Courses")
                    {
                        long courseId = (long)listView1.SelectedItems[0].Tag;
                        var courseForm = new CourseEditForm(courseId);
                        if (courseForm.ShowDialog() == DialogResult.OK)
                        {
                            treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wybierz kategorie");
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz element");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Pełien?", "Tak", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (treeView1.SelectedNode?.Name == "Students")
                        {
                            long studentId = (long)listView1.SelectedItems[0].Tag; 
                            _dbManager.DeleteStudent(studentId);
                        }
                        else if (treeView1.SelectedNode?.Name == "Years")
                        {
                            long yearId = (long)listView1.SelectedItems[0].Tag; 
                            _dbManager.DeleteAcademicYear(yearId);
                        }
                        else if (treeView1.SelectedNode?.Name == "Courses")
                        {
                            long courseId = (long)listView1.SelectedItems[0].Tag;
                            _dbManager.DeleteCourse(courseId);
                        }
                        treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz element");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}