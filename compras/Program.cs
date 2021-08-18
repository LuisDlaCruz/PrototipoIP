using Vista;
using System;
using System.Windows.Forms;
using Polideportivo.Vista;

namespace Polideportivo
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formCompras());
        }
    }
}