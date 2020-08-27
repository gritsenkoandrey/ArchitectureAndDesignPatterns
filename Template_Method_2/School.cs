using System;


namespace Template_Method_2
{
    public class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем уроки, делаем домашние задания");
        }
    }
}