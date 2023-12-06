using QaxMobileApp.Models;

namespace QaxMobileApp.Repository.Abstract
{
    //adawd
    public interface ILoginService
    {
        Task<TeacherInfo> Login(string username, string password);
       
    }
}
