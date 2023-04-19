using Microsoft.AspNetCore.Mvc;
using RecCore.Contracts.Services;
using RecCore.Models;
using RecInfrastructure.Services;

namespace Recruiting.Controllers
{
    public class JobRequirementController : Controller
    {
        private readonly ILogger<JobRequirementController> _logger;
        private readonly IJobRequirementService jobRequirementService;
        public JobRequirementController(ILogger<JobRequirementController> logger, IJobRequirementService jobRequirementService)
        {
            _logger = logger;
            this.jobRequirementService = jobRequirementService;
        }
        // GET: JobRequirementController
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        // GET: JobRequirementController/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var res=await jobRequirementService.GetJobRequirementByIdAsync(id);
            return View(res);
        }
        // GET: JobRequirementController/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(JobRequirementRequestModel model)
        {
            if (model != null)
            {
                await jobRequirementService.AddJobRequirementAsync(model);
                return View(model);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Submitted()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
