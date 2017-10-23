using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    static class Program
    {

        public static InputName inputName;
        public static MainWindow mainWindow;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            inputName = new InputName();
            Application.Run(inputName);
            if (inputName.Status) {
                mainWindow = new MainWindow();
                Application.Run(mainWindow);
            }
        }
    }
}
