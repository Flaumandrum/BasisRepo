using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAanwezigheden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // datum 24/01/2023
            // Project Aanwezigheden

            // Velden 
            byte _keuze = 0, _aantalLln =0;
            sbyte _nummerLln = -1, _gevonden = -1;
            String[] _voornamen = new string[0], _achternamen = new string[0];
           

            // Programma 

            // Stap 1: intro
            Console.WriteLine("Welkom op dit progamma om da aanwezigheden in te geven.");
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            // Scherm leegmaken 
            Console.Clear();

            // Stap 2: aantal leerlingen vragen + arrays aanpassen
            Console.WriteLine("Hoeveel leerlingen zitten er in deze klas?");
            Console.Write("\nAantal leerlingen: ");
            _aantalLln = byte.Parse(Console.ReadLine());

            _achternamen = new string[_aantalLln];
            _voornamen = new string[_aantalLln];

            // Scherm leegmaken 
            Console.Clear();

            // gebruike begeleiden
            Console.WriteLine("Deze klas werd aangemaakt.");
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                // Stap 3: toon menu(toevoegen, aanpassen, verwijderen, tonen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n   1) Voeg leerlingen toe\n   2) Pas namen aan\n   3) Verwijder een leerling\n   4) Toon alle aanwezige leerlingen\n   5) Afsluiten");

                try
                {
                    // Stap 4: Vraag keuze +opslaan
                    Console.Write("\n\nUw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    // Stap 5:	Als 1: toevoegen
                    if (_keuze == 1)
                    {
                        // reset var
                        _gevonden = -1;

                        // Zoek de eerste vrije plaats +opslaan
                        for (int i = 0; i < _voornamen.Length; i++)
                        {
                            if (_voornamen[i] ==  null)
                            {
                                _gevonden = Convert.ToSByte(i);
                                break;
                            }
                        }

                        // Of vraag de voornaam en achternaam +opslaan in array op juiste plaats
                        if (_gevonden != -1)
                        {
                            Console.Write("Geef de voornaam:");
                            _voornamen[_gevonden] = Console.ReadLine();
                            Console.Write("\nGeef de achternaam:");
                            _voornamen[_gevonden] = Console.ReadLine();
                        }

                        // Of toon foutmelding
                        else
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            // foutmelding
                            Console.WriteLine("Er is geen lege plaats in de array.");
                            Console.WriteLine("\nDruk op enter om verder te gaan.");
                            Console.ReadKey();
                        }
                    }

                    // Als 2: aanpassen
                    else if (_keuze == 2)
                    {

                        // Toon de leerlingen,
                        Console.WriteLine("De aanwezige leerlingen zijn:\n\n");
                        for (int i = 0; i < _voornamen.Length; i++)
                        {
                            if (_voornamen[i] != null)
                            {
                                Console.WriteLine($" {i + 1}) {_voornamen[i]} {_achternamen[i]}");
                            }
                            else
                            {
                                Console.WriteLine($" {i + 1}) leeg ");
                            }

                        }
                        // vraag de nummer van de leerling om te veranderen
                        // vraag voornaam &achternaam + sla op in arrays op de juiste plaats
                    }

                    // Als 3: verwijderen
                    else if (_keuze == 3)
                    {
                        // Toon de leerlingen,
                        Console.WriteLine("De aanwezige leerlingen zijn:\n\n");
                        for (int i = 0; i < _voornamen.Length; i++)
                        {
                            if (_voornamen[i] != null)
                            {
                                Console.WriteLine($" {i + 1}) {_voornamen[i]} {_achternamen[i]}");
                            }
                            else
                            {
                                Console.WriteLine($" {i + 1}) leeg ");
                            }

                        }
                        // vraag de nummer van de leerling om te verwijderen +verwijder
                        // verwijder in de arrays op de juiste plaats
                    }
                    // Als 4: tonen
                    else if (_keuze == 4)
                    {
                        // Toon de leerlingen,
                        Console.WriteLine("De aanwezige leerlingen zijn:\n\n");
                        for (int i = 0; i < _voornamen.Length; i++)
                        {
                            if (_voornamen[i] != null)
                            {
                                Console.WriteLine($" {i + 1}) {_voornamen[i]} {_achternamen[i]}");
                            }
                            else
                            {
                                Console.WriteLine($" {i + 1}) leeg ");
                            }

                        }

                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    // Als 5: Afsluiten
                    else if (_keuze == 1)
                    {

                    }
                    // in elk ander geval
                    else
                    {

                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen juiste keuze in.");
                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                    Console.ReadKey();
                }
            }
            while (_keuze != 5);

        }
    }
}
