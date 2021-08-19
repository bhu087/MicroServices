using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UserService.DBContext;
using UserService.Model;

namespace UserService.UserRepo
{
    public class AccountRepo : IAccountRepo
    {
        public UserDBContext context;
        public AccountRepo(UserDBContext userDbContext)
        {
            this.context = userDbContext;
        }
        public string GetUser(Login login)
        {
            try
            {
                var user = this.context.Users.Where(emailId => emailId.Email == login.Email).SingleOrDefault();
                if (user == null)
                {
                    return null;
                }
                if (user != null && user.Email.Equals(login.Email))
                {
                    if (user.Password == login.Password)
                    {
                        return this.GenerateJWTtokens(login.Email);
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public string GenerateJWTtokens(string userEmail)
        {
            string key = "This is my sample key to generating JWT";
            try
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim(ClaimTypes.Role, "User"),
                            new Claim("Email", userEmail)
                        }),
                    Expires = DateTime.Now.AddDays(Convert.ToDouble(1)),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)), SecurityAlgorithms.HmacSha256Signature)
                };
                var securityTokenHandler = new JwtSecurityTokenHandler();
                var securityToken = securityTokenHandler.CreateToken(tokenDescriptor);
                var token = securityTokenHandler.WriteToken(securityToken);
                return token;
            }
            catch (Exception e)
            {
                var a = e;
                throw new Exception();
            }
        }
    }
}
