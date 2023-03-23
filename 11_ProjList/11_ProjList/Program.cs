using KlassePersoon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_ProjList
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
            Application.Run(new StartForm());
        }

        //Tom Adriaens
        // 17/03/2023
        // Project list 

        // velden 
        static List<Persoon> _leerlingen = new List<Persoon>();

        static void Opslaan(string vn, string an, DateTime gd)
        {
            Persoon nieuwePersoon = new Persoon(vn, an, gd);

            _leerlingen.Add(nieuwePersoon);
        }

        static List<Persoon> StuurLeerlingenDoor ()
        {
            return _leerlingen;
        }

    }
}
