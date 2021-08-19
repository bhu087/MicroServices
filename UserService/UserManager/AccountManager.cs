using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Model;
using UserService.UserRepo;

namespace UserService.UserManager
{
    public class AccountManager : IAccountManager
    {
        private IAccountRepo repo;
        public AccountManager(IAccountRepo accountRepo)
        {
            this.repo = accountRepo;
        }
        public string GetUser(Login login)
        {
            try
            {
                return repo.GetUser(login);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
