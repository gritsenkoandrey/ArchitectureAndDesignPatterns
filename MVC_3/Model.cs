using System;


namespace MVC_2
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ModelEventArgs : EventArgs
    {
        public int newval;
        public ModelEventArgs(int v)
        {
            newval = v;
        }
    }

    public interface IModelObserver
    {
        void ValueIncremented(IModel model, ModelEventArgs e);
    }

    public interface IModel
    {
        void Attach(IModelObserver imo);
        void Increment();
        void SetValue(int v);
    }

    public class IncrementModel : IModel
    {
        public event ModelHandler<IncrementModel> Changed;

        private int value;

        public IncrementModel()
        {
            value = 0;
        }

        public void SetValue(int v)
        {
            value = v;
        }

        public void Attach(IModelObserver imo)
        {
            Changed += new ModelHandler<IncrementModel>(imo.ValueIncremented);
        }

        public void Increment()
        {
            value++;
            Changed.Invoke(this, new ModelEventArgs(value));
        }
    }
}