using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            int secret_code = 04654;
            string username = login_txtBox.Text;
            string password = password_txtBox.Text;
            string role = comboBoxRegisterAs.SelectedItem.ToString();
            string json_path = "D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\Data\\users.json";
            List<User> users = new List<User>();
            if (File.Exists(json_path)) {
                string json = File.ReadAllText(json_path);
                users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            var matchedUser = users.FirstOrDefault(u => u.Username == username);
            if (matchedUser != null)
            {
                MessageBox.Show("User with this login already exist");
                return;
            }
            if (role == "Admin")
            {
                int adm_code = Convert.ToInt32(code_txtBox.Text);
                if (secret_code == adm_code)
                {
                    var newUser = new User
                    {
                        Username = username,
                        Password = password,
                        Role = Role.Admin
                    };
                    users.Add(newUser);
                    File.WriteAllText(json_path, JsonConvert.SerializeObject(users, Formatting.Indented));
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
            }
            if(role =="Employee")
            {
                var newUser = new User
                {
                    Username = username,
                    Password = password,
                    Role = Role.Employee
                };
                users.Add(newUser);
                File.WriteAllText(json_path, JsonConvert.SerializeObject(users, Formatting.Indented));
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxRegisterAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = comboBoxRegisterAs.SelectedItem.ToString();
            if (role == "Admin")
            {
                code_txtBox.Visible = true;
                adm_code_lbl.Visible = true;
            }
        }
    }
}
