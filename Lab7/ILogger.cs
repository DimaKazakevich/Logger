using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    interface ILogger
    {
            void Log(Exception exception);
            void Log(string message, MessageType logType);
    }
}
