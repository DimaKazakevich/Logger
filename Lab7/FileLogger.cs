using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class FileLogger : ILogger
    {
        private FileLogger()
        {

        }

        private static FileLogger instance;

        public static FileLogger getInstance()
        {
            if (instance == null)
            {
                instance = new FileLogger();
            }
            return instance;
        }

        public void Log(Exception exception)
        {
            Log(exception.Message, MessageType.Error);
        }

        public void Log(string message, MessageType logType)
        {
            using (StreamWriter stream = new StreamWriter(@"Log.txt", true))
            {
                stream.WriteLine($"Log event: {logType.ToString()}");
                stream.WriteLine($"Additional information: {message}");

                stream.Close();
            }
        }
    }
}
