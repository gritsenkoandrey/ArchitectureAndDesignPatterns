namespace Lesson_3_HomeWork
{
    public class CreateSquare : Create
    {
        public override Figure CreateFigure()
        {
            return new Square();
        }
    }
}