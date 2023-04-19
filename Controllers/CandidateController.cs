using Microsoft.AspNetCore.Mvc;

namespace Recruiting.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
