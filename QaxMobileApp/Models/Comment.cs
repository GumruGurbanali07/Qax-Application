using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.Models
{
   public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }

        // Foreign key
        public int StudentId { get; set; }
        public Student Student { get; set; }

        // Foreign key
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
