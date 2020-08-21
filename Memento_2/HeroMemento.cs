namespace Memento_2
{
    /// <summary>
    /// Memento: хранитель, который сохраняет состояние объекта Originator
    /// и предоставляет полный доступ только этому объекту Originator.
    /// </summary>
    public class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int patrons, int lives)
        {
            Patrons = patrons;
            Lives = lives;
        }
    }
}