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

namespace Zadanie_8._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isXTurn = true;
        private string[,] board = new string[3, 3];
        private int moves = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Content.ToString() != "") return; // Already clicked

            // Set X or O
            button.Content = isXTurn ? "X" : "O";
            int row = Grid.GetRow(button);
            int col = Grid.GetColumn(button);
            board[row, col] = button.Content.ToString();
            moves++;

            // Check for win
            if (CheckWin(button.Content.ToString()))
            {
                StatusTextBlock.Text = $"Wygrywa {button.Content}!";
                DisableButtons();
                return;
            }

            // Check for draw
            if (moves == 9)
            {
                StatusTextBlock.Text = "Remis!";
                return;
            }

            // Switch turn
            isXTurn = !isXTurn;
            StatusTextBlock.Text = $"Ruch: {(isXTurn ? "X" : "O")}";
        }

        private bool CheckWin(string player)
        {
            // Rows
            for (int i = 0; i < 3; i++)
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                    return true;

            // Columns
            for (int i = 0; i < 3; i++)
                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                    return true;

            // Diagonals
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                return true;
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
                return true;

            return false;
        }

        private void DisableButtons()
        {
            foreach (var child in (Content as Grid).Children)
                if (child is Button btn && btn.Name.StartsWith("Btn"))
                    btn.IsEnabled = false;
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset game
            isXTurn = true;
            moves = 0;
            board = new string[3, 3];
            StatusTextBlock.Text = "Ruch: X";

            // Clear buttons and enable them
            foreach (var child in (Content as Grid).Children)
                if (child is Button btn && btn.Name.StartsWith("Btn"))
                {
                    btn.Content = "";
                    btn.IsEnabled = true;
                }
        }
    }
}
