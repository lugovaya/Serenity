using Microsoft.AspNetCore.Mvc;

namespace Serenity.Areas.Account.Controllers
{
    public class Controller1 : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}