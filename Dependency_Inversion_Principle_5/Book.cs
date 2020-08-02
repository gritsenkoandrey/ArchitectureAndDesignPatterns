namespace Dependency_Inversion_Principle_5
{
    class Book
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }

        //public ConsolePrinter Printer { get; set; }

        public Book (IPrinter printer)
        {
            Printer = printer;
        }

        public void Print()
        {
            Printer.Print(Text);
        }
    }
}