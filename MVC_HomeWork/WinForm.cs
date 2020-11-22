using MVC_HomeWork.Controller;
using MVC_HomeWork.Model;
using MVC_HomeWork.View;
using System;
using System.Windows.Forms;


namespace MVC_HomeWork
{
    public partial class WinForm : Form, IView, IModelObserver
    {
        private IController _controller;

        public event ViewHandler<IView> AddList;

        public WinForm()
        {
            InitializeComponent();
        }

        public void ListChanged(IModel model, ModelEventArgs e)
        {
            listBox1.Items.Add(e.newValue);
        }

        public void SetController(IController controller)
        {
            _controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddList.Invoke(this, new ViewEventArgs(textBox1.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введен символ.");
            }
        }
    }
}