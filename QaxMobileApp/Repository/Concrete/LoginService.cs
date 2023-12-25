
//using CoreData;
//using QaxMobileApp.Models;
//using QaxMobileApp.Repository.Abstract;

//namespace QaxMobileApp.Repository.Concrete
//{
//    public class LoginService : ILoginService
//    {
//        private static List<Teacher> teachers = new List<Teacher>
//        {




//        public Task<Teacher> Login(string username, string password)
//        {
//            //if (username == "Qumru" && password == "12345")
//            //{
//            //    // Return user information on successful login
//            //    return Task.FromResult(new QaxMobileApp.Models.TeacherInfo { UserId = 1, UserName = "Qumru" });
//            //}
//            //else if (username == "Nurlane" && password == "1234")
//            //{
//            //    // Return user information on successful login
//            //    return Task.FromResult(new QaxMobileApp.Models.TeacherInfo { UserId = 2, UserName = "Nurlane" });
//            //}
//            //else
//            //{
//            //    // Return null or throw an exception for unsuccessful login
//            //    return Task.FromResult<TeacherInfo>(null);
//            //}
//            var teacher = teachers.FirstOrDefault(t => t.UserName == username && t.Password == password);

//            if (teacher != null)
//            {
//                // Return user information on successful login
//                return Task.FromResult(new Teacher { UserId = 1, UserName = teacher.UserName });
//            }
//            else
//            {
//                // Return null or throw an exception for unsuccessful login
//                return Task.FromResult<Teacher>(null);
//            }

//        }

//        public Task<Teacher> Login(string username, string usersurname, string password)
//        {
//            var teacher = teachers.FirstOrDefault(t => t.UserName == username && t.UserSurname == usersurname && t.Password == password);

//            if (teacher != null)
//            {
//                // Return user information on successful login
//                return Task.FromResult(new Teacher { UserId = 1, UserName = teacher.UserName });
//            }
//            else
//            {
//                // Return null or throw an exception for unsuccessful login
//                return Task.FromResult<Teacher>(null);
//            }
//        }
//    }
//}
