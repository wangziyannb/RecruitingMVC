using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Recruiting.Filters
{
    public class Filter : IActionFilter
    {
        private readonly ILogger<Filter> _logger;
        public Filter(ILogger<Filter> logger)
        {

            _logger = logger;

        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Action is executed");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.Result is ViewResult viewResult) { 
                context.Result = new RedirectToActionResult("Error", "Home", null);
            }
            _logger.LogInformation("Action is being executed");
        }
    }
}
