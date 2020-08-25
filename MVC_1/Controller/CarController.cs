using MVC_1.Model;
using MVC_1.View;


namespace MVC_1.Controller
{
    class CarController
    {
        private Car _model;
        private CarView _view;

        public CarController(Car model, CarView view)
        {
            _model = model;
            _view = view;
        }

        public string CarName
        {
            get { return _model.Name; }
            set { _model.Name = value; }
        }

        public string Speed
        {
            get { return _model.Speed; }
            set { _model.Speed = value; }
        }

        public void Updateview()
        {
            _view.PrintCarDetails(_model.Name, _model.Speed);
        }
    }
}