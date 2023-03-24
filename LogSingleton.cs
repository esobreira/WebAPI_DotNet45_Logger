using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebAPI_NLogger
{
    public sealed class LogSingleton
    {
        private static readonly Lazy<LogSingleton> _instance = new Lazy<LogSingleton>(() => new LogSingleton());
        private readonly ILogger _logger;

        public ILogger Logger => _logger;

        private LogSingleton()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public static LogSingleton Instance => _instance.Value;

        public void Log(string message)
        {
            _logger.Info(message);
            _logger.Debug(message);
        }
    }
}