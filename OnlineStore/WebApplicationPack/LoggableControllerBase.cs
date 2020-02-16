using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplicationPack
{
    public class LoggableControllerBase : ControllerBase
    {
        private ILogger Logger { get; set; }

        public LoggableControllerBase(ILogger logger) : base()
        {
            Logger = logger;
        }

        public override StatusCodeResult StatusCode(int statusCode)
        {
            Logger.LogError($"Returned StatusCode:  [{ statusCode.ToString()}]");

            return base.StatusCode(statusCode);
        }

        public override ObjectResult StatusCode(int statusCode, object value)
        {
            Logger.LogError($"Returned StatusCode:  [{ statusCode.ToString()}], with message: [{value?.ToString()}]");

            return base.StatusCode(statusCode, value);
        }
    }
}
