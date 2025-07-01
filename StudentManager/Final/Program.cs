// Program.cs: Application entry point, initializes database and starts Form1
using System;
using System.Windows.Forms;

namespace Final
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                new DatabaseInitializer().InitializeDatabase();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка запуска приложения: {ex.Message}");
            }
        }
    }
}