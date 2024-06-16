using Microsoft.AspNetCore.Mvc;
using SparkInYou.Models;

namespace SparkInYou.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() // contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact) // contacts/check
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }
    }
}
