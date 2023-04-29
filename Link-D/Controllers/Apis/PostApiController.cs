using Link_D.Service;
using Microsoft.AspNetCore.Mvc;

namespace Link_D.Controllers.Apis
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostApiController : Controller
    {

        private IHttpContextAccessor _httpContextAccessor;
        

        public PostApiController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpPost("SavePost")]
        public IActionResult Index()
        {
           

            return Ok();
        }
    }
}
