namespace Memento_1
{
    /// <summary>
    /// Originator создает и сохраняет состояние в объект Memento.
    /// </summary>
    public class Originator
    {
        public string State { get; set; }

        public Memento SaveStateToMomento()
        {
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento memento)
        {
            State = memento.GetState();
        }
    }
}