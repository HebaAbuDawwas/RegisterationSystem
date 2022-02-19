using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }

        [Column("Name")]
        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        [Display( Name ="Name")]
        public string studentName { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Phone]
        [StringLength(10)]
        public string phone { get; set; }

        public string imagePath { get; set; } = "userprofile.png";
        [NotMapped]
        public IFormFile imageFile { get; set; }
        //navigation
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
