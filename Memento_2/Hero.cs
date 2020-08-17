using System;


namespace Memento_2
{
    /// <summary>
    /// Originator: создает объект хранителя для сохранения своего состояния
    /// </summary>
    public class Hero
    {
        private int _patrons = 10; // кол-во патронов
        private int _lives = 5; // кол-во жизней

        public void Shoot()
        {
            if (_patrons > 0)
            {
                _patrons--;
                Console.WriteLine($"Производим выстрел. Осталось {_patrons} патронов");
            }
            else
            {
                Console.WriteLine("Патронов больше нет");
            }
        }

        /// <summary>
        /// Сохранение состояния
        /// </summary>
        public HeroMemento SaveState()
        {
            Console.WriteLine($"Сохранение игры. Параметры: {_patrons} патронов, {_lives} жизней");
            return new HeroMemento(_patrons, _lives);
        }

        /// <summary>
        /// Восстановление состояния.
        /// </summary>
        public void RestoreState(HeroMemento memento)
        {
            _patrons = memento.Patrons;
            _lives = memento.Lives;
            Console.WriteLine($"Восстановление игры. Параметры: {_patrons} патронов, {_lives} жизней");
        }
    }
}