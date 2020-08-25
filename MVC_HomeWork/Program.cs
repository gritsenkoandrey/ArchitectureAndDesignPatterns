using MVC_HomeWork.Controller;
using MVC_HomeWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_HomeWork
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WinForm form = new WinForm();
            IModel model = new ModelList();
            IController controller = new IncrementController(model, form);

            Application.Run(form);
        }
    }
}
