using System;
using System.Text;
using Common.Logging;
using DotNetLibrary.Utilities.Tools;

namespace DotNet.Services.Logging
{
    public class LoggingService : ILoggingService
    {
        private  readonly ILog _logger = LogManager.GetLogger(typeof(LoggingService));  

        public void LogError(Exception e)
        {
            string message = Error.BuildExceptionDetail(e, new StringBuilder()).ToString();
            _logger.Error(message);
        }
    }
}
