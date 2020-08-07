namespace Lesson_3_HomeWork
{
    public class CreateCircle : Create
    {
        public override Figure CreateFigure()
        {
            return new Circle();
        }
    }
}