using System;
using System.Collections.Generic;


namespace Lesson_3_HomeWork
{
    class Program
    {
        // реализация через абстрактные классы
        static void Main(string[] args)
        {
            //Create circle = new CreateCircle();
            //Create square = new CreateSquare();
            //Create triangle = new CreateTriangle();
            //Figure[] figures = { circle.CreateFigure(), square.CreateFigure(), triangle.CreateFigure() };

            Create[] creates = { new CreateCircle(), new CreateSquare(), new CreateTriangle() };
            Figure[] figures = new Figure[creates.Length];

            for (int i = 0; i < creates.Length; i++)
            {
                figures[i] = creates[i].CreateFigure();
            }

            Console.ReadLine();
        }
    }
}