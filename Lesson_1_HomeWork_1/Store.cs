namespace Lesson_1_HomeWork_1
{
    public class Store : EntityBase
    {
        //public Store()
        //{
        //}

        public Store(IIdGenerator idGenerator) : base(idGenerator) { }

        public override string ToString() => $"{Id} - идентификатор";
    }
}