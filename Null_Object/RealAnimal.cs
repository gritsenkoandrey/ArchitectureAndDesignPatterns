namespace Null_Object
{
    public class RealAnimal : AbstractAnimal
    {
        public RealAnimal(string name)
        {
            this.name = name;
        }
        public override string GetName()
        {
            return this.name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}