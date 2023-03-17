using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EersteKlassePersoon
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
            Application.Run(new FrmStart());
        }

        // Velden 
        static Persoon _deelnemer = new Persoon();


        // Functies
        static public string GetVolledigeNaam ()
        {
            return _deelnemer.VolledigeNaam();
        }

        static public string GetAlleGegevens()
        {
            return $"{_deelnemer.VolledigeNaam()} {_deelnemer.GetLeeftijd().ToString()}";
        }

        static public void Opslaan(string vn, string an, DateTime gd)
        {
            _deelnemer = new Persoon(vn, an, gd);
        }
    }
}
