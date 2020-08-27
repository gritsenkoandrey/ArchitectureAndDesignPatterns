namespace Null_Object
{
    public abstract class AbstractAnimal
    {
        protected string name;

        /// <summary>
        /// метод, возвращающий признак «нуль-объекта»
        /// </summary>
        /// <returns></returns>
        public abstract bool IsNull();
        public abstract string GetName();
    }
}