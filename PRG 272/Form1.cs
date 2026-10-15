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
            dgvAnimals.Columns.Add("AnimalId", "Animal ID");
            dgvAnimals.Columns.Add("Name", "Name");
            dgvAnimals.Columns.Add("Species", "Species");
            dgvAnimals.Columns.Add("Age", "Age");
            dgvAnimals.Columns.Add("RecoveryScore", "Recovery Score");
            dgvAnimals.Columns.Add("Status", "Status");
            dgvAnimals.Columns.Add("HousingUnit", "Housing Unit");
        }

        private void LoadAnimals()
        {
            animals.Clear();
            int skippedLines = 0;

            try
            {
                if (!File.Exists(animalsFilePath))
                {
                    File.Create(animalsFilePath).Close();

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

        private Animal selectedAnimal = null;

        private void SetEditMode(bool editing)
        {
            txtAnimalId.ReadOnly = editing;
            btnAdd.Enabled = !editing;
            btnSaveChanges.Enabled = editing;
        }

        private string FormatLine(string id, string name, string species, int age, int score, string status, string housing)
        {
            return string.Join("|", id, name, species, age, score, status, housing);
        }

        private bool ValidateInputs(out string name, out string species, out int age, out int score)
        {
            name = txtName.Text.Trim();
            species = txtSpecies.Text.Trim();
            age = 0;
            score = 0;

            if (name.Length < 1 || name.Length > 30 || name.Contains("|"))
            {
                MessageBox.Show("Name must be 1-30 characters and cannot contain |.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (species.Length < 1 || species.Length > 30 || species.Contains("|"))
            {
                MessageBox.Show("Species must be 1-30 characters and cannot contain |.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpecies.Focus();
                return false;
            }
            if (!int.TryParse(txtAge.Text.Trim(), out age) || age < 0 || age > 100)
            {
                MessageBox.Show("Age must be a whole number between 0 and 100.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }
            if (!int.TryParse(txtScore.Text.Trim(), out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Recovery Score must be a whole number between 0 and 100.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtScore.Focus();
                return false;
            }
            return true;
        }

        private void Classify(int score, out string status, out string housing)
        {
            if (score >= 80) { status = "Release-Ready"; housing = "Pre-Release Camp"; }
            else if (score >= 60) { status = "Recovering"; housing = "Outdoor Enclosure"; }
            else if (score >= 40) { status = "Stable"; housing = "Recovery Ward"; }
            else if (score >= 20) { status = "Serious"; housing = "High-Dependency Ward"; }
            else { status = "Critical"; housing = "Intensive Care Unit"; }
        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= animals.Count) return;
            LoadIntoControls(animals[e.RowIndex]);
        }

        private void LoadIntoControls(Animal animal)
        {
            selectedAnimal = animal;
            txtAnimalId.Text = animal.AnimalID;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtScore.Text = animal.RecoveryScore.ToString();
            SetEditMode(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();
            int index = animals.FindIndex(a => a.AnimalID.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (index < 0)
            {
                MessageBox.Show("No animal found with that ID.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // nothing else changes
            }

            dgvAnimals.ClearSelection();
            dgvAnimals.Rows[index].Selected = true;
            LoadIntoControls(animals[index]);

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (selectedAnimal == null)
            {
                MessageBox.Show("Select an animal to edit first.", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(out string name, out string species, out int age, out int score)) return;

            Classify(score, out string status, out string housing);

            // Build every line; only the selected animal gets the new values
            List<string> lines = new List<string>();
            foreach (Animal a in animals)
            {
                if (a == selectedAnimal)
                    lines.Add(FormatLine(a.AnimalID, name, species, age, score, status, housing));
                else
                    lines.Add(FormatLine(a.AnimalID, a.Name, a.Species, a.Age, a.RecoveryScore, a.Status, a.HousingUnit));
            }

            try
            {
                File.WriteAllLines(animalsFilePath, lines);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Permission denied. animals.txt may be read-only.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // memory untouched, so it still matches the file
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Could not write animals.txt. It may be open in another program.\n{ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // File saved, so now update memory
            selectedAnimal.Name = name;
            selectedAnimal.Species = species;
            selectedAnimal.Age = age;
            selectedAnimal.RecoveryScore = score;
            selectedAnimal.Status = status;
            selectedAnimal.HousingUnit = housing;

            RefreshGrid();
            ClearForm(); // back to Add mode
            MessageBox.Show($"Updated. Status: {status}, Housing: {housing}.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            selectedAnimal = null;
            txtAnimalId.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtSearch.Clear();
            dgvAnimals.ClearSelection();
            SetEditMode(false);
        }
    }
}
