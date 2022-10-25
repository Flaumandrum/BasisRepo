using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WiskundigeFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tom Adriaens
             * 24/10/2022
             * Wiskundige functies
             */

            // Velden 
            byte _keuze = 0;
            Boolean _herhalen1 = true, _herhalen2 = true;
            double _getal1 = 0, _getal2 = 0, _resultaat = 0;

            // Programma
            // Stap 1) Intro
            Console.WriteLine("Welkom.\nIn dit programma kan u 6 verschillende oefeningen vinden.");
            Console.WriteLine("\nDruk op ENTER om verder te gaan");
            Console.ReadKey();

            do
            {

                // Scherm leegmaken
                Console.Clear();

                // Stap 2) Keuze menu
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Project kleinste getal\n   2) Project grootste getal\n   3) Project teken van een getal" +
                    "\n   4) Project absolute waarde\n   5) Project afronden \n   6) Project machten\n   7) Project Vierkantswortel" +
                    "\n   8) Project cilinder\n   9) Afsluiten ");
                Console.Write("\nUw keuze: ");
                try
                {
                    // Keuze opslaan
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();

                    //Als 1) kleinste getal
                    if(_keuze == 1)
                    {
                        do
                        {
                            try
                            {
                                // Vraag getal 1 en 2.
                                Console.WriteLine("Geef 2 getallen in. (Dit mogen komma getallen zijn)");
                                Console.Write("\nGetal 1: ");
                                _getal1 = double.Parse(Console.ReadLine().Replace(".", ","));
                                Console.Write("\nGetal 2: ");
                                _getal2 = double.Parse(Console.ReadLine().Replace(".", ","));

                                // Scherm leegmaken
                                Console.Clear();

                                Console.WriteLine("Bedankt voor uw ingave.\nDruk op enter om het kleinste getal weer te geven.");
                                Console.ReadKey();

                                _resultaat = Math.Min(_getal1, _getal2);

                                Console.WriteLine($"Het kleinste getal dat u ingaf is: {_resultaat.ToString()}");
                                Console.WriteLine("\nWilt u terug keren naar het hoofdmenu of afsluiten: \n 1) Hoofdmenu\n 2) Afsluiten");
                                Console.Write("\nUw keuze: ");
                               
                                // Keuze opslaan
                                _keuze = Byte.Parse(Console.ReadLine());
                                _herhalen2 = false;
                                if (_keuze == 1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om naar het hoofdmenu terug te keren");
                                    Console.ReadKey();
                                }
                                else if (_keuze == 2)
                                {
                                    _herhalen1 = false;
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om af te sluiten");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                    Console.ReadKey();
                                }
                                
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om de 2 getallen in te geven.");
                                Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                Console.ReadKey();
                            }
                        }
                        while (_herhalen2);
                    }
                    //Als 2) grootste getal
                    else if (_keuze == 2)
                    {
                        do
                        {
                            try
                            {

                                // Vraag getal 1 en 2.
                                Console.WriteLine("Geef 2 getallen in. (Dit mogen komma getallen zijn)");
                                Console.Write("\nGetal 1: ");
                                _getal1 = double.Parse(Console.ReadLine().Replace(".", ","));
                                Console.Write("\nGetal 2: ");
                                _getal2 = double.Parse(Console.ReadLine().Replace(".", ","));

                                // Scherm leegmaken
                                Console.Clear();

                                Console.WriteLine("Bedankt voor uw ingave.\nDruk op enter om het grootste getal weer te geven.");
                                Console.ReadKey();

                                _resultaat = Math.Max(_getal1, _getal2);

                                Console.WriteLine($"Het grootste getal dat u ingaf is: {_resultaat.ToString()}");
                                Console.WriteLine("\nWilt u terug keren naar het hoofdmenu of afsluiten: \n 1) Hoofdmenu\n 2) Afsluiten");
                                Console.Write("\nUw keuze: ");

                                // Keuze opslaan
                                _keuze = Byte.Parse(Console.ReadLine());
                                _herhalen2 = false;
                                if (_keuze == 1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om naar het hoofdmenu terug te keren");
                                    Console.ReadKey();
                                }
                                else if (_keuze == 2)
                                {
                                    _herhalen1 = false;
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om af te sluiten");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om de 2 getallen in te geven.");
                                Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                Console.ReadKey();
                            }
                        }
                        while (_herhalen2);
                    }
                    //Als 3) teken van getal
                    else if (_keuze == 3)
                    {
                        do
                        {
                            try
                            {
                                // Vraag getal 1 .
                                Console.WriteLine("Geef een getal in. (Dit mag een komma getal zijn)");
                                Console.Write("\nGetal: ");
                                _getal1 = double.Parse(Console.ReadLine().Replace(".", ","));
                                

                                // Scherm leegmaken
                                Console.Clear();

                                Console.WriteLine("Bedankt voor uw ingave.\nDruk op enter om het teken van het getal te weten.");
                                Console.ReadKey();

                                _resultaat = Math.Sign(_getal1);

                                if( _resultaat == 1)
                                {
                                    Console.WriteLine($"Het getal is positief.");
                                    
                                }
                                else if (_resultaat == 0)
                                {
                                    Console.WriteLine($"U gaf het cijfer 0 in.");
                                }
                                else
                                {
                                    Console.WriteLine($"Het getal is negatief.");
                                }

                                Console.WriteLine("\n\nWilt u terug keren naar het hoofdmenu of afsluiten: \n 1) Hoofdmenu\n 2) Afsluiten");
                                Console.Write("\nUw keuze: ");

                                // Keuze opslaan
                                _keuze = Byte.Parse(Console.ReadLine());
                                _herhalen2 = false;
                                if (_keuze == 1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om naar het hoofdmenu terug te keren");
                                    Console.ReadKey();
                                }
                                else if (_keuze == 2)
                                {
                                    _herhalen1 = false;
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om af te sluiten");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om de 2 getallen in te geven.");
                                Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                Console.ReadKey();
                            }
                        }
                        while (_herhalen2);
                    }
                    //Als 4) absolute waarde van getal
                    else if (_keuze == 4)
                    {
                        do
                        {
                            try
                            {
                                // Vraag getal 1 .
                                Console.WriteLine("Geef een getal in. (Dit mag een komma getal zijn)");
                                Console.Write("\nGetal: ");
                                _getal1 = double.Parse(Console.ReadLine().Replace(".", ","));


                                // Scherm leegmaken
                                Console.Clear();

                                Console.WriteLine("Bedankt voor uw ingave.\nDruk op enter om het de absolute waarde van uw getal te berekenen.");
                                Console.ReadKey();

                                _resultaat = Math.Abs(_getal1);

                                Console.WriteLine($"De abolute waarde van uw getal is: {_resultaat.ToString()}");
                                Console.WriteLine("\nWilt u terug keren naar het hoofdmenu of afsluiten: \n 1) Hoofdmenu\n 2) Afsluiten");
                                Console.Write("\nUw keuze: ");

                                // Keuze opslaan
                                _keuze = Byte.Parse(Console.ReadLine());
                                _herhalen2 = false;
                                if (_keuze == 1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om naar het hoofdmenu terug te keren");
                                    Console.ReadKey();
                                }
                                else if (_keuze == 2)
                                {
                                    _herhalen1 = false;
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om af te sluiten");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om de 2 getallen in te geven.");
                                Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                Console.ReadKey();
                            }
                        }
                        while (_herhalen2);
                    }
                    //Als 5) afronden
                    else if (_keuze == 5)
                    {
                        do
                        {
                            try
                            {
                                // Vraag getal 1 .
                                Console.WriteLine("Geef een getal in met 3 cijfers na de komma.");
                                Console.Write("\nGetal: ");
                                string ingave = Console.ReadLine().Replace(".", ",");
                                if (ingave.IndexOf(",") == -1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("U gaf geen kommagetal in.");
                                }
                                else
                                {
                                    _getal1 = double.Parse(ingave);


                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Bedankt voor uw ingave.\nDruk op enter om het de het getal af te ronden tot 2 cijfers na de komma.");
                                    Console.ReadKey();

                                    _resultaat = Math.Round(_getal1,2);

                                    Console.WriteLine($"Uw afgerond getal is: {_resultaat.ToString()}");

                                }

                                Console.WriteLine("\nWilt u terug keren naar het hoofdmenu of afsluiten: \n 1) Hoofdmenu\n 2) Afsluiten");
                                Console.Write("\nUw keuze: ");

                                // Keuze opslaan
                                _keuze = Byte.Parse(Console.ReadLine());
                                _herhalen2 = false;
                                if (_keuze == 1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om naar het hoofdmenu terug te keren");
                                    Console.ReadKey();
                                }
                                else if (_keuze == 2)
                                {
                                    _herhalen1 = false;
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om af te sluiten");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om de 2 getallen in te geven.");
                                Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                Console.ReadKey();
                            }
                        }
                        while (_herhalen2);
                    }
                    //Als 6) Machten
                    else if (_keuze == 6)
                    {
                        do
                        {
                            try
                            {

                                // Vraag getal 1 en 2.
                                Console.WriteLine("Geef het grond getal in. (getal dat u tot een macht wil verheffen)");
                                Console.Write("\nGetal 1: ");
                                _getal1 = double.Parse(Console.ReadLine().Replace(".", ","));
                                Console.WriteLine("Geef de exponent in. (het getal van de machtsverheffing)");
                                Console.Write("\nGetal 2: ");
                                _getal2 = double.Parse(Console.ReadLine().Replace(".", ","));

                                // Scherm leegmaken
                                Console.Clear();

                                Console.WriteLine("Bedankt voor uw ingave.\nDruk op enter om het de absolute waarde van uw getal te berekenen.");
                                Console.ReadKey();

                                _resultaat = Math.Pow(_getal1, _getal2);

                                Console.WriteLine($"Uw getal {_getal1.ToString()} tot de macht {_getal2.ToString()}: {_resultaat.ToString()}");
                                Console.WriteLine("\nWilt u terug keren naar het hoofdmenu of afsluiten: \n 1) Hoofdmenu\n 2) Afsluiten");
                                Console.Write("\nUw keuze: ");

                                // Keuze opslaan
                                _keuze = Byte.Parse(Console.ReadLine());
                                _herhalen2 = false;
                                if (_keuze == 1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om naar het hoofdmenu terug te keren");
                                    Console.ReadKey();
                                }
                                else if (_keuze == 2)
                                {
                                    _herhalen1 = false;
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om af te sluiten");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om de 2 getallen in te geven.");
                                Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                Console.ReadKey();
                            }
                        }
                        while (_herhalen2);
                    }
                    //Als 7) Vierkantswortel
                    else if (_keuze == 7)
                    {
                        do
                        {
                            try
                            {
                                // Vraag getal 1 .
                                Console.WriteLine("Geef een getal in. (Dit mag een komma getal zijn)");
                                Console.Write("\nGetal: ");
                                _getal1 = double.Parse(Console.ReadLine().Replace(".", ","));


                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Bedankt voor uw ingave.\nDruk op enter om de vierkantswortel van dit getal te nemen.");
                                    Console.ReadKey();

                                    _resultaat = Math.Round(Math.Sqrt(Math.Abs(_getal1)), 2);

                                    Console.WriteLine($"Uw afgerond getal is: {_resultaat.ToString()}");

                                

                                Console.WriteLine("\nWilt u terug keren naar het hoofdmenu of afsluiten: \n 1) Hoofdmenu\n 2) Afsluiten");
                                Console.Write("\nUw keuze: ");

                                // Keuze opslaan
                                _keuze = Byte.Parse(Console.ReadLine());
                                _herhalen2 = false;
                                if (_keuze == 1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om naar het hoofdmenu terug te keren");
                                    Console.ReadKey();
                                }
                                else if (_keuze == 2)
                                {
                                    _herhalen1 = false;
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om af te sluiten");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om de 2 getallen in te geven.");
                                Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                Console.ReadKey();
                            }
                        }
                        while (_herhalen2);
                    }
                    //Als 8) Project cilinder
                    else if (_keuze == 8)
                    {
                        do
                        {
                            try
                            {
                                // Vraag getal 1 .
                                Console.WriteLine("Geef de straal in van een cilinder. (in cm)");
                                Console.Write("\nstraal: ");
                                _getal1 = double.Parse(Console.ReadLine().Replace(".", ","));
                                Console.WriteLine("Geef de hoogte in. (van de cilinder)");
                                Console.Write("\nHoogte: ");
                                _getal2 = double.Parse(Console.ReadLine().Replace(".", ","));

                                // Scherm leegmaken
                                Console.Clear();

                                Console.WriteLine("Bedankt voor uw ingave.\nDruk op enter om de inhoud van de cilinder te berekenen.");
                                Console.ReadKey();

                                _resultaat = Math.Round(Math.PI*Math.Pow(_getal1,2) * _getal2, 2);

                                Console.WriteLine($"Uw inhoud is: {_resultaat.ToString()}");



                                Console.WriteLine("\nWilt u terug keren naar het hoofdmenu of afsluiten: \n 1) Hoofdmenu\n 2) Afsluiten");
                                Console.Write("\nUw keuze: ");

                                // Keuze opslaan
                                _keuze = Byte.Parse(Console.ReadLine());
                                _herhalen2 = false;
                                if (_keuze == 1)
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om naar het hoofdmenu terug te keren");
                                    Console.ReadKey();
                                }
                                else if (_keuze == 2)
                                {
                                    _herhalen1 = false;
                                    // Scherm leegmaken
                                    Console.Clear();

                                    Console.WriteLine("Druk op enter om af te sluiten");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om de 2 getallen in te geven.");
                                Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                                Console.ReadKey();
                            }
                        }
                        while (_herhalen2);
                    }
                    //Als 9) Afsluiten
                    else if (_keuze == 9)
                    {

                        // Foutmelding
                        Console.WriteLine("U voor afsluiten.\nTot de volgende keer.");
                        Console.WriteLine("\n\nDruk op ENTER af te sluiten");
                        Console.ReadKey();

                        _herhalen1 = false;
                    }
                    else
                    {
                        // Scherm leegmaken
                        Console.Clear();

                        // Foutmelding
                        Console.WriteLine("U gaf een verkeerde keuze in.\nProbeer opnieuw.");
                        Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm leegmaken
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.\nProbeer opnieuw om het getal van uw keuze in te geven.");
                    Console.WriteLine("\n\nDruk op ENTER om verder te gaan");
                    Console.ReadKey();
                }
            } while (_herhalen1);
        }

    }
}
