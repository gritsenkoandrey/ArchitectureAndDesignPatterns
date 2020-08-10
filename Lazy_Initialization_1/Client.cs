using System;


namespace Lazy_Initialization_1
{
    public class Client
    {
        //StringCollection stringCollection = new StringCollection();
        Lazy<StringCollection> stringCollection = new Lazy<StringCollection>();

        public void UseItem()
        {
            //stringCollection.GetItem();
            stringCollection.Value.GetItem();
            Console.WriteLine("UseItem");
        }

        public void PrintItem()
        {
            Console.WriteLine("PrintItem");
        }
    }
}