namespace Factory_Method
{
    //Интерфейс ICreator делегирует создание объектов
    //Bus и Truck реализующим его классам.
    public interface ICreator
    {
        ICar Create();
    }
}