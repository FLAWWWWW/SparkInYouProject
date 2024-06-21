using Microsoft.AspNetCore.Mvc;

namespace SparkInYou.Controllers
{
    public class PersonalAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
