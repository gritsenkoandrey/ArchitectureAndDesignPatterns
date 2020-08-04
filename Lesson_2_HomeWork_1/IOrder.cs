namespace Lesson_2_HomeWork_1
{
    public interface IOrder
    {
        Order Load(int orderId);
        void Save(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}