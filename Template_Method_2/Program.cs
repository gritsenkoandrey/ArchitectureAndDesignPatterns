using System;


namespace Template_Method_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Education e = new School();
            e.Learn();
            Console.WriteLine();

            e = new University();
            e.Learn();

            Console.ReadLine();
        }
    }
}