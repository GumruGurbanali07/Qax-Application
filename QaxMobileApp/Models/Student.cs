using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string Password { get; set; }
        public List<Exam> Exams { get; set; } = new List<Exam>();
        public List<Quiz> Quizzes { get; set; } = new List<Quiz>();
        public List<Comment> Comments { get; set; } = new List<Comment>();

    
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
