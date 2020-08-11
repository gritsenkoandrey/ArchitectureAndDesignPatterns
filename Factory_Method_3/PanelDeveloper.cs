namespace Factory_Method_3
{
    // строит панельные дома
    public class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        {

        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}