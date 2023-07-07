using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.ENTITIES;

namespace TF.WIN
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static frmMenuPrincipal FormMenu;
        public static frmLogin FormLogin;
        public static Nuevousuario FormNvoUsr;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(FormMenu = new frmMenuPrincipal());
            Application.Run(new frmLogin());

        }
    }
}
