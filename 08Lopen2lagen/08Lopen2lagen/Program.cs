using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Lopen2lagen
{
    internal class Program
    {
        // Tom Adriaens 
        // 03/02/2023
        // Project lopen 2 lagen

        // Velden
        static String[] _namen = new string[40];

        // GUI
        static void Main(string[] args)
        {
            
        }

        // Functies
        /// <summary>
        /// zoekt een lege plaats in de array
        /// </summary>
        /// <returns>index in arry als sbyte </returns>
        static sbyte CheckLegePlaats()
        {
            // Maak een antwoord variabele om te returnen 
            sbyte antwoord= -1;

            // Overloop de array met een lus
            for(int i = 0; i<_namen.Count(); i++)
            {
                // Kijk of de plaats leeg is 
                if (_namen[i] ==  null)
                {
                    // Sla de lege index op in mijn antwoord
                    antwoord = Convert.ToSByte( i);

                    // stop de loop
                    break;
                }
            }

            // return het antwoord
            return antwoord;
        }

        /// <summary>
        /// voegt een ontvangen naam toe, in de array op een ontvangen plaats
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvPlaats"></param>
        static void Toevoegen(String ontvNaam, int ontvPlaats)
        {
            // Sla de ontvangen naam op in de array op de ontvangen lege index
            _namen[ontvPlaats] = ontvNaam;

        }


        /// <summary>
        /// verwijdert de gegevens in de array op een bepaalde plaats via een ontvangen rugnummer
        /// </summary>
        /// <param name="ontvRugnummer"></param>
        /// <returns> of het verwijderen gelukt is (true) of niet (false)</returns>
        static Boolean ZoekEnVerwijder(byte ontvRugnummer)
        {
            // maak een antwoord om terug te sturen 
            Boolean antwoord = false;
           
            // Kijk of de plaats leeg is 
            if (_namen[(ontvRugnummer-1)] != null)
            {
                _namen[(ontvRugnummer-1)] = null;
                antwoord= true;
            }
           
            // Stuur antwoord terug
            return antwoord;
        }

        /// <summary>
        /// geeft alle ingeschreven lopers weer, met hun rugnummer
        /// </summary>
        /// <returns></returns>
        static String ToonAlleGegevens()
        {
            // maak een antwoord om terug te sturen 
            string antwoord = null;

            // Overloop de array met een lus
            for (int i = 0; i < _namen.Count(); i++)
            {
                // Kijk of de plaats leeg is 
                if (_namen[i] != null)
                {
                    antwoord += $"rugnummer : {(i + 1).ToString()}  naam: {_namen[i]} \n";
                }
            }

            // Stuur antwoord terug
            return antwoord;
        }

    }
}
