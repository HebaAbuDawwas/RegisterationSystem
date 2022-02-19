using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class StudentCourse
    {
        [Key]
        public int id { get; set; }
        public int courseId { get; set; }
        public int studentId { get; set; }

        public eStatus status { get; set; }
        //navigation
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}
