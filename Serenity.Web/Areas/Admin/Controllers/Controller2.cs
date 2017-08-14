using Microsoft.AspNetCore.Mvc;

namespace Serenity.Areas.Admin.Controllers
{
    public class Controller2 : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}