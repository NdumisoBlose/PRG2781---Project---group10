using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_272
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();

        private readonly string animalsFilePath = Path.Combine(Application.StartupPath,"animals.txt");
        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadAnimals();
        }

        
        private void SetupDataGridView()
        {
            dgvAnimals.ReadOnly = true;
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.MultiSelect = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAnimals.Columns.Clear();
            dgvAnimals.Columns.Add("AnimalId", "AnimalID");
            dgvAnimals.Columns.Add("Name", "Name");
            dgvAnimals.Columns.Add("Species", "Species");
            dgvAnimals.Columns.Add("Age", "Age");
            dgvAnimals.Columns.Add("RecoveringScore", "RecoveringScore");
            dgvAnimals.Columns.Add("Status", "Status");
            dgvAnimals.Columns.Add("HousingUnit", "HousingUnit");
        }

        private void LoadAnimals()
        {
            animals.Clear();
            int skippedLines = 0;

            try
            {
                if (!File.Exists(animalsFilePath))
                {
                    File.Create(animalsFilePath);

                }
                string[] lines = File.ReadAllLines(animalsFilePath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        skippedLines++;
                        continue;
                    }
                    string[] parts = line.Split('|');

                    if (parts.Length != 7)
                    {
                        skippedLines++;
                        continue;
                    }

                    string id = parts[0].Trim().ToUpper();
                    string name = parts[1].Trim();
                    string species = parts[2].Trim();

                    if (!int.TryParse(parts[3].Trim(), out int age) || !int.TryParse(parts[4].Trim(), out int score))
                    {
                        skippedLines++;
                        continue;
                    }
                    if (!IsValidAnimalId(id))
                    {
                        skippedLines++;
                        continue;
                    }
                    string status = parts[5].Trim();
                    string housing = parts[6].Trim();

                    animals.Add(new Animal(id, name, species, age, score, status, housing));
                }
                if (skippedLines > 0 )
                {
                    MessageBox.Show($"{skippedLines} line(s) where skipped because they where malformed.", "Loading Complete", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Permission denied when trying to read animals.txt.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Could not read animals.txt.\n{ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error while loading animals.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshGrid();
        }

        private bool IsValidAnimalId(string id)
        {
            if (string.IsNullOrEmpty(id) || id.Length != 7) return false;
            {
                return id.StartsWith("WR-") &&
                    char.IsDigit(id[3]) &&
                    char.IsDigit(id[4]) &&
                    char.IsDigit(id[5]) &&
                    char.IsDigit(id[6]);
            }
        }

        private void RefreshGrid()
        {
            dgvAnimals.Rows.Clear();

            foreach (Animal animal in animals)
            {
                dgvAnimals.Rows.Add(animal.AnimalID, animal.Name, animal.Species, animal.Age, animal.RecoveryScore, animal.Status, animal.HousingUnit);
            }
        }
    }
}
