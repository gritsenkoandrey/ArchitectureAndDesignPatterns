using System;
using System.Collections.Generic;


namespace Lesson_1_4
{
    public abstract class Figure
    {
        public abstract double CalculateArea();
    }

    public class Triangle : Figure
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public override double CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }

    public class Square : Figure
    {
        public int Side { get; set; }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            CalculateFiguresArea(GetAllFigures());
        }

        private static List<Figure> GetAllFigures()
        {
            var figures = new List<Figure>();
            figures.Add(new Triangle() { Base = 7, Height = 7 });
            figures.Add(new Square() { Side = 9 });
            figures.Add(new Triangle() { Base = 19, Height = 8 });
            figures.Add(new Square() { Side = 33 });

            return figures;
        }

        //Принцип SOLID, Tell-Don’t-Ask (TDA). Этот принцип запрещает спрашивать у объекта
        //его текущее состояние перед тем, как попросить его выполнить что-либо.

        //private static double CalculateFiguresArea(List<Figure> figures)
        //{
        //    double area = 0.0;
        //    foreach (var figure in figures)
        //    {
        //        if (figure is Triangle)
        //        {
        //            Triangle triangle = figure as Triangle;
        //            area += (triangle.Base * triangle.Height) / 2;
        //        }
        //        else if (figure is Square)
        //        {
        //            Square square = figure as Square;
        //            area += square.Side * square.Side;
        //        }
        //    }
        //    return area;
        //}

        //В данной версии метода не нарушается принцип TDA,
        //логика вычисления площади оказалась скрыта внутри отдельных классов.

        private static double CalculateFiguresArea(List<Figure> figures)
        {
            double area = 0.0;
            foreach (var figure in figures)
            {
                area += figure.CalculateArea();
            }
            return area;
        }
    }
}