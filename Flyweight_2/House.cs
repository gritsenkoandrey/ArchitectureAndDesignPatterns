namespace Flyweight_2
{
    public abstract class House
    {
        // количество этажей
        protected int stages;

        public abstract void Build(double longitude, double latitude);
    }
}