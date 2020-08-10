namespace Prototype_2
{
    public class Client
    {
        public void Operator()
        {
            Prototype p = new ConcretePrototypeOne(1);
            Prototype clone = p.Clone();
            p = new ConcretePrototypeTwo(2);
            clone = p.Clone();
        }
    }

    public abstract class Prototype
    {
        public int Id { get; private set; }
        public Prototype(int id)
        {
            Id = id;
        }
        public abstract Prototype Clone();
    }

    public class ConcretePrototypeOne : Prototype
    {
        public ConcretePrototypeOne(int id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return new ConcretePrototypeOne(Id);
        }
    }

    public class ConcretePrototypeTwo : Prototype
    {
        public ConcretePrototypeTwo(int id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return new ConcretePrototypeTwo(Id);
        }
    }
}