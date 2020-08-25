using MVC_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_3
{
    public partial class ActiveMVCForm : Form, IView, IModelObserver
    {
        private IController _controller;

        public event ViewHandler<IView> Changed;

        public void SetController(IController controller)
        {
            _controller = controller;
        }

        public ActiveMVCForm()
        {
            InitializeComponent();
        }

        public void ValueIncremented(IModel m, ModelEventArgs e)
        {
            textBoxValue.Text = "" + e.newval;
        }

        private void ButtonIncrementValue_Click(object sender, EventArgs e)
        {
            _controller.IncrementValue();
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Changed.Invoke(this, new ViewEventArgs(int.Parse(textBoxValue.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Введите целое число.");
            }
        }
    }
}