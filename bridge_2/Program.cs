using System;


namespace Bridge_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********");
            Programmer p = new FreelanceProgrammer(new CSharpLanguage());
            p.DoWork();
            p.EarnMoney();

            Console.WriteLine("**********");
            p.Language = new CPPLanguage();
            p.DoWork();
            p.EarnMoney();

            Console.WriteLine("**********");
            p = new CorporateProgrammer(new CSharpLanguage());
            p.DoWork();
            p.EarnMoney();

            Console.WriteLine("**********");
            p.Language = new CPPLanguage();
            p.DoWork();
            p.EarnMoney();

            Console.ReadLine();
        }
    }
}