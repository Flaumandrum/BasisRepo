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
        /// <summary>
        /// gaat na of de array een grootte heeft
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Kijkt of er nog een lege plaats in de array is
        /// </summary>
        /// <returns></returns>
        static public int CheckLegePlaats()
        {
            int antwoord = -1;

            for(int i = 0;  i < _kaasNaam.Length; i++)
            {
                if (_kaasNaam[i] == null)
                {
                    antwoord = i;
                    break;
                }
            }

            return antwoord;
        }

        /// <summary>
        /// Slaat de gegevens op in de arrays
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvOrigine"></param>
        /// <param name="ontvMelk"></param>
        /// <param name="ontvPlaats"></param>
        static public void Opslaan(string ontvNaam, string ontvOrigine, string ontvMelk, int ontvPlaats)
        {
            _kaasNaam[ontvPlaats] = ontvNaam;
            _origine[ontvPlaats] = ontvOrigine;
            _soortMelk[ontvPlaats] = ontvMelk;
        }

        /// <summary>
        /// stuurt een array door met alle kaasnamen 
        /// </summary>
        /// <returns></returns>
        static public Array StuurKazenDoor()
        {
            Array antwoord = _kaasNaam;

            return antwoord;
        }

        /// <summary>
        /// Stuurt de naam van een specifieke kaas door
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public String NaamKaas(int ontvIndex)
        {
            string antwoord = _kaasNaam[ontvIndex];

            return antwoord;
        }

        /// <summary>
        /// Stuurt de origine van een specifieke kaas door
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public String OrigineKaas(int ontvIndex)
        {
            string antwoord = _origine[ontvIndex];

            return antwoord;
        }

        /// <summary>
        ///  Stuurt de melk van een specifieke kaas door
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public String SoortMelk(int ontvIndex)
        {
            string antwoord = _soortMelk[ontvIndex];

            return antwoord;
        }

        /// <summary>
        /// Zoekt alle kazen van een bepaalde origine
        /// </summary>
        /// <param name="ontvOrigine"></param>
        /// <returns></returns>
        static public String ZoekOrigine(string ontvOrigine)
        {
            string antwoord = "";

            for(int i = 0;i<_soortMelk.Count(); i++)
            {
               if( _origine[i] == ontvOrigine)
                {
                    antwoord += $"naam: {_kaasNaam[i]}      soort melk: {_soortMelk[i]}" + Environment.NewLine;
                }
            }
            if (antwoord == "")
            {
                antwoord = "Niets gevonden";
            }
            return antwoord;
        }

        /// <summary>
        /// Zoekt alle kazen gemaakt van een bepaalde soort melk
        /// </summary>
        /// <param name="ontvOrigine"></param>
        /// <returns></returns>
        static public String ZoekMelk(string ontvMelk)
        {
            string antwoord = "";

            for (int i = 0; i < _soortMelk.Count(); i++)
            {
                if (_soortMelk[i] == ontvMelk)
                {
                    antwoord += $"naam: {_kaasNaam[i]}      origine: {_origine[i]}" + Environment.NewLine;
                }
            }
            if (antwoord == "")
            {
                antwoord = "Niets gevonden";
            }
            return antwoord;
        }

        static public String Zoeken(string ontvGegeven, int ontvZoekwaarde)
        {
            string antwoord = "";

            if(ontvZoekwaarde == 1) 
            { 
                for (int i = 0; i < _soortMelk.Count(); i++)
                {
                    if (_origine[i] == ontvGegeven)
                    {
                        antwoord += $"naam: {_kaasNaam[i]} soort melk: {_soortMelk[i]}" + Environment.NewLine;
                    }


                }
            }
            else if (ontvZoekwaarde == 2)
            {
                for (int i = 0; i < _soortMelk.Count(); i++)
                {
                    if (_soortMelk[i] == ontvGegeven)
                    {
                        antwoord += $"naam: {_kaasNaam[i]} origine: {_origine[i]}" + Environment.NewLine;
                    }
                }
            }
            
            if (antwoord =="")
            {
                antwoord = "Niets gevonden";
            }
            return antwoord; 
        }

    }
}
