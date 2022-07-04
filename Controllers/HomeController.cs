using Microsoft.AspNetCore.Mvc;

namespace WebSite11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
