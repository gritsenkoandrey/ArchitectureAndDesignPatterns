namespace Lesson_3_HomeWork
{
    public class CreateTriangle : Create
    {
        public override Figure CreateFigure()
        {
            return new Triangle();
        }
    }
}