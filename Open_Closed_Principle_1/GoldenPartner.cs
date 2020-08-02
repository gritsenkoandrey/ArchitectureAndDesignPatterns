namespace Open_Closed_Principle_1
{
    class GoldenPartner : SilverPartner
    {
        public override double GetDiscount(double price)
        {
            return base.GetDiscount(price) - 100;
        }
    }
}