using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFigure figure = new Rectangle(20, 40);
            //IFigure clonedFigure = figure.Clone();
            //figure.GetInfo();
            //clonedFigure.GetInfo();

            Circle figure = new Circle(50, 10, 15);
            //Circle clonedFigure = figure.Clone() as Circle;
            Circle clonedFigure = figure.DeepCopy() as Circle;
            figure.Point.X = 100;
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.ReadLine();
        }
    }
}