using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Model;

namespace UserService.UserRepo
{
    public interface IAccountRepo
    {
        string GetUser(Login login);
    }
}
