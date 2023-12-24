using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.Models
{
  public  class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
