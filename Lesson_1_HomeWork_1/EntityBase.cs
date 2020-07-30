using System;


namespace Lesson_1_HomeWork_1
{
    public abstract class EntityBase : IIdGenerator
    {
        protected long Id { get; set; }

        protected EntityBase()
        {
            Id = CalculateId();
        }

        // можно убрать интерфейс и сделать метод private
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}