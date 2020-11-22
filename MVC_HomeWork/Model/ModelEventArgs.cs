namespace MVC_HomeWork.Model
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ModelEventArgs
    {
        public string newValue;

        public ModelEventArgs(string newValue)
        {
            this.newValue = newValue;
        }
    }
}