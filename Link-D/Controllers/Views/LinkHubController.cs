﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LinkD.Controllers.Views
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
        
        public IActionResult Activity()
        {
            return View();
        }


    }
}
