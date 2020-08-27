namespace Null_Object
{
    public class NullAnimal : AbstractAnimal
    {
        public override string GetName()
        {
            return "Отсутствует в списке";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}