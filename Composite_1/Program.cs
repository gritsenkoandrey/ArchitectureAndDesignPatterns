using System;


namespace Composite_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IParticipant ivan = new Addressee { Name = "Иван" };
            IParticipant sergey = new Addressee { Name = "Сергей" };
            IParticipant tanya = new Addressee { Name = "Таня" };
            IParticipant sveta = new Addressee { Name = "Света" };
            IParticipant katya = new Addressee { Name = "Катя" };

            IParticipant group1 = new Group { Name = "Group1", Members = { ivan, sergey } };
            IParticipant group2 = new Group { Name = "Group2", Members = { group1, tanya, sveta, katya } };

            var participants = new Group { Members = { ivan, sergey } };
            var participants1 = new Group { Name = "andrey" };
            participants.Send();
            tanya.Send();
            group1.Send();

            Console.ReadLine();
        }
    }
}