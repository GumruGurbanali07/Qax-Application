namespace QaxMobileApp.Models
{
    public class TeacherInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<string> LegalClasses { get; set; } = new List<string>();
    }
}
