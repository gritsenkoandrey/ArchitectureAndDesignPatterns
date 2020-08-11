namespace Factory_Method_4
{
    // абстрактный класс строительной компании
    public abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name)
        {
            Name = name;
        }

        //Fabric Method
        //public abstract IHouse Create();
    }
}