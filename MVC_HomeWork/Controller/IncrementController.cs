using MVC_HomeWork.Model;
using MVC_HomeWork.View;
using System;


namespace MVC_HomeWork.Controller
{
    public class IncrementController : IController
    {
        private IModel _model;
        private IView _view;

        public IncrementController(IModel model, IView view)
        {
            _model = model;
            _view = view;
            _view.SetController(this);
            _model.Attach((IModelObserver)_view);
            _view.AddList += new ViewHandler<IView>(this.ViewChanged);
        }

        public void ViewChanged(IView view, ViewEventArgs e)
        {
            _model.AddList(e.value);
        }
    }
}