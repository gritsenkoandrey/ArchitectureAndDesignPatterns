using System.Collections.Generic;


namespace Memento_2
{
    /// <summary>
    /// Caretaker: выполняет только функцию хранения 
    /// объекта Memento, в то же время у него нет полного 
    /// доступа к хранителю и никаких других операций над 
    /// хранителем, кроме собственно сохранения, он не производит
    /// </summary>
    public class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }

        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}