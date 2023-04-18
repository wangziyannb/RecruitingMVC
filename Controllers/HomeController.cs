using Microsoft.AspNetCore.Mvc;

namespace Recruiting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
