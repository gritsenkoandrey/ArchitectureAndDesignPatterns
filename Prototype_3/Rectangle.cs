using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_3
{
    public class Rectangle : IFigure
    {
        private int width;
        private int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        //public IFigure Clone()
        //{
        //    return new Rectangle(width, height);
        //}

        //В то же время надо учитывать, что метод MemberwiseClone()
        //осуществляет неполное копирование - то есть копирование значимых типов.
        //Если же класс фигуры содержал бы объекты ссылочных типов,
        //то оба объекта после клонирования содержали бы ссылку на один и тот же ссылочный объект.
        public IFigure Clone()
        {
            return MemberwiseClone() as IFigure;
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", height, width);
        }
    }
}