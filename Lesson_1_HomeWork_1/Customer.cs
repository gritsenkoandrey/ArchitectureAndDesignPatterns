namespace Lesson_1_HomeWork_1
{
    public class Customer : EntityBase
    {
        public string Description { get; private set; }

        public Customer(string description) : base ()
        {
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id} - идентификатор, {Description} - описание";
        }
    }
}