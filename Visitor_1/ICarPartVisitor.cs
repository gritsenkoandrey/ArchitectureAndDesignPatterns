namespace Visitor_1
{
    public interface ICarPartVisitor
    {
        void Visit(Car Car);
        void Visit(Engine engine);
        void Visit(Suspension suspension);
        void Visit(Body body);
    }
}