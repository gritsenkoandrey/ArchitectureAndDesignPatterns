using System;
using System.IO;


// Внедрение зависимостей через конструктор (Constructor Injection)
namespace Dependency_Inversion_Principle_2
{
    public interface ILogger
    {
        void Write(string message);
    }
    public class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class FileLogger : ILogger
    {
        public void Write(string message)
        {
            File.WriteAllText(@"c:\log.txt", message);
        }
    }
    public class Book
    {
        ILogger _logger;

        public Book(ILogger logger)
        {
            _logger = logger;
        }

        public string GetTitle()
        {
            return "Приемы объектно-ориентированного проектирования. Паттерны проектирования";
        }
        public string GetAuthor()
        {
            return "Гамма Э., Хелм Р., Джонсон Р., Влиссидес Дж.";

        }
        public void TurnPage()
        {
        }
        public void PrintCurrentPage()
        {
            _logger.Write(@"Книга полезна как опытным проектировщикам, 
чтоб структурировать понимание объектно-ориентированного проектирования, 
так и новичкам, чтоб избегать некачественных и нерасширяемых решений.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new FileLogger());
            book.PrintCurrentPage();
        }
    }
}