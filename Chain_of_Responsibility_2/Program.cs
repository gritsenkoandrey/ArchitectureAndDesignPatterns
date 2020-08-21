using System;


namespace Chain_of_Responsibility_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, false);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHadler;

            bankPaymentHandler.Handler(receiver);

            Console.ReadLine();
        }
    }
}