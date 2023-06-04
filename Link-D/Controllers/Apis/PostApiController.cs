using LinkD.Extensions;
using LinkD.Models.Data;
using LinkD.Service;
using Microsoft.AspNetCore.Mvc;

namespace LinkD.Controllers.Apis
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostApiController : ControllerBase
    {

        private IHttpContextAccessor _httpContextAccessor;
        private IPostService _postService;  
        

        public PostApiController(IHttpContextAccessor httpContextAccessor, IPostService postService)
        {
            _httpContextAccessor = httpContextAccessor;
            _postService = postService;
        }


        [HttpPost("Save")]
        public IActionResult Save([FromBody] string  text)
        {
            int userId = _httpContextAccessor.HttpContext.Session.GetUserId();

            _postService.SavePost(userId,text);
            
            return Ok();
        }

    }
}
