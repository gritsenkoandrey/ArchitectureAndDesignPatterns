namespace Lesson_1_HomeWork_1
{
    public class Customer : EntityBase
    {
        public string Description { get; private set; }

        //public Customer(string description)
        //{
        //    Description = description;
        //}

        public Customer(IIdGenerator idGenerator, string description) : base(idGenerator) 
        {
            Description = description;
        }

        public override string ToString() => $"{Id} - идентификатор, {Description} - описание";
    }
}