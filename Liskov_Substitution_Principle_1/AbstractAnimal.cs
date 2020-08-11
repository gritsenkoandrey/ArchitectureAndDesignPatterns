namespace Liskov_Substitution_Principle_1
{
    public abstract class AbstractAnimal
    {
        public virtual string Type
        {
            get { return "AbstractAnimal"; }
        }

        public virtual int LegsCount
        {
            get { return 0; }
        }
    }
}