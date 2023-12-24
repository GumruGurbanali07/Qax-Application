using QaxMobileApp.Models;

namespace QaxMobileApp.Repository.Abstract
{
    //adawd
    public interface ILoginService
    {
        Task<Teacher> Login(string username,string usersurname, string password);
       
    }
}
