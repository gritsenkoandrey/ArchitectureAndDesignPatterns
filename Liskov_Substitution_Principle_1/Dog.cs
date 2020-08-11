namespace Liskov_Substitution_Principle_1
{
    public class Dog : /*AbstractAnimal*/ IType, ILegs
    {
        //public override string Type
        //{
        //    get { return "Dog"; }
        //}
        //public override int LegsCount
        //{
        //    get { return 4; }
        //}

        public string Type
        {
            get { return "Dog"; }
        }
        public int LegsCount
        {
            get { return 4; }
        }
    }
}