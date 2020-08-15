using System;


namespace Bridge_2
{
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage language) : base(language) { }

        public override void EarnMoney()
        {
            Console.WriteLine("Получаем в конце месяца зарплату");
        }
    }
}