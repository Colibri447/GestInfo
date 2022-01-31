using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestInfo
{
    static class Program
    {
        //Por eso esperaba con la carita empapada a que llegaras con rosas (con mil rosas para mi),
        //Porque ya sabes que me encantan esas cosas que no importa si es muy tonto, soy así,
        //Y aun me parece mentira que se escape mi vida imaginando que vuelves a pasarte por aquí,
        //Donde los viernes cada tarde, como siempre la esperanza dice quieta, hoy quizás sí.


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
