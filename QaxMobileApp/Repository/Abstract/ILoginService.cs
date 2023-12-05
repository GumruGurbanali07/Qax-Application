﻿using QaxMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaxMobileApp.Repository.Abstract
{
    public interface ILoginService
    {
        Task<UserInfo> Login(string username, string password);
    }
}
