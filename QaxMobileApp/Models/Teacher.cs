namespace QaxMobileApp.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string Password { get; set; }
      
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public List<ClassTeacher> ClassTeachers { get; set; } = new List<ClassTeacher>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Exam> Exams { get; set; } = new List<Exam>();
        public List<Quiz> Quizzes { get; set; } = new List<Quiz>();
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}
