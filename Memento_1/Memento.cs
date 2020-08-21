namespace Memento_1
{
    /// <summary>
    /// Класс Memento сохраняет состояние объекта.
    /// </summary>
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }
    }
}