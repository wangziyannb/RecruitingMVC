using Microsoft.AspNetCore.Mvc;
using Recruiting.Filters;

namespace Recruiting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        [TypeFilter(typeof(Filter))]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            logger.LogInformation("abc");
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
