using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class LoggerFactory
    {
        public static ILogger GetLogger(LoggerType logger)
        {
            if (logger == LoggerType.File)
            {
                return FileLogger.getInstance();
            }

            if (logger == LoggerType.Console)
            {
                return ConsoleLogger.getInstance();
            }

            return null;
        }
    }
}
