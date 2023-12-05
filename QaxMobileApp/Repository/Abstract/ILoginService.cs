using QaxMobileApp.Models;

namespace QaxMobileApp.Repository.Abstract
{
    //adawd
    public interface ILoginService
    {
        Task<UserInfo> Login(string username, string password);
    }
}
