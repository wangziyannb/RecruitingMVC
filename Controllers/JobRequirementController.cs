using Microsoft.AspNetCore.Mvc;
using RecCore.Models;
using RecInfrastructure.Services;

namespace Recruiting.Controllers
{
    public class JobRequirementController : Controller
    {
        private readonly ILogger<JobRequirementController> _logger;
        private readonly JobRequirementService jobRequirementService;
        public JobRequirementController(ILogger<JobRequirementController> logger, JobRequirementService jobRequirementService)
        {
            _logger = logger;
            this.jobRequirementService = jobRequirementService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JobRequirementRequestModel model)
        {
            return View();
        }
    }
}
