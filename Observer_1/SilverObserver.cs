using System;


namespace Observer_1
{
    /// <summary>
    /// Наблюдатель за ценой серебра
    /// </summary>
    public class SilverObserver : IObserver<Mineral>
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
            if (mineral.Name == "Серебро" && mineral.Price > 20)
            {
                Console.WriteLine($"Цена на серебро {mineral.Price} превысила 20$ за унцию");
            }
        }
    }
}