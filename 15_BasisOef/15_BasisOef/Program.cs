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
        static private List<String> _zinnen = new List<string>();

        // Functies
        static public void Opslaan(string ontvZin)
        { 
            _zinnen.Add(ontvZin);
        }

        static public String Tonen ( )
        {
            string antwoord = "";

            foreach(string s in _zinnen)
            {
                antwoord += s + Environment.NewLine;
            }

            return antwoord;
        }

        static public List<String> StuurLijstDoor()
        {
            return _zinnen;
        }

        static public void Verwijderen(int ontvIndex)
        {
            _zinnen.RemoveAt(ontvIndex);
        }

    }
}
