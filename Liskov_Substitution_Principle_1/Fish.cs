using System;


namespace Liskov_Substitution_Principle_1
{
    class Fish : /*AbstractAnimal*/ IType
    {
        //public override string Type
        //{
        //    get { return "Fish"; }
        //}
        //public override int LegsCount
        //{
        //    get { throw new NotImplementedException(); }
        //}

        public string Type
        {
            get { return "Fish"; }
        }
    }
}