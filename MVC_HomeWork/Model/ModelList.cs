using System.Collections.Generic;


namespace MVC_HomeWork.Model
{
    public class ModelList : IModel
    {
        public event ModelHandler<ModelList> Changed;

        private List<string> _list;

        public ModelList()
        {
            _list = new List<string>();
        }

        public void AddList(string value)
        {
            _list.Add(value);
            Changed.Invoke(this, new ModelEventArgs(value));
        }

        public void Attach(IModelObserver modelObserver)
        {
            Changed += new ModelHandler<ModelList>(modelObserver.ListChanged);
        }
    }
}