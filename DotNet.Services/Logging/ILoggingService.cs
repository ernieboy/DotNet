using System;

namespace DotNet.Services.Logging
{
    public interface ILoggingService
    {
        void LogError(Exception e);
    }
}
