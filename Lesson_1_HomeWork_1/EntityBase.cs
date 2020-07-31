using System;


namespace Lesson_1_HomeWork_1
{
    //идея вынести всю ответственность по генерации Id в базовый класс
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