using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ProJ_Wisselgeld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 23/09/2022
            // Project Wisselgeld 

            // Velden
            Decimal _tebetalen = 0, _ontvangen = 0, _wisselgeld;
            int _werkbedrag=0, _rest=0 ;

            // Programma 

            // Stap 1) intro
            Console.WriteLine("Welkom\nDit programma berekend de teruggave van geld");
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            //Scherm leegmaken 
            Console.Clear();
            try
            {

                // Stap 2) vraag totaalprijs +opslaan
                Console.Write("Geef het te betalen bedrag in: ");
                _tebetalen = decimal.Parse(Console.ReadLine());

                // Stap 3) vraag ontvangen geldbedrag + opslaan
                Console.Write("Geef het ontvangen bedrag in: ");
                _ontvangen = decimal.Parse(Console.ReadLine());
                // Stap 4) bereken wisselgeld
                _wisselgeld = _ontvangen - _tebetalen;

                // a)	deel door waarde wisselgeld
                // b)	mod deling door waarde wisselgeld
                // c)	verminder van het totaal wisselgeld
                // Stap 5) toon het resultaat


            }
            catch
            {
                //Scherm leegmaken 
                Console.Clear();

                Console.WriteLine("Er ging iets mis.");
                Console.WriteLine("\nDruk op enter om verder af te sluiten.");
                Console.ReadKey();

            }

        }
    }
}
