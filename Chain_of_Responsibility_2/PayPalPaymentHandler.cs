using System;


namespace Chain_of_Responsibility_2
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handler(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через PayPal");
            }
            else if (Successor != null)
            {
                Successor.Handler(receiver);
            }
        }
    }
}