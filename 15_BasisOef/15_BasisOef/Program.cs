using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _16_Zin;

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
        static private List<Zin> _zinnen = new List<Zin>();

        // Functies
        static public void Opslaan(string ontvZin)
        {
            Zin nieuweZin = new Zin(ontvZin);
            _zinnen.Add(nieuweZin);
        }

        static public String Tonen ( )
        {
            string antwoord = "";

            foreach(Zin z in _zinnen)
            {
                antwoord += z.PropInhoud + Environment.NewLine;
            }

            return antwoord;
        }

        static public List<Zin> StuurLijstDoor()
        {
            return _zinnen;
        }

        static public void Verwijderen(int ontvIndex)
        {
            _zinnen.RemoveAt(ontvIndex);
        }

        static public void Aanpassen (int ontvIndex, string ontvZin)
        {
            Zin nieuweZin = new Zin(ontvZin);
            _zinnen[ontvIndex] = nieuweZin ;
            
        }

    }
}
