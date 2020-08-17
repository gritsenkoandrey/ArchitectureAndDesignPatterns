using System.Collections.Generic;


namespace Memento_1
{
    /// <summary>
    /// CareTaker отвечает за восстановление состояния из объекта Memento.
    /// </summary>
    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }
    }
}