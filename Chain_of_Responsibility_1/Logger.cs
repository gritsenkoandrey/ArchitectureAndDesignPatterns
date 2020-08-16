namespace Chain_of_Responsibility_1
{
    public abstract class Logger
    {
        protected LogLevel level;
        protected Logger nextLogger;

        public void SetNextLogger(Logger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogInfo(LogLevel level, string message)
        {
            if (this.level <= level)
            {
                Write(message);
            }

            if (nextLogger != null)
            {
                nextLogger.LogInfo(level, message);
            }
        }

        protected abstract void Write(string message);
    }
}