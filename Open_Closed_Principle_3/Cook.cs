namespace Open_Closed_Principle_3
{
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void MakeDinner(MealBase[] menu)
        {
            foreach (var meal in menu)
            {
                meal.Make();
            }
        }

        //public void MakeDinner()
        //{
        //    Console.WriteLine("Чистим картошку");
        //    Console.WriteLine("Ставим почищенную картошку на огонь");
        //    Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        //    Console.WriteLine("Посыпаем пюре специями и зеленью");
        //    Console.WriteLine("Картофельное пюре готово");
        //}
    }
}