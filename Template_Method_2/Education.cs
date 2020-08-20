using System;


namespace Template_Method_2
{
    public abstract class Education : Lerning
    {
        /// <summary>
        /// Чтобы сокрыть алгоритм от изменения в классах наследниках,
        /// метод Learn объявляется с ключевым словом sealed.
        /// </summary>
        public sealed override void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams()
        {
            Console.WriteLine("Сдаем выпускные экзамены");
        }
        public abstract void GetDocument();
    }

    public abstract class Lerning
    {
        public abstract void Learn();
    }
}