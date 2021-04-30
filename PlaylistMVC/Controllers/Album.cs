using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistApplication.Controllers
{
    public class Album : Controller
    {
        public IActionResult Index()
        {
            List<Album> Album = new List<Album>();
            {
            }
            return View();
        }
    }
}
