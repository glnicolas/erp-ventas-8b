using System;
using System.Collections.Generic;
using System.Linq;
using ERP_ventas.Formularios;
using System.Windows.Forms;

namespace ERP_ventas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Login());
            SubMClientes loginForm = new SubMClientes();
            loginForm.FormClosed += MainForm_Closed;
            loginForm.Show();
            Application.Run();
        }

        /*
       * Método encargado de cerrar las interfaces mostradas
       */
        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }

    }
}
