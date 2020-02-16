

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace WebApplicationPack
{
    public abstract class LoggableController : LoggableControllerBase, IActionFilter, IFilterMetadata, IAsyncActionFilter, IDisposable
    {
        public LoggableController(ILogger logger) : base(logger)
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }

        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
