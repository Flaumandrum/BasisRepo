using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beoordeling;

namespace _17_ProjSchoolreis
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

        //velden
        // Maak een lijst om alle objecten van de klasse "EenBeoordeling" te ontvangen
        public static List<EenBeoordeling> _beoordelingen = new List<EenBeoordeling>();

        //functies
        public static void Invoegen(string ontvVn, string ontvAn, int ontvScore)
        {
            // Maak een nieuw object aan van beoordeling met de juiste contstructor
            // Ik ontvang 3 parameters, dus moet de contstructor met 3 parameters gebruikern

            EenBeoordeling _nieuweBeoordeling = new EenBeoordeling(ontvVn, ontvAn, ontvScore);

            // Voeg dit opbject toe aan de lijst
            _beoordelingen.Add(_nieuweBeoordeling);
            
        }

        public static List<EenBeoordeling> StuurLijstDoor()
        {
            // Stuur de lijst met beoordelingen door
            return _beoordelingen;
        }

        public static void Aanpassen(string ontvVn, string ontvAn, int ontvScore, int ontvIndex)
        {
            // Maak een nieuw object aan van beoordeling met de juiste contstructor
            // Ik ontvang 3 parameters, dus moet de contstructor met 3 parameters gebruikern

            EenBeoordeling _nieuweBeoordeling = new EenBeoordeling(ontvVn, ontvAn, ontvScore);

            // Overschrijf het oude object in de lijst op de ontvangen index met het nieuwe object 
            _beoordelingen[ontvIndex] = _nieuweBeoordeling;
        }

        public static void Verwijderen(int ontvIndex)
        {
            // Verwijder het object op de ontvangen index
            _beoordelingen.RemoveAt(ontvIndex);
        }

        public static String ToonAlles()
        {
            // Maak een return variabele van het juiste datatype
            string antwoord = "";

            // Overloop de lijst 
            foreach(EenBeoordeling b in _beoordelingen)
            {
                //Voeg de gegevens toe aan de antwoord zonder de waarde te overschrijven 
                antwoord += b.AlleGegevens() + Environment.NewLine;
            }

            // Stuur de return value door
            return antwoord;
        }

        public static String ToonEenLeerling(int ontIndex)
        {
            // neem alle gegevens van de juiste leerlingen en stuur deze door

            return _beoordelingen[ontIndex].AlleGegevens();
        }


    }

}
