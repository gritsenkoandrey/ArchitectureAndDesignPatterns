using MVC_HomeWork.Controller;


namespace MVC_HomeWork.View
{
    public interface IView
    {
        event ViewHandler<IView> AddList;
        void SetController(IController controller);
    }
}