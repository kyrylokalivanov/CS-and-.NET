using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie_8._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            string nazwa = NazwaTextBox.Text;
            string adres = AdresTextBox.Text;
            string cykl = CyklComboBox.SelectedItem != null
                ? (CyklComboBox.SelectedItem as ComboBoxItem)?.Content.ToString()
                : "Brak wyboru";
            string dziennie = DzienneCheckBox.IsChecked == true ? "dzienne" : "";
            string uzupelniajace = UzupelniajaceCheckBox.IsChecked == true ? "uzupełniające" : "";

            string message = $"Uczelnia: {nazwa}\nAdres: {adres}\nCykl: {cykl}\n{dziennie} {uzupelniajace}".Trim();
            MessageBox.Show(message, "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
