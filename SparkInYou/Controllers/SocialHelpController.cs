using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkInYou.Controllers
{
    public class SocialHelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
