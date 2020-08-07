namespace Lesson_3_HomeWork_2
{
    public class CreateTriangle : ICreate
    {
        public IFigure CreateFigure()
        {
            return new Triangle();
        }
    }
}