namespace Chain_of_Responsibility_2
{
    public abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handler(Receiver receiver);
    }
}