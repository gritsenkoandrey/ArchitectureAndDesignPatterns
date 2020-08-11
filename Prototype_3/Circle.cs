using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace Prototype_3
{
    [Serializable]
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    [Serializable]
    public class Circle : IFigure
    {
        private int radius;
        public Point Point { get; set; }

        public Circle(int r, int x, int y)
        {
            radius = r;
            Point = new Point { X = x, Y = y };
        }

        //public IFigure Clone()
        //{
        //    return new Circle(radius);
        //}

        //В то же время надо учитывать, что метод MemberwiseClone()
        //осуществляет неполное копирование - то есть копирование значимых типов.
        //Если же класс фигуры содержал бы объекты ссылочных типов,
        //то оба объекта после клонирования содержали бы ссылку на один и тот же ссылочный объект.
        public IFigure Clone()
        {
            return MemberwiseClone() as IFigure;
        }

        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter
                    (null, new StreamingContext(StreamingContextStates.Clone));
                binaryFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binaryFormatter.Deserialize(tempStream);
            }
            return figure;
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", radius, Point.X, Point.Y);
        }
    }
}