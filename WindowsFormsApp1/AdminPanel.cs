using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
namespace WindowsFormsApp1
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            this.Load += AdminPanel_Load;
            this.listView1.DoubleClick += listView1_DoubleClick;
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadProjectsToListView();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void employee_add_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a project from the list first.");
                return;
            }

            string usersPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\users.json";
            if (!File.Exists(usersPath))
            {
                MessageBox.Show("Users file not found.");
                return;
            }

            string usersJson = File.ReadAllText(usersPath);
            var users = JsonConvert.DeserializeObject<List<User>>(usersJson);

            var employees = users.Where(u => u.Role == Role.Employee).ToList();
            if (employees.Count == 0)
            {
                MessageBox.Show("No employees found.");
                return;
            }

            Form dialog = new Form()
            {
                Width = 300,
                Height = 150,
                Text = "Select Employee"
            };

            ComboBox combo = new ComboBox() { Left = 20, Top = 20, Width = 240 };
            combo.DataSource = employees;
            combo.DisplayMember = "Username";

            Button confirmation = new Button() { Text = "OK", Left = 100, Width = 80, Top = 60, DialogResult = DialogResult.OK };
            dialog.Controls.Add(combo);
            dialog.Controls.Add(confirmation);
            dialog.AcceptButton = confirmation;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedEmployee = (User)combo.SelectedItem;
                MessageBox.Show($"Employee '{selectedEmployee.Username}' selected.");
                var selectedProjectId = (Guid)listView1.SelectedItems[0].Tag;
                var jsonPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\projects.json";
                var projectJson = File.ReadAllText(jsonPath);
                var projects = JsonConvert.DeserializeObject<List<Project>>(projectJson);

                var selectedProject = projects.FirstOrDefault(p => p.Id == selectedProjectId);
                if (selectedProject != null)
                {
                    selectedProject.AssignedTo = selectedEmployee.Username;

                    string updated = JsonConvert.SerializeObject(projects, Formatting.Indented);
                    File.WriteAllText(jsonPath, updated);
                    MessageBox.Show("Project successfully assigned.");

                    LoadProjectsToListView(); 
                }
            }
        }

        private void project_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose File";
            openFileDialog.Filter = "All files (*.*)|*.*";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    string projectName = Path.GetFileNameWithoutExtension(selectedFilePath);
                    Project newProject = new Project
                    {
                        Id = Guid.NewGuid(),
                        ProjectName = projectName,
                        FilePath = selectedFilePath,
                        AddedBy = CurrentUser.CurrentUsername,
                        LastOpendBy = null,
                        AssignedTo = null,
                        Task = null,
                        TaskPath = null,
                        Status = null
                    };
                    string filePath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\projects.json";
                    List<Project> projects = new List<Project>();
                    if (File.Exists(filePath))
                    {
                        string existingJson = File.ReadAllText(filePath);
                        projects = JsonConvert.DeserializeObject<List<Project>>(existingJson) ?? new List<Project>();
                    }

                    projects.Add(newProject);

                    string updateJson = JsonConvert.SerializeObject(projects, Formatting.Indented);
                    File.WriteAllText(filePath, updateJson);
                    MessageBox.Show($"File {selectedFilePath} is added");
                }
                LoadProjectsToListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadProjectsToListView()
        {
            listView1.Items.Clear();

            string filePath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\projects.json";
            if (!File.Exists(filePath))
                return;

            string json = File.ReadAllText(filePath);
            var projects = JsonConvert.DeserializeObject<List<Project>>(json);

            foreach (var project in projects)
            {
                ListViewItem item = new ListViewItem(project.ProjectName);
                item.SubItems.Add(project.AddedBy);
                item.SubItems.Add(project.LastOpendBy);
                item.SubItems.Add(project.AssignedTo);
                item.SubItems.Add(project.Task);
                item.SubItems.Add(project.Status);
                item.Tag = project.Id;
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Open_btn_Click(sender, e);
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a project from the list");
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            Guid selectedId = (Guid)selectedItem.Tag; 

            string jsonPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\projects.json";
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Project metadata file not found.");
                return;
            }

            string json = File.ReadAllText(jsonPath);
            var projects = JsonConvert.DeserializeObject<List<Project>>(json);
            var selectedProject = projects.FirstOrDefault(p => p.Id == selectedId);

            if (selectedProject != null)
            {
                selectedProject.LastOpendBy = CurrentUser.CurrentUsername;

                string updatedJson = JsonConvert.SerializeObject(projects, Formatting.Indented);
                File.WriteAllText(jsonPath, updatedJson);

                LoadProjectsToListView();
            }

            if (!string.IsNullOrEmpty(selectedProject.FilePath) && File.Exists(selectedProject.FilePath))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = selectedProject.FilePath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File not found, please try again.");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose an item from list view");
                return;
            }
            var selectedItem = listView1.SelectedItems[0];
            Guid selectedId = (Guid)selectedItem.Tag;
            if (selectedItem != null) {
                listView1.Items.RemoveAt(selectedItem.Index);
            }
            string filePath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\projects.json";
            if (!File.Exists(filePath)) { return; }
            string json = File.ReadAllText(filePath);
            var projects = JsonConvert.DeserializeObject<List<Project>>(json);
            var projectToRemove = projects.FirstOrDefault(p => p.Id == selectedId);
            if (projectToRemove != null) {
                projects.Remove(projectToRemove);
                string updatedJson = JsonConvert.SerializeObject(projects, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void task_btn_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0) { MessageBox.Show("Please choose a project"); return; }
            var selectedItem = listView1.SelectedItems[0];
            Guid selectedId = (Guid)selectedItem.Tag;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose File";
            openFileDialog.Filter = "All files (*.*)|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string taskName = Path.GetFileNameWithoutExtension(selectedFilePath);
                string filePath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\projects.json";
                if (!File.Exists(filePath)) { MessageBox.Show("File does not exist"); return; }
                string json = File.ReadAllText(filePath);
                var projects = JsonConvert.DeserializeObject<List<Project>>(json);
                var project_for_task = projects.FirstOrDefault(p => p.Id == selectedId);
                if (project_for_task != null)
                {
                    project_for_task.Task = taskName;
                    project_for_task.TaskPath = selectedFilePath;
                    string updated = JsonConvert.SerializeObject(projects, Formatting.Indented);
                    File.WriteAllText(filePath, updated);
                    MessageBox.Show("Task successfully added.");

                    LoadProjectsToListView();
                }
            }
        }

        private void opn_task_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a task from the list");
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            Guid selectedId = (Guid)selectedItem.Tag;

            string jsonPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\projects.json";
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Project metadata file not found.");
                return;
            }

            string json = File.ReadAllText(jsonPath);
            var projects = JsonConvert.DeserializeObject<List<Project>>(json);
            var selectedProject = projects.FirstOrDefault(p => p.Id == selectedId);

            if (selectedProject != null)
            {
                if(string.IsNullOrEmpty(selectedProject.TaskPath))
                {
                    MessageBox.Show("No task assigned to the project");
                    return;
                }
                if (File.Exists(selectedProject.TaskPath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = selectedProject.TaskPath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to open file: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("File not found, please try again.");
                }
            }

        
        }
    }
}
