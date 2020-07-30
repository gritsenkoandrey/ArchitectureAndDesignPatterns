using System;
using System.Collections.Generic;
using System.Linq;


namespace Lesson_1_2
{
    public class Animal
    {
        public string AnimalName { get; set; }
        public int LegsCount { get; set; }
        public string AnimalType { get; set; }

        //public override string ToString()
        //{
        //    return $"Число ног: {LegsCount}, тип: {AnimalType}, название: {AnimalName}";
        //}
    }

    public class Program
    {
        private static readonly int IndexOfDisplayedAnimal = Constants.IndexOfDisplayedAnimal;

        private static void Main(string[] args)
        {
            DoMagicNumber();

            Console.ReadLine();
        }

        private static IEnumerable<Animal> GetAnimals()
        {
            return new List<Animal>
            {
                new Animal()
                {
                    LegsCount = 4,
                    AnimalType = "mammals",
                    AnimalName = "dog"
                },
                new Animal()
                {
                    LegsCount = 4,
                    AnimalType = "mammals",
                    AnimalName = "cow"
                },
                new Animal()
                {
                    LegsCount = 2,
                    AnimalType = "birds",
                    AnimalName = "duck"
                }
            };
        }

        private static void DoMagicNumber()
        {
            List<Animal> animals = GetAnimals().ToList();

            if (animals.Count > 0)
            {
                Animal displayedAnimal = animals[IndexOfDisplayedAnimal];

                Console.WriteLine($"Число ног: {displayedAnimal.LegsCount}," +
                    $"тип: {displayedAnimal.AnimalType}, название: {displayedAnimal.AnimalName}");

                //foreach (var animal in animals)
                //{
                //    Console.WriteLine(animal);
                //}
            }
        }
    }
}