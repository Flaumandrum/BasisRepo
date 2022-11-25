using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Frigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 24/11/2022
            // Project Frigo

            // Velden
            String[] _frigo = new String[20];
            byte _keuze = 0;
            bool _herhalen = true;
            int _plaats = -1;
            String _naamProduct = "";

            // Programma

            //  Analyse: 1 laag
            //  Stap 1: Intro
            Console.WriteLine("Welkom in jouw frigo!"); 
            
            do
            {
                // Scherm leegmaken
                Console.Clear();


                //  Stap 2: Toon menu(toevoegen, zoeken, verwijderen, tonen, Afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Item toevoegen\n   2) Item zoeken\n   3) Item verwijderen\n   4) Frigo tonen\n   5) Afsluiten");
                Console.WriteLine("\n\nUw keuze: ");

                try
                {
                    // Keuze opslaan 
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();
                    
                    // Reset variabele !!!!!
                    _plaats = -1;

                    //  Stap3:
                    //      3.1.Als Keuze 1: toevoegen
                    if (_keuze == 1)
                    {

                        //        3.1.1   Zoek lege plaats
                        //                Overloop array
                        for(int i = 0; i < _frigo.Count(); i++)
                        {
                            //                Check of plaats leeg is
                            if (_frigo[i] == null )
                            {
                                _plaats = i;
                                break;

                            }

                        }

                        //        3.1.2   vraag naam product + opslaan
                        if (_plaats !=-1)
                        {
                            Console.Write("Welk product wilt u toevoegen: ");
                            _frigo[_plaats] = Console.ReadLine().ToLower().Trim();

                            Console.WriteLine("Dit gegeven werd toegevoegd.\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }
                        else
                        {
                            // Foutmelding
                            Console.WriteLine("Er is geen plaats meer in de frigo.\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }
                        
                    }

                    //      3.2.Als Keuze 2: Zoeken
                    else if (_keuze == 2)
                    {
                        //        3.2.1   vraag naam product + opslaan
                        Console.Write("Welk product wilt u zoeken: ");
                        _naamProduct = Console.ReadLine().ToLower().Trim();

                        //        3.2.2   Zoek de naam in array
                        
                        // Overloop array
                        for (int i = 0; i < _frigo.Count();i++)
                        {
                            // Check of de naam in de array staat
                            if(_frigo[i] == _naamProduct)
                            {
                                _plaats = i;
                            }
             
                        }

                        // Bevestig of geef foutmelding.
                        if (_plaats != -1)
                        {
                            Console.WriteLine("De frigo bevat dit product.\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }
                        else
                        {
                            // Foutmelding
                            Console.WriteLine("Het product werd niet gevonden.\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }

                    }

                    //      3.3.Als Keuze 3: verwijderen
                    else if (_keuze == 3)
                    {
                        //        3.3.1   vraag naam product + opslaan
                        Console.Write("Welk product wilt u zoeken: ");
                        _naamProduct = Console.ReadLine().ToLower().Trim();

                        //        3.3.2   Zoek de naam in array
                        //                Overloop array
                        for (int i = 0; i < _frigo.Count(); i++)
                        {
                            // Check of de naam in de array staat
                            if (_frigo[i] == _naamProduct)
                            {
                                _plaats = i;
                            }

                        }
                        //Verwijder en bevestig of geef foutmelding
                        if (_plaats != -1)
                        {
                            //Verwijder
                            _frigo[_plaats] = null;

                            Console.WriteLine("Dit product werd uit de frigo verwijderd.\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }
                        else
                        {
                            // Foutmelding
                            Console.WriteLine("Het product werd niet gevonden.\nDruk op enter om naar het hoofdmenu te gaan.");
                            Console.ReadKey();
                        }

                    }


                    //      3.4.Als Keuze 3: Tonen
                    else if (_keuze == 4)
                    {
                        //        3.4.1   Toon alles op het scherm
                        //                Overloop array
                        for(int i = 0; i < _frigo.Count(); i++)
                        {
                            //                Zet elke naam op het scherm

                            //                Sla lege plaatsen over
                            if (_frigo[i] != null)
                            {
                                Console.WriteLine($" {i+1}) {_frigo[i].Substring(0,1).ToUpper()}{_frigo[i].Substring(1, _frigo[i].Length-1 )}");

                            }
                            else
                            {
                                Console.WriteLine($" {i + 1}) Leeg");
                            }
                        }
                        // Foutmelding
                        Console.WriteLine("\n\nDruk op enter om naar het hoofdmenu te gaan.");
                        Console.ReadKey();

                    }

                    //      3.5 Afsluiten
                    else if (_keuze == 5)
                    {
                        // Scherm leegmaken
                        Console.Clear();

                        // melding
                        Console.WriteLine("Dada.\nDruk op enter om af te sluiten.");
                        Console.ReadKey();
                        _herhalen = false;

                    }

                    // Fout 
                    else
                    {
                        // Scherm leegmaken
                        Console.Clear();

                        // Foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.\nDruk op enter en probeer opnieuw.");
                        Console.ReadKey();
                    }

                }
                catch
                {
                    // Scherm leegmaken
                    Console.Clear();
                    
                    // Foutmelding
                    Console.WriteLine("U gaf een fout keuzegetal in.\nDruk op enter en probeer opnieuw.");
                    Console.ReadKey();

                }
            } while(_herhalen);


        }
    }
}
