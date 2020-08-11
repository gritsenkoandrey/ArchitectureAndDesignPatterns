using System;


namespace Single_Responsibility_Principle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileStore mobileStore = new MobileStore(new ConsolePhoneReader(), 
                new GeneralIPhoneBinder(), new GeneralIPhoneValidator(), new GeneralPhoneSaver());
            mobileStore.Process();

            Console.ReadLine();
        }
    }
}