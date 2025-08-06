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
                        ProjectName = projectName,
                        FilePath = selectedFilePath,
                        AddedBy = CurrentUser.CurrentUsername,
                        LastOpendBy = null
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
                item.SubItems.Add(project.FilePath);
                item.SubItems.Add(project.AddedBy);

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
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose project from the list");
                return;
            }
            var selectedItem = listView1.SelectedItems[0];
            string filePath = selectedItem.SubItems[1].Text;
            string json = File.ReadAllText(filePath);
            var projects = JsonConvert.DeserializeObject<List<Project>>(json);
            string projectName = selectedItem.SubItems[0].Text;
            var selectedProject = projects.FirstOrDefault(p => p.ProjectName == projectName);
            if (selectedProject != null) 
            {
                selectedProject.LastOpendBy = CurrentUser.CurrentUsername;
            }
            LoadProjectsToListView();
            if (File.Exists(filePath))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File is not founded, please try again");
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
        }
    }
}
