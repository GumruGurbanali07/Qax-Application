
//using CoreData;
using QaxMobileApp.Models;
using QaxMobileApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.Repository.Concrete
{
    public class LoginService : ILoginService
    {
        public Task<UserInfo> Login(string username, string password)
        {
            if (username == "Qumru" && password == "12345")
            {
                // Return user information on successful login
                return Task.FromResult(new QaxMobileApp.Models.UserInfo { UserId = 1, UserName = "Qumru" });
            }
            else
            {
                // Return null or throw an exception for unsuccessful login
                return Task.FromResult<UserInfo>(null);
            }
        }
    }
}
