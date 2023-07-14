using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Packing3.Models;
using Packing3.Services;

namespace Packing3.Services.Impl
{
    public class UserService :  IUserService
    {
        private readonly List<User> _users = new()
        {
            new User { Id = 1, UserName = "user1", Password = "password1", Role = "admin" },
            new User { Id = 2, UserName = "user2", Password = "password2", Role = "guest" }
        };
        
        public string Login(string userName, string password)
        {
            var user = _users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
            
            if (user == null)
            {
                return string.Empty;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(SecretInfo.SECRET);

            var tokenDesciptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
          new Claim(ClaimTypes.Name, user.UserName),
          new Claim(ClaimTypes.Role, user.Role)
              }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDesciptor);
            user.Token = tokenHandler.WriteToken(token);
            return user.Token;
        }
    }
}
