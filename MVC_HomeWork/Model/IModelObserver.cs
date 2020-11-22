namespace MVC_HomeWork.Model
{
    public interface IModelObserver
    {
        void ListChanged(IModel model, ModelEventArgs e);
    }
}