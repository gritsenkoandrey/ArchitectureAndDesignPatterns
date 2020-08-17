using System;


namespace Lesson_6_HomeWork_1
{
    public class Director : Handler
    {
        public Director(LevelOfResponsibilities level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"Директор: {message}");
        }
    }
}