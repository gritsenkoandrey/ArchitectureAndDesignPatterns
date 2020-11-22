using System;


namespace MVC_HomeWork.View
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    public class ViewEventArgs : EventArgs
    {
        public string value;

        public ViewEventArgs(string value)
        {
            this.value = value;
        }
    }
}