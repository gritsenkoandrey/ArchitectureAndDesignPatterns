using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle_1
{
    class Book
    {
        // Принцип единственной ответственности
        ILogger logger = new ConsoleLogger();

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
            logger.Write(@"Книга полезна как опытным проектировщикам, 
чтоб структурировать понимание объектно-ориентированного проектирования, 
так и новичкам, чтоб избегать некачественных и нерасширяемых решений.");
        }
    }
}