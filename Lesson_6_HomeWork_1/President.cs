using System;


namespace Lesson_6_HomeWork_1
{
    public class President : Handler
    {
        public President(LevelOfResponsibilities level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"Президент: {message}");
        }
    }
}