using System;


namespace Lesson_1_3
{
    public abstract class EntityBase
    {
        protected long Id { get; private set; }

        protected EntityBase()
        {
            Id = CalculateId();
        }

        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}