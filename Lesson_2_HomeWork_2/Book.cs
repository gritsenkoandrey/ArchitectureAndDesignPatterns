using System;


namespace Lesson_2_HomeWork_2
{
    class Book : IDiscount, IPromocode, IPrice
    {
        public void SetDiscount(double discount)
        {
            throw new NotImplementedException();
        }

        public void SetPromocode(string promocode)
        {
            throw new NotImplementedException();
        }

        public void SetPrice(double price)
        {
            throw new NotImplementedException();
        }
    }
}