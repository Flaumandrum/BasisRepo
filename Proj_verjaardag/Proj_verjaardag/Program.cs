using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_verjaardag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // Project: Verjaardagen
            // 15/11/2022

            // Velden
            DateTime _vandaag = DateTime.Now, _verjaardag;
            TimeSpan _verschil;
            int _aantalDagen = 0;


            // Programma
            // Stap 1: Toon de datum van vandaag
            Console.WriteLine($"Beste gebruiker, vandaag zijn we {_vandaag.ToShortDateString()}");
            
            // Vraag de volgende verjaardag
            Console.WriteLine("\n Vul de datum in van uw volgende verjaardag");
            Console.Write("Datum volgende verjaardag dd/mm/yyy:");

            // Fout opvangen mocht er toch iets misgaan
            try
            {
                // Zet de ingave om naar een datum
                _verjaardag = DateTime.Parse(Console.ReadLine());

                // Verminder dat 2 datums van elkaar
                _verschil = _verjaardag - _vandaag;

                // Haal er het aantal dagen uit
                _aantalDagen = _verschil.Days;

                // Geef het antwoord
                Console.WriteLine($"Uw volgende verjaardag is binnen {_aantalDagen.ToString()}");

                Console.WriteLine("\n\nDruk op enter om af te sluiten. ");
                Console.ReadKey();
            }
            catch 
            {
                // Scherm leegmaken
                Console.Clear();

                // Foutmelding
                Console.WriteLine("De datum van uw volgende verjaardag werd niet goed ingegeven");
                Console.WriteLine("Druk op enter om af te sluiten. ");
                Console.ReadKey();
            }




        }
    }
}
