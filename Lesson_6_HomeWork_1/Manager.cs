using System;


namespace Lesson_6_HomeWork_1
{
    public class Manager : Handler
    {
        public Manager(LevelOfResponsibilities level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"Менеджер: {message}");
        }
    }
}