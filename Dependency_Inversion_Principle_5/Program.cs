using System;


namespace Dependency_Inversion_Principle_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new ConsolePrinter());
            book.Print();
            book.Printer = new HtmlPrinter();
            book.Print();

            Console.ReadLine();
        }
    }
}