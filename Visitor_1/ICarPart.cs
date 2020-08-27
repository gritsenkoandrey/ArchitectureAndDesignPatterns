namespace Visitor_1
{
    public interface ICarPart
    {
        void Accept(ICarPartVisitor CarPartVisitor);
    }
}