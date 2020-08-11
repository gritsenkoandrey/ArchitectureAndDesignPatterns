using System;
using System.Collections.Generic;


namespace Lesson_3_HomeWork_2
{
    class Program
    {
        // реализация через интерфейсы
        static void Main(string[] args)
        {
            //Create circle = new CreateCircle();
            //Create square = new CreateSquare();
            //Create triangle = new CreateTriangle();
            //Figure[] figures = { circle.CreateFigure(), square.CreateFigure(), triangle.CreateFigure() };

            ICreate[] creates = { new CreateCircle(), new CreateSquare(), new CreateTriangle() };
            IFigure[] figures = new IFigure[creates.Length];

            for (int i = 0; i < creates.Length; i++)
            {
                figures[i] = creates[i].CreateFigure();
            }

            Console.ReadLine();
        }
    }
}