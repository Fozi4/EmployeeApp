using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
       public string Username {  get; set; }
       public string Password { get; set; }
       public Role Role { get; set; }
    }

    public enum Role
    {
        Admin,
        Employee
    }

    public static class CurrentUser
    {
        public static string CurrentUsername { get; set; }
        public static Role CurrentRole { get; set; }
    }
}
