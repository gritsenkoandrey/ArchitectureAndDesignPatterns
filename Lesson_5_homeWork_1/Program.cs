using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5_homeWork_1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form
            {
                Width = 800,
                Height = 800
            };

            form.Show();

            Application.Run(form);
        }
    }
}