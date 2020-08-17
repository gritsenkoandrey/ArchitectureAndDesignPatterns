using System;


namespace Lesson_6_HomeWork_1
{
    public class Program
    {
        private static Handler GetChainOfHandlers()
        {
            Employee employee = new Employee(LevelOfResponsibilities.FirstLevel);
            Manager manager = new Manager(LevelOfResponsibilities.MidLevel);
            Director director = new Director(LevelOfResponsibilities.HighLevel);
            President president = new President(LevelOfResponsibilities.VeryHighLevel);

            employee.SetNextHandler(manager);
            manager.SetNextHandler(director);
            director.SetNextHandler(president);

            return employee;
        }

        static void Main(string[] args)
        {
            Handler handler = GetChainOfHandlers();
            handler.HandlerInfo(LevelOfResponsibilities.FirstLevel, "может одобрить кредит в 100 $");
            handler.HandlerInfo(LevelOfResponsibilities.MidLevel, "может одобрить кредит в 1 000 $");
            handler.HandlerInfo(LevelOfResponsibilities.HighLevel, "может одобрить кредит в 10 000 $");
            handler.HandlerInfo(LevelOfResponsibilities.VeryHighLevel, "может одобрить кредит в 100 000 $");

            Console.ReadLine();
        }
    }
}