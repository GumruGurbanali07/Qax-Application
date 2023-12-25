using Microsoft.EntityFrameworkCore;
using QaxMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.DbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ClassTeacher> ClassTeachers { get; set; }
        public DbSet<Class> Classes { get; set; }

        // Add DbSet properties for other entities as needed
    }


}
