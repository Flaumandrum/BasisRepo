using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07_WillekeurigeLeerling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Tom Adriaens 
             * 12/01/2023
             * Willekeurige leerling
             */

            // Velden 
            bool _herhalen1 = true, _ingevuld = false;
            byte _keuze = 0;
            Random _rdm = new Random();
            String[] _leeringen = new string[5];
            

            // Programma

            //Stap 1: Intro
            Console.WriteLine("Welkom. \nDit programma bepaalt een willekeurige leerling");
            Console.WriteLine("\nDruk op enter om verder te gaan");

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 2: Toon het keuzemenu +keuze opslaan
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n\n   1) namen ingeven\n   2) namen tonen\n   3) willekeurige naam tonen\n   4) afsluiten");
                Console.Write("\n\nUw keuze: ");
                try
                {
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    //Stap 3: 
                    //	1: Namen invoeren
                    if (_keuze == 1)
                    {

                       

                        //        Laat de gebruiker de 5 namen na elkaar invoeren

                    }

                    //    2: Alle namen op het scherm tonen
                    else if (_keuze == 2)
                    {
                        //        Controleer of de namen zijn ingegeven
                        //Toon alle namen op het scherm

                    }
                    //    3: Willekeurige leerling
                    else if (_keuze == 3)
                    {
                        //	1: Namen invoeren
                        //Controleer of de namen zijn ingegeven
                        //Maak een willekeurig index aan
                        //        Toon de overeenkomstige naam op het scherm.

                    }
                    else
                    {
                        // Scherm leegmaken 
                        Console.Clear();
                        //Foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                // foute ingave opvangen
                catch 
                {
                    // Scherm leegmaken 
                    Console.Clear();
                    //Foutmelding
                    Console.WriteLine("U gaf geen juist getal in.");
                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }


            } while (_herhalen1);


        }
    }
}
