using System;


namespace Chain_of_Responsibility_2
{
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handler(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            }
            else if (Successor != null)
            {
                Successor.Handler(receiver);
            }
        }
    }
}