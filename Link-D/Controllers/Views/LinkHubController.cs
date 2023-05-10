using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Link_D.Controllers.Views
{
    public class LinkHubController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }  
        
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }


    }
}
