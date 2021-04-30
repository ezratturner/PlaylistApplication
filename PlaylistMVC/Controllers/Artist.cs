using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistApplication.Controllers
{
    public class Artist : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
