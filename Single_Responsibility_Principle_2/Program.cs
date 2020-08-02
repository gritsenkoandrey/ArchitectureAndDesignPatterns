using System;


namespace Single_Responsibility_Principle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();
            Report report = new Report();
            report.Text = "HomeWork";
            report.Print(printer);

            Console.ReadLine();
        }
    }
}