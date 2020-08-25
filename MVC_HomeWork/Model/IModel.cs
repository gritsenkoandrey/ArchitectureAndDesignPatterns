namespace MVC_HomeWork.Model
{
    public interface IModel
    {
        void Attach(IModelObserver modelObserver);
        void AddList(string value);
    }
}