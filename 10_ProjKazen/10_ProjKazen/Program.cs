using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_ProjKazen
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
            Application.Run(new FrmIntro());
        }

        // Tom Adriaens
        // 02/03/2023
        // Project Kazen

        // Velden 
        static private String[] _kaasNaam = new string[0];
        static private String[] _origine = new string[0];
        static private String[] _soortMelk = new string[0];

        //Functies
        static public bool CheckArray()
        {
            bool antwoord = false;

            if (_kaasNaam.Count() >0)
            {
                antwoord = true;
            }

            return antwoord;
        }

        /// <summary>
        /// Past de grootte van de array aan 
        /// Opgelet, alle gegevens verdwijnen!
        /// </summary>
        /// <param name="ontvGrootte"></param>
        static public void GrootteArrayAanpassen(int ontvGrootte)
        {
            _kaasNaam = new string[ ontvGrootte];
            _origine = new string[ontvGrootte];
            _soortMelk = new string[ontvGrootte];
        }

        static public int CheckLegePlaats()
        {
            int antwoord = -1;

            return antwoord;
        }

        static public void Opslaan(string ontvNaam, string ontvOrigine, string ontvMelk, int ontvPlaats)
        {

        }

        static public Array StuurKazenDoor()
        {
            Array antwoord = _kaasNaam;

            return antwoord;
        }

        static public String NaamKaas(int ontvIndex)
        {
            string antwoord = "";

            return antwoord;
        }

        static public String OrigineKaas(int ontvIndex)
        {
            string antwoord = "";

            return antwoord;
        }

        static public String SoortMelk(int ontvIndex)
        {
            string antwoord = "";

            return antwoord;
        }

        static public String ZoekOrigine(string ontvOrigine)
        {
            string antwoord = "";

            return antwoord;
        }

        static public String ZoekMelk(string ontvMelk)
        {
            string antwoord = "";

            return antwoord;
        }

        static public String Zoeken(string ontvGegeven, int ontvZoekwaarde)
        {
            string antwoord = "";

            return antwoord; 
        }

    }
}
