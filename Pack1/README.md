# C# .NET Assignments

This repository contains solutions for three programming assignments implemented in C# using the .NET framework. Each assignment demonstrates specific concepts and techniques, including stream handling, thread synchronization, and internationalization.

## Table of Contents
- [Requirements](#requirements)
- [Assignment 1: Stream Handling](#assignment-1-stream-handling)
- [Assignment 2: Smokers Problem](#assignment-2-smokers-problem)
- [Assignment 3: CultureInfo Date Formatting](#assignment-3-cultureinfo-date-formatting)
- [Setup and Execution](#setup-and-execution)
- [Project Structure](#project-structure)
- [License](#license)

## Requirements
To run the projects, you need:
- .NET SDK (version 8.0 or later recommended)
- An IDE (e.g., Visual Studio 2022, Visual Studio Code, or Rider)
- Operating system: Windows, macOS, or Linux

## Assignment 1: Stream Handling
**Description**:  
Demonstrates the use of stream-related classes (`FileStream`, `StreamReader`, `StreamWriter`, `BinaryReader`, `BinaryWriter`, `StringBuilder`, `StringWriter`) and the Decorator pattern for stream processing. The program writes text to a file, encrypts it using AES, compresses it with GZip, and then reads, decompresses, and decrypts the data.

**Key Features**:
- Uses `StringBuilder` and `StringWriter` for string manipulation.
- Employs `StreamReader` and `StreamWriter` for text file operations.
- Utilizes `BinaryReader` and `BinaryWriter` for binary data handling.
- Implements a Decorator pattern with `CryptoStream` (AES encryption) and `GZipStream` (compression).
- Demonstrates encryption/decryption and compression/decompression of a text file.

**Execution**:
```bash
cd Assignment1
dotnet run
```

## Assignment 2: Smokers Problem
**Description**:  
Implements a console application solving the classic "Smokers Problem" using thread synchronization with semaphores. The problem involves an agent providing two random ingredients (tobacco, paper, or matches) to three smokers, each possessing one ingredient and waiting for the other two to smoke.

**Key Features**:
- Uses `Semaphore` for thread synchronization.
- Simulates the agent and three smokers with separate threads.
- Randomly selects ingredient combinations using `Random`.
- Ensures proper synchronization to avoid deadlocks.
- Runs for a fixed number of iterations (default: 10).

**Execution**:
```bash
cd Assignment2
dotnet run
```

## Assignment 3: CultureInfo Date Formatting
**Description**:  
[Note: The provided code does not include the implementation for this assignment. The task requires writing a program that uses `CultureInfo` to display full and abbreviated names of months and days of the week, as well as the current date, in English, German, French, Russian, Arabic, Czech, and Polish. If the console does not support certain fonts, `MessageBox.Show` should be used.]

**Key Features** (based on task description):
- Utilizes `CultureInfo` to retrieve localized date and time information.
- Supports multiple languages (English, German, French, Russian, Arabic, Czech, Polish).
- Displays full and abbreviated names of months and days of the week.
- Formats the current date according to each culture.
- Falls back to `MessageBox.Show` for unsupported console fonts.

**Execution**:
[To be implemented. Placeholder command:]
```bash
cd Assignment3
dotnet run
```

## Setup and Execution
1. Clone the repository:
   ```bash
   git clone https://github.com/[your-username]/[your-repository].git
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

## Project Structure
```
├── Assignment1/                # Solution for Assignment 1 (Stream Handling)
│   ├── Program.cs              # Main program file
│   ├── Assignment1.csproj      # Project file
├── Assignment2/                # Solution for Assignment 2 (Smokers Problem)
│   ├── Program.cs              # Main program file
│   ├── Assignment2.csproj      # Project file
├── Assignment3/                # Solution for Assignment 3 (CultureInfo)
│   ├── Program.cs              # [To be implemented]
│   ├── Assignment3.csproj      # [To be implemented]
├── README.md                   # This file
└── .gitignore                  # Git ignore file
```

## License

This project is for educational purposes and does not include a specific license. Feel free to use and modify the code for learning or personal projects.
