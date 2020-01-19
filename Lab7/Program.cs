using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = LoggerFactory.GetLogger(LoggerType.Console);
            var fileLogger = LoggerFactory.GetLogger(LoggerType.File);

            var registration = new Registration(consoleLogger);

            bool catchFlag = false;
            do
            {
                try
                {
                    int x1 = 5;
                    int y1 = 3;
                    consoleLogger.Log($"I have just divided {x1} on {y1}.", MessageType.Warning);
                    fileLogger.Log($"I have just divided {x1} on {y1}.", MessageType.Warning);
                    double divRes = x1 / y1;

                    registration.ProcessRegistration();
                }
                catch (AgeException ex)
                {
                    consoleLogger.Log(ex);
                    fileLogger.Log(ex);
                    catchFlag = true;
                }
                catch (IntException ex)
                {
                    consoleLogger.Log(ex);
                    fileLogger.Log(ex);
                    catchFlag = true;
                }

                catch (CharException ex)
                {
                    consoleLogger.Log(ex);
                    fileLogger.Log(ex);
                    catchFlag = true;
                }
                catch (DivideByZeroException ex)
                {
                    consoleLogger.Log(ex);
                    fileLogger.Log(ex);
                    catchFlag = true;
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine(catchFlag ? "Please, try again" : "You are registered");
                }
            } while (true);
        }
    }
}
