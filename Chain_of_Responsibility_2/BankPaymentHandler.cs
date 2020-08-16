using System;


namespace Chain_of_Responsibility_2
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handler(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
            {
                Console.WriteLine("Выполняем банковский перевод");
            }
            else if (Successor != null)
            {
                Successor.Handler(receiver);
            }
        }
    }
}