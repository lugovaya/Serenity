using Microsoft.AspNetCore.Mvc;

namespace Serenity.Areas.Market.Controllers
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}