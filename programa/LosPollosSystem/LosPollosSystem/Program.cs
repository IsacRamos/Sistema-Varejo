using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosPollosSystem
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new login());

            //cria um form do login e abre ele
            login frmlogin = new login();

            frmlogin.ShowDialog();

            if (frmlogin.logado)
            {
                Application.Run(new AreaPrincipal());
            }
        }
    }
}
