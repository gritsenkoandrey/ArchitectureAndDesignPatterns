using System;


namespace Lesson_3_HomeWork_2
{
    public class Square : IFigure
    {
        public Square()
        {
            CreateConcreteFigure();
        }

        public void CreateConcreteFigure()
        {
            Console.WriteLine("Квадрат создан");
        }
    }
}