using System;


namespace Chain_of_Responsibility_1
{
    public enum LogLevel : byte
    {
        Info = 1,
        Debug = 2,
        Error = 3
    }

    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevel level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Standard Console::Logger: " + message);
        }
    }

    public class ErrorLogger : Logger
    {
        public ErrorLogger(LogLevel level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Error Console::Logger: " + message);
        }
    }

    public class FileLogger : Logger
    {
        public FileLogger(LogLevel level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }

    class Program
    {
        private static Logger GetChainOfLoggers()
        {
            var errorLogger = new ErrorLogger(LogLevel.Error);
            var fileLogger = new FileLogger(LogLevel.Debug);
            var consoleLogger = new ConsoleLogger(LogLevel.Info);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }

        static void Main(string[] args)
        {
            Logger logger = GetChainOfLoggers();

            logger.LogInfo(LogLevel.Info, "Обычная информация.");
            logger.LogInfo(LogLevel.Debug, "Отладочная инфрмация.");
            logger.LogInfo(LogLevel.Error, "Информация об ошибках.");

            Console.ReadLine();
        }
    }
}