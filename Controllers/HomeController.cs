using Microsoft.AspNetCore.Mvc;
using Recruiting.Filters;
using Recruiting.Models;
using System.Diagnostics;

namespace Recruiting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        //[TypeFilter(typeof(Filter))]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            logger.LogInformation("abc");
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
