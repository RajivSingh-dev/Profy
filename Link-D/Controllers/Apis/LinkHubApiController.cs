using LinkD.Extensions;
using LinkD.Models.Api;
using LinkD.Models.Data;
using LinkD.Service;
using Microsoft.AspNetCore.Mvc;
using Profy.LinkD.Data.Models;

namespace LinkD.Controllers.Apis
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinkHubApiController : Controller
    {

        private IUserService userService;
        private IHttpContextAccessor _httpContextAccessor;
        private IPostService _postService;
            
        
        public LinkHubApiController(IUserService userService,IHttpContextAccessor httpContextAccessor,IPostService postService)
        {
            this.userService= userService;
            _httpContextAccessor= httpContextAccessor;
            _postService= postService;  
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

        [HttpGet("Activity")]
        public IActionResult Activity()
        {
            int userId = _httpContextAccessor.HttpContext.Session.GetUserId();
            User user = userService.GetUser(userId);
            user.Posts = _postService.GetPosts(userId);
            return PartialView("_UserActivity", user);
        }
    }
}
