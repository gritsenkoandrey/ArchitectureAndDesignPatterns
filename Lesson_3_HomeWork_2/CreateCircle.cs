namespace Lesson_3_HomeWork_2
{
    public class CreateCircle : ICreate
    {
        public IFigure CreateFigure()
        {
            return new Circle();
        }
    }
}