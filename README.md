# PRG2781---Project---group10

====================================================
Baobab Ridge Wildlife Rehabilitation Record System
====================================================
A C# Windows Forms application built with .NET Framework 4.7.2 for managing wildlife rehabilitation records at the Baobab Ridge Wildlife Rehabilitation Centre. The system allows staff to record, search, update, delete, and generate statistical summary reports for admitted animals.

--Features--
- Animal Management (CRUD): Add new animal records, edit existing entry details, and safely delete records with double-confirmation dialogs.
- Automatic Status Classification: Automatically determines an animal's medical status and assigns a corresponding housing unit based on its Recovery Score:
    - 80 – 100: Release-Ready
    - 60 – 79: Recovering
    - 40 – 59: Stable
    - 20 – 39: Serious
    - 0 – 19: Critical
- Record Search: Quick record lookup by Animal ID
- Summary & Reporting: Automatically generates and updates an animal health summary report written to a local text file
- File-Based Persistence: Automatically reads from and writes to a pipe-delimited text file (animals.txt) on startup and upon changes.

--Project Structure--
PRG_272/
│
├── App.config               # Application target framework and runtime configuration
├── Animal.cs                # Core model class representing an animal object
├── Form1.cs                 # Main application form containing business and file I/O logic
├── Form1.Designer.cs        # Auto-generated UI control layout for Form1
├── Form1.resx               # Form resource definitions
├── Program.cs               # Main entry point for the WinForms application
├── PRG 272.csproj           # Visual Studio project file
├── animals.txt              # Pipe-delimited flat-file data storage for animal records
└── summary.txt              # Auto-generated report output file

--Prerequisites & Installation--
Requirements 
  
