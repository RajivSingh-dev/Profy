using Link_D.Models;
using Link_D.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Link_D.Controllers.Apis
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinkHubController : ControllerBase
    {

        private IUserService _userService;

        
        public LinkHubController(IUserService userService)
        {
            _userService= userService;
        }


        [HttpPost("Register")]
        public IActionResult Register([FromBody] User user)
        {
            _userService.SaveUserData(user);

            return Ok();
        }
        
        [HttpPost("Login")]
        public IActionResult Login([FromQuery] string email, [FromQuery] string password)
        {
            return _userService.CheckUserExists(email, password) ? Ok(): BadRequest("Invalid email or password");
        }
    }
}
