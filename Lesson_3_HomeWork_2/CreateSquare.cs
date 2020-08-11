namespace Lesson_3_HomeWork_2
{
    public class CreateSquare : ICreate
    {
        public IFigure CreateFigure()
        {
            return new Square();
        }
    }
}