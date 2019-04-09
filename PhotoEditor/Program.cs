using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    static class Program
    {
        public static MainForm MainForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.MainForm = new MainForm();
            Application.Run(Program.MainForm); // А было Application.Run(new MainForm());
        }
    }
}
