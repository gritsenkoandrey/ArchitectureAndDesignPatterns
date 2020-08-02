using System;


namespace LiskovSubstitutionPrinciple_3
{
    class Account
    {
        //public int Capital { get; protected set; }

        protected int capital;

        // инварианты
        public Account(int sum)
        {
            if (sum < 100)
            {
                throw new Exception("Некорректная сумма");
            }
            capital = sum;
        }

        // инварианты
        public virtual int Capital
        {
            get { return capital; }
            set
            {
                if (value < 100)
                {
                    throw new Exception("Некорректная сумма");
                }
                capital = value;
            }
        }

        public virtual void SetCapital(int money)
        {
            if (money < 0)
            {
                throw new Exception("Нельзя положить на счет меньше 0");
            }

            Capital = money;
        }

        public virtual decimal GetInterest(decimal sum, int month, int rate)
        {
            //предусловие
            if (sum < 0 || month > 12 || month < 1 || rate < 0)
            {
                throw new Exception("Некорректные данные");
            }

            decimal result = sum;

            for (int i = 0; i < month; i++)
            {
                result += result * rate / 100;
            }

            // постусловие
            if (sum >= 1000)
            {
                //добавляем бонус
                result += 100;
            }

            return result;
        }
    }
}