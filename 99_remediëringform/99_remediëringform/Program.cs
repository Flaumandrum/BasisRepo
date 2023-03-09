using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99_remediëringform
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
            Application.Run(new Remediering1());
        }

        //Functies

        static public String ZegHallo(string ontvNaam)
        {
            string antwoord  = $"Hallo {ontvNaam}";

            return antwoord;
        }
    }
}
