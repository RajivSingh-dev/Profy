using Link_D.Extensions;
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
        private IHttpContextAccessor _httpContextAccessor;

        
        public LinkHubApiController(IUserService userService,IHttpContextAccessor httpContextAccessor)
        {
            this.userService= userService;
            _httpContextAccessor= httpContextAccessor;
        }


        [HttpPost("Register")]
        public IActionResult Register([FromBody] User user)
        {
           return userService.SaveUserData(user) ? Ok("Successfull saved") : Conflict("Email already exists"); 
            
        }
        
        [HttpPost("Login")] 
        public IActionResult Login([FromBody] Login model)
        {
            int? userId = userService.CheckUserExists(model);
            
            if(userService.VerifyPassword(userId,model.Password))
            {
                _httpContextAccessor.HttpContext.Session.SetUserId(userId);
                return Ok("Login successfull");
            }
            else
              return BadRequest("Invalid email or password");
        }
    }
}
