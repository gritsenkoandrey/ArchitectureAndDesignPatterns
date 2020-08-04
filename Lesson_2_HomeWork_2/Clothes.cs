using System;


namespace Lesson_2_HomeWork_2
{
    class Clothes : IDiscount, IPromocode, IColor, ISize, IPrice
    {
        public void SetDiscount(double discount)
        {
            throw new NotImplementedException();
        }

        public void SetPromocode(string promocode)
        {
            throw new NotImplementedException();
        }

        public void SetColor()
        {
            throw new NotImplementedException();
        }

        public void SetSize()
        {
            throw new NotImplementedException();
        }

        public void SetPrice(double price)
        {
            throw new NotImplementedException();
        }
    }
}