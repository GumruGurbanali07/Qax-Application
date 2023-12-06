using QaxMobileApp.Models;
using QaxMobileApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.Repository.Concrete
{
    public class ParentLoginService : IParentLoginService
    {
        public Task<ParentInfo> Login(string username, string password)
        {
            if (username == "Lale" && password == "12345")
            {
                // Return user information on successful login
                return Task.FromResult(new QaxMobileApp.Models.ParentInfo { UserId = 1, UserName = "Lale" });
            }
            else
            {
                // Return null or throw an exception for unsuccessful login
                return Task.FromResult<ParentInfo>(null);
            }
        }
    }
}
