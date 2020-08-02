namespace Open_Closed_Principle_1
{
    class SilverPartner : Client
    {
        public override double GetDiscount(double price)
        {
            return base.GetDiscount(price) - 100;
        }
    }
}