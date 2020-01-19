using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class ConsoleLogger : ILogger
    {
        private ConsoleLogger()
        {

        }

        private static ConsoleLogger instance;

        public static ConsoleLogger getInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }

        public void Log(Exception exception)
        {
            Log(exception.Message, MessageType.Error);
        }

        public void Log(string message, MessageType logType)
        {
            ConsoleColor consoleColor = default;

            switch (logType)
            {
                case MessageType.Error:
                    consoleColor = ConsoleColor.Red;
                    break;
                case MessageType.Info:
                    consoleColor = ConsoleColor.Green;
                    break;
                case MessageType.Warning:
                    consoleColor = ConsoleColor.Yellow;
                    break;
            }

            Console.ForegroundColor = consoleColor;

            Console.WriteLine("Log event:");
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
