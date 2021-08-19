using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Model;
using UserService.UserManager;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private IAccountManager manager;
        public AccountController(IAccountManager accountManager)
        {
            this.manager = accountManager;
        }
        [HttpGet]
        public ActionResult GetUser(Login login)
        {
            var response = manager.GetUser(login);
            if (response != null)
            {
                return this.Ok(new { Status = true, Message = "User Logged In Successfully", Data = response });
            }
            else
            {
                return this.BadRequest(new { Status = true, Message = "User not Logged In", Data = response });
            }
        }
    }
}
