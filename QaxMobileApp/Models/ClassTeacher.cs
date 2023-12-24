using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.Models
{
  public  class ClassTeacher
    {
        public int TeacherId { get; set; }
        public int ClassId { get; set; }

        
        public Teacher Teacher { get; set; }
        public Class Class { get; set; }
    }
}
