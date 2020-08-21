using System;


namespace Bridge_2
{
    public class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage language) : base(language) { }

        public override void EarnMoney()
        {
            Console.WriteLine("Получаем оплату за выполненный заказ");
        }
    }
}