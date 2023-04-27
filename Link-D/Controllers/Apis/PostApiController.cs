using Microsoft.AspNetCore.Mvc;

namespace Link_D.Controllers.Apis
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostApiController : Controller
    {
        [HttpPost("SavePost")]
        public IActionResult Index()
        {


            return Ok();
        }
    }
}
