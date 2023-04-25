using Link_D.Models.Api;
using Link_D.Models.Data;
using Link_D.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace Link_D.Controllers.Apis
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinkHubApiController : ControllerBase
    {

        private IUserService userService;

        
        public LinkHubApiController(IUserService userService)
        {
            this.userService= userService;
        }


        [HttpPost("Register")]
        public IActionResult Register([FromBody] User user)
        {
           
           return userService.SaveUserData(user) ? Ok("Successfull saved") : Conflict("Email already exists"); 
            
        }
        
        [HttpPost("Login")]
        public IActionResult Login([FromBody] Login model)
        {
            return userService.CheckUserExists(model) ? Ok("Login successfull"): BadRequest("Invalid email or password");
        }
    }
}
