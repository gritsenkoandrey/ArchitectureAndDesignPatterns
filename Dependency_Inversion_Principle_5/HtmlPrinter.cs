using System;


namespace Dependency_Inversion_Principle_5
{
    class HtmlPrinter : IPrinter
    {
        void IPrinter.Print(string text)
        {
            Console.WriteLine("Печать в html");
        }
    }
}