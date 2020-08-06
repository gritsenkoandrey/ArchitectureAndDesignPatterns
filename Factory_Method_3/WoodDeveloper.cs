namespace Factory_Method_3
{
    // строит деревянные дома
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {

        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}