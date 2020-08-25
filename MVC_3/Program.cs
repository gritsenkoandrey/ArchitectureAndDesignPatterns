using MVC_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_3
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

            ActiveMVCForm view = new ActiveMVCForm();
            IModel mdl = new IncrementModel();
            IController cnt = new IncrementController(view, mdl);

            Application.Run(view);
        }
    }
}
