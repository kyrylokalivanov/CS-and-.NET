# CSharpProjects

A collection of C# and .NET projects developed for learning and showcasing skills in Windows application development, database management, and more. This repository contains various projects, primarily built using Windows Forms, ASP.NET, or other .NET technologies, with a focus on practical applications and coursework assignments.

## Description

This repository serves as a portfolio of C# and .NET projects created to demonstrate proficiency in programming with the .NET Framework. Each project is housed in its own subdirectory and includes its own `README.md` file with specific details about its functionality, setup, and usage. The projects cover a range of topics, including:

- Desktop applications using Windows Forms.
- Database-driven applications with SQLite or other databases.
- Web applications (if applicable) using ASP.NET.

The repository is designed to be a centralized hub for exploring, running, and contributing to these projects.

## Requirements

To run the projects in this repository, you need:

- **.NET Framework** (version varies by project, typically .NET 4.8 or later, or .NET Core/.NET 5+ for newer projects).
- **Visual Studio** (recommended: Visual Studio 2022 or later) for opening and building solutions.
- **NuGet Packages**:
  - Most projects require `System.Data.SQLite` for database operations (if applicable).
  - Check individual project `README.md` files for specific dependencies.
- **Windows Operating System** (for Windows Forms-based projects).
- **SQLite** (for projects using SQLite databases, included via NuGet).

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/CSharpProjects.git
   ```
2. **Navigate to a Project**:
   - Each project is in its own subdirectory (e.g., `StudentManager`).
   - Change to the desired project directory:
     ```bash
     cd CSharpProjects/StudentManager
     ```
3. **Open in Visual Studio**:
   - Open the `.sln` file (e.g., `StudentManager.sln`) in Visual Studio.
4. **Restore NuGet Packages**:
   - In Visual Studio, right-click the solution in Solution Explorer and select **Restore NuGet Packages**, or run:
     ```bash
     dotnet restore
     ```
   - Alternatively, install specific packages (e.g., `System.Data.SQLite`) via the Package Manager Console:
     ```bash
     Install-Package System.Data.SQLite
     ```
5. **Build and Run**:
   - Build the solution in Visual Studio (Ctrl+Shift+B) and run it (F5).
   - Refer to the project's `README.md` for project-specific instructions.

## Usage

Each project has its own usage instructions detailed in its respective `README.md` file. Generally:

1. Open the project in Visual Studio.
2. Build and run the solution to launch the application.
3. Follow the project-specific instructions for interacting with the application (e.g., navigating a TreeView, editing data, or managing database records).
4. Check for any project-specific dependencies or setup steps in the project's `README.md`.

## Project Structure

The repository is organized as follows:

- `/ProjectName/`: Subdirectory for each project (e.g., `StudentManager`).
  - `README.md`: Project-specific documentation.
  - `*.sln`: Visual Studio solution file.
  - `*.csproj`: Project file(s).
  - `*.cs`: C# source code files.
  - `*.db`: SQLite database files (if applicable, typically created at runtime).
- `/LICENSE`: License file for the repository.
- `/README.md`: This file, providing an overview of the repository.

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch for your changes:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Make changes to an existing project or add a new project in a separate subdirectory.
4. Include or update the `README.md` for the project.
5. Commit your changes:
   ```bash
   git commit -m "Add feature or new project"
   ```
6. Push to your fork and submit a pull request:
   ```bash
   git push origin feature/your-feature-name
   ```

Please ensure that your contributions align with the repository's purpose and include appropriate documentation.

## License

This projects are for educational purposes and does not include a specific license. Feel free to use and modify the code for learning or personal projects.
