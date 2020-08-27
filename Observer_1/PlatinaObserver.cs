using System;


namespace Observer_1
{
    /// <summary>
    /// Наблюдатель за ценой платины
    /// </summary>
    public class PlatinaObserver : IObserver<Mineral>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Биржа закрыта.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Ошибка: {error.Message}");
        }

        public void OnNext(Mineral mineral)
        {
            if (mineral.Name == "Платина" && mineral.Price < 1900)
            {
                Console.WriteLine($"Цена на платину {mineral.Price} уменьшилась ниже 1900$ за унцию");
            }
        }
    }
}