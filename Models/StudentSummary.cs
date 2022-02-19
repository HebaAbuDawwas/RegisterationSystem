using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class StudentSummary
    {
        public string studentName { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
