using System;


namespace MVC_2
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    public class ViewEventArgs : EventArgs
    {
        public int value;
        public ViewEventArgs(int v)
        {
            value = v;
        }
    }

    public interface IView
    {
        event ViewHandler<IView> Changed;
        void SetController(IController cont);
    }
}