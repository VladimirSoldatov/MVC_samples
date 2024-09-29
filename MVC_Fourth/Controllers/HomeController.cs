using Microsoft.AspNetCore.Mvc;

namespace MVC_Fourth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
