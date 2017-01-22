using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNet.Services.Logging;

namespace DotNet.UnitTests.Services.LoggingService
{

    [TestClass]
    public class LogErrorShould
    {
        [TestMethod]
        public void LogError()
        {
            var service = new DotNet.Services.Logging.LoggingService();
            service.LogError(new Exception("Deliberate by Ernie"));
        }
    }
}
