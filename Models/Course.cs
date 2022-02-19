using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Course
    {
        [Key]
        public int courseId { get; set; }
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [Range(1,3)]
        public int totalHours { get; set; }
        //navigation
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
