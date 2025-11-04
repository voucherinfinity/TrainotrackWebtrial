using Microsoft.AspNetCore.Mvc;

namespace TrainotrackWeb.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
