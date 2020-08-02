using System;


namespace LiskovSubstitutionPrinciple_3
{
    class MicroAccount : Account
    {
        public MicroAccount(int sum) : base(sum) { }
        public override int Capital { get => capital; set => capital = value; }
        public override void SetCapital(int money)
        {
            if (money < 0)
            {
                throw new Exception("Нельзя положить на счет меньше 0");
            }

            if (money > 100)
            {
                throw new Exception("Нельзя положить на счет больше 100");
            }

            Capital = money;
        }

        public override decimal GetInterest(decimal sum, int month, int rate)
        {
            if (sum < 0 || month > 12 || month < 1 || rate < 0)
            {
                throw new Exception("Некорректные данные");
            }

            decimal result = sum;

            for (int i = 0; i < month; i++)
            {
                result += result * rate / 100;
            }

            return result;
        }
    }
}