using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Packing3.Models;
using Packing3.Services;

namespace Packing3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] User user)
        {
            var token = _userService.Login(user.UserName, user.Password);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest(new { message = "Usuario o Clave es incorrecta" });
            }
            return Ok(token);
        }
    }
}
