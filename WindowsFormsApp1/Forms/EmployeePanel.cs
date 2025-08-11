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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp1
{
    public partial class EmployeePanel : Form
    {
        public EmployeePanel()
        {
            InitializeComponent();
            this.Load += EnployeePanel_Load;
        }
        private void EnployeePanel_Load(object sender, EventArgs e)
        {
            LoadProjectsToListView();
        }
        private void LoadProjectsToListView()
        {
            listView1.Items.Clear();

            string jsonPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\Data\\projects.json";
            if (!File.Exists(jsonPath))
                return;

            string json = File.ReadAllText(jsonPath);
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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opn_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a project from the list");
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            Guid selectedId = (Guid)selectedItem.Tag;

            string jsonPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\Data\\projects.json";
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Project metadata file not found.");
                return;
            }

            string json = File.ReadAllText(jsonPath);
            var projects = JsonConvert.DeserializeObject<List<Project>>(json);
            var selectedProject = projects.FirstOrDefault(p => p.Id == selectedId);
            if (CurrentUser.CurrentUsername == selectedProject.AssignedTo)
            {
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
            else
            {
                MessageBox.Show("You are not assigned to this project and cannot change its status.");
            }
        } 

        private void return_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void myTasks_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string jsonPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\Data\\projects.json";
            if (!File.Exists(jsonPath)) { MessageBox.Show("Json file does not exist"); return; }
            string json = File.ReadAllText(jsonPath);
            var projects = JsonConvert.DeserializeObject<List<Project>>(json);
            var current_user = CurrentUser.CurrentUsername;
            IEnumerable<Project> my_projects;

            if (myTasks_checkBox.Checked)
            {
                my_projects = projects.Where(p => p.AssignedTo == current_user);
            }
            else
            {
                my_projects = projects;
            }
            listView1.Items.Clear();
            foreach (var project in my_projects)
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

        private void opn_tsk_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a task from the list");
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            Guid selectedId = (Guid)selectedItem.Tag;

            string jsonPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\Data\\projects.json";
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Project metadata file not found.");
                return;
            }

            string json = File.ReadAllText(jsonPath);
            var projects = JsonConvert.DeserializeObject<List<Project>>(json);
            var selectedProject = projects.FirstOrDefault(p => p.Id == selectedId);
            if (CurrentUser.CurrentUsername == selectedProject.AssignedTo)
            {
                if (selectedProject != null)
                {
                    if (string.IsNullOrEmpty(selectedProject.TaskPath))
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
            else
            {
                MessageBox.Show("You are not assigned to this project and cannot change its status.");
            }


        }
        public class StatusForm : Form
        {
            public string SelectedStatus { get; private set; }
            private ComboBox comboBox;
            private Button okButton;

            public StatusForm()
            {
                this.Text = "Choose Status";
                this.Size = new Size(400, 250);

                comboBox = new ComboBox();
                comboBox.Items.Add("Done");
                comboBox.Items.Add("In Work");
                comboBox.Dock = DockStyle.Top;
                this.Controls.Add(comboBox);

                okButton = new Button();
                okButton.Text = "OK";
                okButton.Dock = DockStyle.Bottom;
                okButton.Click += OkButton_Click;
                this.Controls.Add(okButton);
            }

            private void OkButton_Click(object sender, EventArgs e)
            {
                SelectedStatus = comboBox.SelectedItem?.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void status_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a task from the list");
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            Guid selectedId = (Guid)selectedItem.Tag;
            string jsonPath = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\Data\\projects.json";
            var projects = JsonConvert.DeserializeObject<List<Project>>(File.ReadAllText(jsonPath));
            var project = projects.FirstOrDefault(p => p.Id == selectedId);
            if (CurrentUser.CurrentUsername == project.AssignedTo)
            {
                using (var statusFrom = new StatusForm())
                {
                    if (statusFrom.ShowDialog() == DialogResult.OK)
                    {
                        string status = statusFrom.SelectedStatus;


                        if (project != null)
                        {
                            project.Status = status;
                            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(projects, Formatting.Indented));
                            MessageBox.Show($"Status updated to: {status}");
                            LoadProjectsToListView();

                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("You are not assigned to this project and cannot change its status.");
            }
        }
    }
}
    

