using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_HogerLager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 7/11/2022
            // Project Hoger lager

            // Velden 
            Boolean _herhaling1 = true;
            int _keuze = 0, _basisGetal = -1, _nieuweGetal = -1 , _punten = 0;
            Random _rdm = new Random();


            // Programma

            //Stap 1: Intro
            Console.WriteLine("Welkom. \nDit is een hoger lager spel.");
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            //Herhaling 1:
            do
            {
                //Maak het scherm leeg
                Console.Clear();

                //Stap 2: Toon keuze menu(Speel spel, afsluiten)
                Console.WriteLine("Maak uw keuze uit volgend menu:");
                Console.WriteLine("\n   1) Speel het spel\n   2) Afsluiten");

                Console.Write("\n\nUw keuze: ");
                try
                {
                    // Keuze van de gebruiker opslaan.
                    _keuze = int.Parse( Console.ReadLine());

                    //Maak het scherm leeg
                    Console.Clear();

                    //Als 1: Speel spel
                    if (_keuze == 1)
                    {
                        //Stap 3: Maak + Toon willekeurig getal tussen 0 en 10
                        _basisGetal = _rdm.Next(11);

                        // Loop maximum 5 maal door dit gedeelte
                        for (int i = 0; i < 5; i++)
                        {
                           
                            //Scherm leegmaken 
                            Console.Clear();
  

                            Console.WriteLine($"het start getal: {_basisGetal.ToString()} ");

                            //Stap 4: Vraag hoger of lager
                            Console.WriteLine("\n\n Is het volgende getal:");
                            Console.WriteLine("   1) Hoger\n   2) Lager");
                            Console.Write("\nHet getal van uw keuze: ");
                            try
                            {

                            
                                // Keuze van de gebruiker opslaan.
                                _keuze = int.Parse(Console.ReadLine());


                                //Stap 5: maak nieuw willekeurig getal
                                _nieuweGetal = _rdm.Next(11);

                                //Stap 6: Beoordeel antwoord. 
                                if(_keuze == 1)
                                {
                                    // Als antwoord juist:
                                    if (_basisGetal < _nieuweGetal)
                                    {
                                        //•	punten + 1
                                        _punten++;
                                        //•	Check punten:
                                        // Indien = 5 :
                                        if (i==4)
                                        {
                                            //Scherm leegmaken 
                                            Console.Clear();

                                            //	Toon punten 
                                            Console.Write($"U behaalde {_punten.ToString()} punten");
                                            Console.WriteLine("\n\nU speelde het spel uit. Proficiat!");
                                            //	Toon proficiat
                                            //	Ga naar stap 2
                                        }

                                        //o Indien<5 : Ga naar stap 3
                                        _basisGetal = _nieuweGetal;

                                    }
                                    else
                                    {
                                        //Als antwoord fout:
                                        //Scherm leegmaken 
                                        Console.Clear();

                                        //•	Toon score
                                        Console.Write($"U behaalde {_punten.ToString()} punten");
                                        Console.WriteLine("\n\nDruk op enter om naar het hoofdmenu terug te keren");
                                        Console.ReadKey();
                                        //•	Ga naar stap 2
                                        //•	Stop spel
                                        break;
                                    }

                                }
                                else if (_keuze == 2)
                                {
                                    // Als antwoord juist:
                                    if (_basisGetal > _nieuweGetal)
                                    {
                                        //•	punten + 1
                                        _punten++;
                                        //•	Check punten:
                                        // Indien = 5 :
                                        if (i == 4)
                                        {
                                            //Scherm leegmaken 
                                            Console.Clear();

                                            //	Toon punten 
                                            Console.Write($"U behaalde {_punten.ToString()} punten");
                                            Console.WriteLine("\n\nU speelde het spel uit. Proficiat!");
                                            //	Toon proficiat
                                            //	Ga naar stap 2
                                        }

                                        //o Indien<5 : Ga naar stap 3
                                        _basisGetal = _nieuweGetal;

                                    }
                                    else
                                    {
                                        //Als antwoord fout:
                                        //Scherm leegmaken 
                                        Console.Clear();

                                        //•	Toon score
                                        Console.Write($"U behaalde {_punten.ToString()} punten");
                                        Console.WriteLine("\n\nDruk op enter om naar het hoofdmenu terug te keren");
                                        Console.ReadKey();
                                        //•	Ga naar stap 2
                                        //•	Stop spel
                                        break;
                                    }
                                }
                                else
                                {
                                    //Maak het scherm leeg
                                    Console.Clear();

                                    // foutmelding
                                    Console.WriteLine("U gaf geen juiste keuze in.");
                                    Console.WriteLine("\nDruk op enter om opnieuw te proberen");

                                    i--;

                                    Console.ReadKey();
                                }
                                
                            }
                            catch
                            {
                                //Maak het scherm leeg
                                Console.Clear();

                                // foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("\nDruk op enter om opnieuw te proberen.");
                                
                                i--;

                                Console.ReadKey();
                            }
                        }
                    }
                    else if (_keuze == 2)
                    {
                        // Melding
                        Console.WriteLine("U koos om af te sluiten.");
                        Console.WriteLine("\nDruk op enter om het programma te stoppen.");

                        Console.ReadKey();

                        // Stop lus
                        _herhaling1 = false;

                    }
                    else
                    {
                        //Maak het scherm leeg
                        Console.Clear();

                        // foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op enter om naar het hoofdmenu terug te keren");

                        Console.ReadKey();
                    }


                }
                catch
                {
                    //Maak het scherm leeg
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("\nDruk op enter om naar het hoofdmenu terug te keren");

                    Console.ReadKey();
                }

            }
            while (_herhaling1);

        }
    }
}
