using System;


namespace Single_Responsibility_Principle_2
{
    class Report
    {
        public string Text { get; set; }

        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Переход к странице {0}", pageNumber);
        }

        public void Print(IPrinter printer)
        {
            Console.WriteLine("Печать отчета");
            printer.Print(Text);
        }
    }
}