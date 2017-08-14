using Microsoft.AspNetCore.Mvc;

namespace Serenity.Areas.Market.Controllers
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