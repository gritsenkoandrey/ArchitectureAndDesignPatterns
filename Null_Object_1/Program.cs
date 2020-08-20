using System;


namespace Template_Method_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Chess();
            game.Play();
            Console.WriteLine();

            game = new Preferans();
            game.Play();

            Console.ReadLine();
        }
    }
}