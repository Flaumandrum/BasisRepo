using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_BasisOef
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }

        // Velden
        static private String _zin;

        // Functies
        static public void Opslaan(string ontvZin)
        { 
            _zin = ontvZin;
        }

        static public String Tonen ( )
        {

            return _zin;
        }
    }
}
