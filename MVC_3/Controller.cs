namespace MVC_2
{
    public interface IController
    {
        void IncrementValue();
    }
    public class IncrementController : IController
    {
        private IView _view;
        private IModel _model;

        public IncrementController(IView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.SetController(this);
            _model.Attach((IModelObserver)_view);
            _view.Changed += new ViewHandler<IView>(this.ViewChanged);
        }

        public void ViewChanged(IView v, ViewEventArgs e)
        {
            _model.SetValue(e.value);
        }

        public void IncrementValue()
        {
            _model.Increment();
        }
    }
}