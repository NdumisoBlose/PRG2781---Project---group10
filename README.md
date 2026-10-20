# PRG2782---Project---group10

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


--Data Format--
Animal records are stored in animals.txt using pipe (|) delimiter separation
Format Example:
AnimalID|Name|Species|Age|RecoveryScore|Status|HousingUnit
Example Record:
WR-0001|Thando|African Penguin|4|85|Release-Ready|Pre-Release Camp

--Prerequisites & Installation--
Requirements:
- Operating System: Windows10/11
- Development Environment: Visual Studio 2019 or later (with .NET desktop development workload)
- Runtime: .NET Framework 4.7.2 or higher
Running the Application
1. Clone or download the repository source code to your machine.
2. Open the solution file PRG 272.csproj in Visual Studio.
3. Build the solution to restore and output build dependencies.
4. Run the project.

--Usage Guide--
1. Viewing Records: Launching the app automatically populates the DataGridView with records stored in animals.txt
2. Selecting a Record: Click on any cell in the grid to load that animal's details into the editing fields.
3. Adding an Animal:
    - Clear the form fields using the Clear button.
    - Enter a valid Animal ID, Name, Species, Age (0-100) and Recovery Score(0-100).
    - Click Add to validate, classify and save the new record to animals.txt
4. Modifying Records: Select an animal from the grid, edit the allowed fields and click Save Changes.
5. Deleting Records: Select an animal from the gird, edit and click Delete. Confirm the deletion prompt when prompted.
6. Generating Reports: Click Summary(or preform additions/updates) to generate summary.txt in the executable output directory containing total counts, average age, average score and status distributions. 
  
