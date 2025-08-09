using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string input_username = Username_txtBox.Text;
            string input_password = Password_txtBox.Text;
            string json = File.ReadAllText("D:\\EmployeeApp\\WindowsFormsApp1\\WindowsFormsApp1\\users.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            var matchedUser = users.FirstOrDefault(u => u.Username ==  input_username || u.Password == input_password);
            if (matchedUser != null) 
            {
                if (matchedUser.Role == Role.Admin) 
                { 
                    CurrentUser.CurrentUsername = matchedUser.Username;
                    CurrentUser.CurrentRole = Role.Admin;
                    AdminPanel admin_panel = new AdminPanel();
                    admin_panel.Show();
                }
                else
                {
                    CurrentUser.CurrentUsername = matchedUser.Username;
                    CurrentUser.CurrentRole = Role.Employee;
                    EmployeePanel employee_panel = new EmployeePanel();
                    employee_panel.Show();
                }

                this.Hide();
            }
            else { label_error.Visible = true; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
