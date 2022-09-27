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
            const int wis1 = 100, wis2 = 50, wis3 = 20, wis4 = 10, wis5 = 5, wis6 = 2, wis7= 1;
            
            // Programma 
            Console.BackgroundColor= ConsoleColor.White;
            Console.ForegroundColor= ConsoleColor.Red;
            //Scherm leegmaken 
            Console.Clear();

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

                Console.WriteLine("\nDruk op enter om het wisselgeld te bekijken.");
                Console.ReadKey();

                //Scherm leegmaken 
                Console.Clear();

                // Stap 4) bereken wisselgeld
                _wisselgeld = _ontvangen - _tebetalen;
                Console.WriteLine($"U moet {_wisselgeld.ToString()} terug geven");

                // a)	deel door waarde wisselgeld
                //100
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis1));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis1;

                Console.WriteLine($"{_werkbedrag.ToString()} briefjes van 100 ");
                //50
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis2));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis2;

                Console.WriteLine($"{_werkbedrag.ToString()} briefjes van 50 ");

                // 20
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis3));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis3;

                Console.WriteLine($"{_werkbedrag.ToString()} briefjes van 20 ");

                // 10
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis4));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis4;

                Console.WriteLine($"{_werkbedrag.ToString()} briefjes van 10 ");

                // 5
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis5));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis5;

                Console.WriteLine($"{_werkbedrag.ToString()} briefjes van 5 ");


                //2
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis6));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis6;

                Console.WriteLine($"{_werkbedrag.ToString()} stukken van 2 ");

                // 1
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis7));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis7;

                Console.WriteLine($"{_werkbedrag.ToString()} stukken van 1 ");

                // 0.5
                _wisselgeld = _wisselgeld * 100;
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis2));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis2;

                Console.WriteLine($"{_werkbedrag.ToString()} stukken van van 50 cent ");

                // 0.2
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis3));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis3;

                Console.WriteLine($"{_werkbedrag.ToString()} stukken van van 20 cent ");
                


                // 0.1                
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis4));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis4;

                Console.WriteLine($"{_werkbedrag.ToString()} stukken van van 10 cent ");

                // 0.05                
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis5));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis5;

                Console.WriteLine($"{_werkbedrag.ToString()} stukken van van 5 cent ");

                // 0.02                
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis6));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis6;

                Console.WriteLine($"{_werkbedrag.ToString()} stukken van van 2 cent ");

              

                // 0.01                
                _werkbedrag = Convert.ToInt32(Math.Floor(_wisselgeld / wis7));
                // b)	mod deling door waarde wisselgeld
                _wisselgeld = _wisselgeld % wis7;

                Console.WriteLine($"{_werkbedrag.ToString()} stukken van van 1 cent ");

                Console.ReadKey();
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
