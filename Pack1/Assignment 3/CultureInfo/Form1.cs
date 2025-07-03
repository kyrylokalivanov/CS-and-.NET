using System.Globalization;
using System.Text;
using System;
using System.Windows.Forms;

namespace Zadanie_9._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cultures = { "en-US", "de-DE", "fr-FR", "ru-RU", "ar-SA", "cs-CZ", "pl-PL" };
            StringBuilder sb = new StringBuilder();

            foreach (string culture in cultures)
            {
                CultureInfo ci = new CultureInfo(culture);
                sb.AppendLine($"Culture: {ci.DisplayName}");
                sb.AppendLine("Months (full): " + string.Join(", ", ci.DateTimeFormat.MonthNames[..^1]));
                sb.AppendLine("Months (short): " + string.Join(", ", ci.DateTimeFormat.AbbreviatedMonthNames[..^1]));
                sb.AppendLine("Days (full): " + string.Join(", ", ci.DateTimeFormat.DayNames));
                sb.AppendLine("Days (short): " + string.Join(", ", ci.DateTimeFormat.AbbreviatedDayNames));
                sb.AppendLine("Current date: " + DateTime.Now.ToString("D", ci));
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "CultureInfo Demo");
        }
    }
}
