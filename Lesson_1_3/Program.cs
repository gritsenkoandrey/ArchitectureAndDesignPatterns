using System;


namespace Lesson_1_3
{
    public class Customer /*: EntityBase*/
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }
        public string Description { get; set; }

        public Customer(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }

        //private static long CalculateId()
        //{
        //    //long id = DateTime.Now.Ticks;
        //    long id = IdHelper.CalculateId();
        //    return id;
        //}
    }

    public class Store /*: EntityBase*/
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }

        public Store(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }

        //private static long CalculateId()
        //{
        //    //long id = DateTime.Now.Ticks;
        //    long id = IdHelper.CalculateId();
        //    return id;
        //}
    }

    //public static class IdHelper
    //{
    //    public static long CalculateId()
    //    {
    //        long id = DateTime.Now.Ticks;
    //        return id;
    //    }
    //}

    //Для решения проблемы сильной связанности без использования базового класса EntityBase
    //может быть применен метод внедрения зависимости через конструктор (constructor injection).
    //Для этого выносим логику формирования id во внешний класс, который скрываем за интерфейсом IIdGenerator
    public class DefaultIdGenerator : IIdGenerator
    {
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //пример вызова конструктора класса Store
            Store store = new Store(new DefaultIdGenerator());
        }
    }
}