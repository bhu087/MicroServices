using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Model;

namespace UserService.UserManager
{
    public interface IAccountManager
    {
        string GetUser(Login login);
    }
}
