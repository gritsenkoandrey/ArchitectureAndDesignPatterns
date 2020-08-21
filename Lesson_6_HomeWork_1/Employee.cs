using System;


namespace Lesson_6_HomeWork_1
{
    public class Employee : Handler
    {
        public Employee(LevelOfResponsibilities level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"Работник: {message}");
        }
    }
}