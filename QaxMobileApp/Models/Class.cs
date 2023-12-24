using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.Models
{
   public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        // Navigation property
        public List<ClassTeacher> ClassTeachers { get; set; } = new List<ClassTeacher>();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
