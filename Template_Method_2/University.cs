using System;


namespace Template_Method_2
{
    public class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем диплом о высшем образовании");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
        }

        public override void PassExams()
        {
            Console.WriteLine("Сдаем экзамен по специальности");
        }
    }
}