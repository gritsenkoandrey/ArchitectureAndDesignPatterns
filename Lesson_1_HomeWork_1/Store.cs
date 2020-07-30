namespace Lesson_1_HomeWork_1
{
    public class Store : EntityBase
    {
        public Store() : base()
        {

        }

        public override string ToString()
        {
            return $"{Id} - идентификатор";
        }
    }
}