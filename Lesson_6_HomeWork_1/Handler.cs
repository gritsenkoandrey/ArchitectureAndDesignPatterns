namespace Lesson_6_HomeWork_1
{
    /// <summary>
    /// Handler: определяет интерфейс для обработки запроса
    /// </summary>
    public abstract class Handler
    {
        protected LevelOfResponsibilities level;
        protected Handler nextHandler;

        public void SetNextHandler(Handler handler)
        {
            nextHandler = handler;
        }

        public void HandlerInfo(LevelOfResponsibilities level, string message)
        {
            if (this.level <= level)
            {
                Write(message);
            }

            if (nextHandler != null)
            {
                nextHandler.HandlerInfo(level, message);
            }
        }

        protected abstract void Write(string message);
    }
}