using System;


namespace Abstract_Factory_3
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}