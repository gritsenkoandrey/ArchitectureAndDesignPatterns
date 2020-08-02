using System;


namespace Lesson_1_HomeWork_1
{
    //идея вынести всю ответственность по генерации Id в базовый класс
    public abstract class EntityBase
    {
        private readonly IIdGenerator _idGenerator;
        protected long Id { get; private set; }

        //protected EntityBase()
        //{
        //    Id = CalculateId();
        //}

        public EntityBase(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator ?? throw new ArgumentNullException();
            Id = _idGenerator.CalculateId();
        }

        //private long CalculateId()
        //{
        //    long id = DateTime.Now.Ticks;
        //    return id;
        //}
    }
}