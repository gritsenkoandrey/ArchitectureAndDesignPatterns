using System.Linq;


namespace Null_Object
{
    public class AnimalFactory
    {
        public static readonly string[] names = { "Лев", "Слон", "Олень" };
        public static AbstractAnimal GetAnimal(string name)
        {
            if (names.Any(x => x == name))
            {
                return new RealAnimal(name);
            }
            else
            {
                return new NullAnimal();
            }
        }
    }
}