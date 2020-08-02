using System;
using System.IO;


// Внедрение зависимостей через свойства (Property Injection)
namespace Dependency_Inversion_Principle_3
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

    class Book
    {
        ILogger _logger;

        public Book() { }

        public ILogger Logger
        {
            set
            {
                _logger = value;
            }
        }

        public string GetTitle()
        {
            return "Приемы объектно-ориентированного проектирования. Паттерны проектирования";
        }

        public string GetAuthor()
        {
            return "Гамма Э., Хелм Р., Джонсон Р., Влиссидес Дж.";

        }

        public void TurnPage() { }

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
            Book book = new Book() { Logger = new FileLogger() };
            book.PrintCurrentPage();
        }
    }
}