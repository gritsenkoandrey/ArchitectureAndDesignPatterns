using System;


namespace Builder_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // содаем объект пекаря
            Baker baker = new Baker();
            // создаем билдер для ржаного хлеба
            BreadBuilder breadBuilder = new RyeBreadBuilder();
            // выпекаем
            Bread ryeBread = baker.Bake(breadBuilder);
            Console.WriteLine(ryeBread.ToString());

            // создаем билдер для пшеничного хлеба
            breadBuilder = new WheatBreadBuilder();
            Bread wheatBread = baker.Bake(breadBuilder);
            Console.WriteLine(wheatBread.ToString());

            Console.ReadLine();
        }
    }
}