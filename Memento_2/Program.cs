using System;


namespace Memento_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            GameHistory game = new GameHistory();

            hero.Shoot(); // делаем выстрел, осталось 9 патронов
            game.History.Push(hero.SaveState()); // сохраняем игру
            hero.Shoot(); //делаем выстрел, осталось 8 патронов
            hero.RestoreState(game.History.Pop());
            hero.Shoot(); //делаем выстрел, осталось 8 патронов

            Console.ReadLine();
        }
    }
}