using System;


namespace Observer_1
{
    /// <summary>
    /// Наблюдатель за ценой золота
    /// </summary>
    public class GoldObserver : IObserver<Mineral>
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
            if (mineral.Name == "Золото")
            {
                Console.WriteLine($"Цена на золото: {mineral.Price}");
            }
        }
    }
}