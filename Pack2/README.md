# C# WPF Assignments

This is a repository containing solutions for two programming assignments implemented in C# using Windows Presentation Foundation (WPF) as part of the .NET framework. The assignments focus on building user interfaces with WPF, demonstrating form creation with input controls and a simple Tic-Tac-Toe game using a grid layout. The projects are organized into separate directories with clear instructions for setup and execution, making it easy to explore and run the code.

## Table of Contents
- [Requirements](#requirements)
- [Assignment 1: WPF Form Application](#assignment-1-wpf-form-application)
- [Assignment 2: Tic-Tac-Toe Game](#assignment-2-tic-tac-toe-game)
- [Setup and Execution](#setup-and-execution)
- [License](#license)

## Requirements
To run the projects, you need:
- .NET SDK (version 8.0 or later recommended)
- An IDE (e.g., Visual Studio 2022, Visual Studio Code, or Rider)
- Operating system: Windows (required for WPF; for cross-platform alternatives, consider MAUI or Avalonia as noted in the assignment)
- Optional: Familiarity with WPF documentation (https://learn.microsoft.com/en-us/dotnet/desktop/wpf/?view=netdesktop-8.0)

## Assignment 1: WPF Form Application
**Description**:  
Implements a WPF application that replicates a form window with two `GroupBox` controls. The first `GroupBox` contains two `TextBox` fields for entering a university name and address. The second `GroupBox` includes a `ComboBox` with sample study program names and two `CheckBox` controls for selecting study type (full-time or part-time). An "Accept" button displays the entered information in a message box, and a "Cancel" button closes the application.

**Key Features**:
- Uses `GroupBox` to organize input controls.
- Implements `TextBox` for text input, `ComboBox` for selecting study programs, and `CheckBox` for study type selection.
- Displays user input in a `MessageBox` when the "Accept" button is clicked.
- Closes the application when the "Cancel" button is clicked.
- Built using WPF XAML for the UI and C# for event handling.

**Execution**:
```bash
cd Assignment1
dotnet run
```

## Assignment 2: Tic-Tac-Toe Game
**Description**:  
Implements a simple Tic-Tac-Toe game in WPF using a 3x3 `Grid` layout with `SharedSizeGroup` to ensure equal-sized cells. Each cell contains a `Button` that responds to click events to place an "X" or "O". A status bar, spanning the entire grid width using `ColumnSpan`, displays game information (e.g., current player or game result).

**Key Features**:
- Uses a WPF `Grid` with 3 rows and 3 columns for the game board.
- Implements `Button` controls in each cell to handle player moves.
- Displays game status (e.g., "Player X's turn" or "Game Over") in a `TextBlock` spanning the grid.
- Handles game logic for alternating turns and detecting win conditions.
- Built using WPF XAML for the UI and C# for game logic.

**Execution**:
```bash
cd Assignment2
dotnet run
```

## Setup and Execution
1. Clone the repository:
   ```bash
   git clone https://github.com/kyrylokalivanov/CS-and-.NET.git
   ```
2. Navigate to the desired assignment folder:
   ```bash
   cd Assignment1
   ```
3. Run the project:
   ```bash
   dotnet run
   ```
4. To build or test the project:
   ```bash
   dotnet build
   dotnet test
   ```
   
## License
This project is for educational purposes and does not include a specific license. Feel free to use and modify the code for learning or personal projects.
