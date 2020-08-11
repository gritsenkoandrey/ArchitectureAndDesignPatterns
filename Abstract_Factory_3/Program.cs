using System;


namespace Abstract_Factory_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero war = new Hero(new WarriorFactory());
            war.Hit();
            war.Run();

            Console.ReadLine();
        }
    }
}