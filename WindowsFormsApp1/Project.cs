using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ProjectName { get; set; }
        public string FilePath { get; set; }
        public string AddedBy { get; set; }
        public string LastOpendBy { get; set; }
    }

}
