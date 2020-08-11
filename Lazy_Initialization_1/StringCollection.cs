using System;


namespace Lazy_Initialization_1
{
    public class StringCollection
    {
        private string[] strings = new string[99];

        public void GetItem()
        {
            Console.WriteLine("Get Item");
        }
    }
}