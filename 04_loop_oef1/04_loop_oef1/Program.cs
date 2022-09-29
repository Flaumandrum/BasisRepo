using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _04_loop_oef1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tom Adriaens
             * 29/09/2022
             * Project loop oef 1
             */

            // Velden 
            String _vn = "", _an = "", _mail = "";
            UInt32 _getal1, _getal2, _uitkomst;
            Byte _keuze = 0;
            Boolean _herhalen = true;

            // Programma

            // Stap 1) Toon intro
            Console.WriteLine("Welkom!\nDruk op enter om verder te gaan");
            Console.ReadKey();
            do
            {
                // Scherm leemaken 
                Console.Clear();

            

                // Stap 2) Toon keuze menu(1.Maar mailadres, 2.Tel 2 getallen op, 3.Afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Maak je mailadres aan\n   2) Tel 2 positieve natuurlijke getallen op\n   3) Afsluiten");

                try
                {

                    // Stap 3) Vraag keuze +opslaan
                    Console.Write("\n\nGeef het getal van uw keuze in: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leemaken 
                    Console.Clear();

                    // Stap 4) afhankelijk van keuze
                    //    Als 1: mailadres
                    if (_keuze == 1)
                    {
                        //          1)	Vraag voornaam +opslaan
                        Console.Write("Geef uw voornaam ");
                        _vn = Console.ReadLine();

                        //          2)	Vraag achternaam +opslaan
                        Console.WriteLine("\nGeef uw achternaam: ");
                        _an = Console.ReadLine();

                        //          3)	Maak mailadres in de vorm “voornaam”.”achternaam”@romerocollege.be + tonen
                        _mail = $"{_vn}.{_an}@romerocollege.be";

                        Console.WriteLine($"Uw mailadres is: {_mail}");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                    //    Als 2: 2 positieve natuurlijke getallen optellen
                    else if (_keuze == 2)
                    {
                        do
                        {
                            try
                            {
                                //          1)	Vraag getal1 +opslaan
                                Console.WriteLine("\nGeef uw eerste getal: ");
                                _getal1 = UInt32.Parse(Console.ReadLine());

                                //          2)	Vraag getal 2 + opslaan
                                Console.WriteLine("\nGeef uw tweede getal: ");
                                _getal2 = UInt32.Parse(Console.ReadLine());

                                // Scherm leemaken 
                                Console.Clear();

                                //          3)	Tel beide getallen op +tonen
                                _uitkomst = _getal1 + _getal2;
                                Console.WriteLine($"Uw uitkomst is: {_uitkomst.ToString()} ");
                                Console.WriteLine("\n Druk op enter om naar het hoofdmenu terug te keren.");
                                Console.ReadKey();
                            }
                            catch
                            {
                                // Scherm leemaken 
                                Console.Clear();
                                Console.WriteLine("U gaf geen juiste getal in!\nDruk Y om nog eens te proberen of N om naar het menu terug te keren.");

                                string antwoord = Console.ReadLine();
                                if (antwoord == "n" || antwoord == "N")
                                {
                                    _herhalen = false; 
                                }

                            }

                        }
                        while (_herhalen);



                    }

                    //    Als 3: Afsluiten
                    else if (_keuze == 3)
                    {
                        //1)	Sluit af
                        // Scherm leemaken 
                        Console.Clear();
                        Console.WriteLine("Bedankt om deel te nemen!\nDruk op enter om het programma af te sluiten.");
                        Console.ReadKey();
                    }

                    else
                    {
                        // Scherm leemaken 
                        Console.Clear();
                        Console.WriteLine("U gaf geen juiste keuze in!\nDruk op enter om terug te keren naar het menu");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm leemaken 
                    Console.Clear();
                    Console.WriteLine("U gaf geen juiste keuze in!\nDruk op enter om terug te keren naar het menu");
                    Console.ReadKey();

                }
                //Stap 5: indien niet keuze 3, keer terug naar stap 2
            }
            while (_keuze != 3);
        }
    }
}
