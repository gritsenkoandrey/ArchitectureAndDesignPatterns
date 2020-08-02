namespace Open_Closed_Principle_1
{
    class Client
    {
        //public int ClientType { get; set; }
        //public double GetDiscount(double price)
        //{
        //    return (ClientType == 1) ? price - 100 : price - 50;
        //}
        public virtual double GetDiscount(double price)
        {
            return price - 50;
        }
    }
}