using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new MicroAccount(200);
            //InitializeAccount(account);
            CalculateInterest(account);

            Console.Read();
        }

        public static void InitializeAccount(Account account)
        {
            account.SetCapital(200);
            Console.WriteLine(account.Capital);
        }

        public static void CalculateInterest(Account account)
        {
            // 1000 + 1000 * 10 / 100 + 100 (бонус)
            decimal sum = account.GetInterest(1000, 1, 10);
            // ожидаем 1200
            if (sum != 1200)
            {
                throw new Exception("Неожиданная сумма при вычислениях");
            }
        }
    }
}