using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Course> tblCourse { get; set; }

        public DbSet<Student> tblStudent { get; set; }

        public DbSet<StudentCourse> tblStudentCourse { get; set; }
    }
}
