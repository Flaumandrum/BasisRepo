using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09Proj_Sportdag
{
    internal class Program
    {
        // Tom Adriaens
        // 09/02/2023
        // Project Sportdag

        // Velden 
        static String[] _namen = new string[20];
        static String[] _klassen = new string[20];
        static Byte[] _sporten = new byte[20];

        //GUI
        static void Main(string[] args)
        {   // lokale variabelen
            byte keuze = 0;

            // Intro
            Console.WriteLine("Welkom op dit programma voor de sportdag.");
            Console.WriteLine("\nDruk op enter om verder te gaan.");

            Console.ReadKey();

            do
            {
                // Scherm leegmaken 
                Console.Clear();

                // Toon menu(Toevoegen, Zoeken, Afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n    1) Toevoegen\n    2) Zoeken\n    3) Afsluiten\n    4) Opslaan \n    5) Opvragen\n    6) toon alles");
                
                try
                {
                    // Vraag keuze +opslaan
                    Console.Write("\n\nUw keuze: ");
                    keuze = byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();


                    // Als 1: Toevoegen
                    if (keuze == 1)
                    {

                        // Zoek lege plaats +opslaan
                        sbyte ontvLegePlaats = ZoekLegePlaats();
                        // Als lege plaats gevonden
                        if (ontvLegePlaats != -1)
                        {
                            // Vraag naam +klas + opslaan
                            Console.Write("Geef de naam van de leerling: ");
                            string leerling = Console.ReadLine();

                            Console.Write("Geef de afkorting van de klas: ");
                            string klas = Console.ReadLine();


                            // Toon sporten
                            Console.WriteLine("\n\n\nMaak uw keuze uit volgende sporten: ");
                            Console.WriteLine("\n    1) Zwemmen\n    2) Fietsen\n    3) Hordelopen");

                            // Vraag keuze sport + opslaan
                            Console.Write("\n\nUw keuze: ");
                            keuze = byte.Parse(Console.ReadLine());

                            // Gegevens opslaan in arrays
                            Toevoegen(leerling, klas, keuze, ontvLegePlaats);

                            // Scherm leegmaken 
                            Console.Clear();

                            // begeleiding
                            Console.WriteLine("Deze leerling werd toegevoegd aan de lijst.");
                            Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                            Console.ReadKey();
                            
                            

                        }
                        else
                        {
                            // Of geen lege plaats gevonden
                            // Scherm leegmaken 
                            Console.Clear();

                            // foutmelding
                            Console.WriteLine("Er is geen plaats meer in de lijst.");
                            Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                            Console.ReadKey();
                        }
                        keuze = 0;
                    }

                    // Als 2: Zoeken
                    else if (keuze == 2)
                    {
                        do
                        {
                            // Toon menu(zoeken op sport, zoeken op klas)
                            Console.WriteLine("\n\n\nMaak uw keuze uit volgende zoekmethoden: ");
                            Console.WriteLine("\n    1) zoeken op sport \n    2) Zoeken op klas\n    3) Terug keren");
                            try
                            {
                                // Vraag keuze + opslaan
                                Console.Write("\n\nUw keuze: ");
                                keuze = byte.Parse(Console.ReadLine());

                                // Als Zoeken op sport
                                if (keuze == 1)
                                {
                                    // Scherm leegmaken 
                                    Console.Clear();

                                    // Toon Sporten +vraag keuze + opslaan
                                    // Toon sporten
                                    Console.WriteLine("\n\n\nMaak uw keuze uit volgende sporten: ");
                                    Console.WriteLine("\n    1) Zwemmen\n    2) Fietsen\n    3) Hordelopen");

                                    // Vraag keuze sport + opslaan
                                    Console.Write("\n\nUw keuze: ");
                                    keuze = byte.Parse(Console.ReadLine());

                                    // Scherm leegmaken 
                                    Console.Clear();

                                    // Toon resultaat
                                    Console.WriteLine(ZoekOpSport(keuze));
                                    Console.WriteLine("\n\nDruk op enter om terug te keren naar het zoekmenu.");

                                    Console.ReadKey();

                                    keuze = 0;

                                }
                                // Als Zoek op klas
                                else if (keuze == 2)
                                {

                                    // Vraag klas +opslaan
                                    Console.Write("Geef de afkorting van de klas: ");
                                    string klas = Console.ReadLine();

                                    // Scherm leegmaken 
                                    Console.Clear();


                                    // Toon resultaat
                                    Console.WriteLine(ZoekOpKlas(klas));
                                    Console.WriteLine("\n\nDruk op enter om terug te keren naar het zoekmenu.");

                                    Console.ReadKey();
                                }
                                else if (keuze == 3)
                                {
                                    // Scherm leegmaken 
                                    Console.Clear();

                                    // begeleiding
                                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                                    Console.ReadKey();

                                }

                               
                                else
                                {
                                    // Scherm leegmaken 
                                    Console.Clear();

                                    // foutmelding
                                    Console.WriteLine("U gaf geen juiste keuze.");
                                    Console.WriteLine("\nDruk op enter om terug te keren naar het zoekmenu.");

                                    Console.ReadKey();

                                }
                            }
                            catch
                            {
                                // Scherm leegmaken 
                                Console.Clear();

                                // foutmelding
                                Console.WriteLine("Er ging iets mis.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar het zoekmenu.");

                                Console.ReadKey();

                            }
                        } while(keuze!= 3);
                        keuze = 0;
                    }
                    // Als 3: Afsluiten
                    else if (keuze == 3)
                    {
                        // Scherm leegmaken 
                        Console.Clear();

                        // begeleiding
                        Console.WriteLine("Tot een volgende keer.");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");

                        Console.ReadKey();

                    }

                    else if (keuze == 4)
                    {
                        SlaGegevensOp();
                    }

                    else if (keuze == 5)
                    {
                        LoadGegevens();
                    }

                    else if (keuze == 6)
                    {
                        Console.WriteLine(ToonAlleGegevens());

                        Console.ReadKey();
                    }
                    // Foutafhandeling 
                    else
                    {
                        // Scherm leegmaken 
                        Console.Clear();

                        // foutmelding
                        Console.WriteLine("U gaf geen juiste keuze.");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                        Console.ReadKey();

                    }
                }
                catch 
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("Er ging iets mis.");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                    Console.ReadKey();

                }
            } while(keuze != 3);
        }

        //Functies
        /// <summary>
        /// zoekt een lege plaats in de array
        /// </summary>
        /// <returns>-1 bij geen lege plaats of de index van de lege plaats</returns>
        static sbyte ZoekLegePlaats()
        {
            sbyte antwoord = -1;
            
            // Overloop de array
            for(int i = 0; i < _namen.Count(); i++)
            {
                if (_namen[i] == null|| _namen[i] == "" )
                {
                    antwoord = Convert.ToSByte(i);
                    break;
                }
            }

            return antwoord;
        }

        /// <summary>
        /// Voegt de gegevens toe in de arrays
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvKlas"></param>
        /// <param name="ontvSport"></param>
        /// <param name="ontvPlaats"></param>
        static void Toevoegen(string ontvNaam, string ontvKlas, byte ontvSport, sbyte ontvPlaats)
        {
            _namen[ontvPlaats] = ontvNaam;
            _klassen[ontvPlaats] = ontvKlas;
            _sporten[ontvPlaats] = ontvSport;
        }

        /// <summary>
        /// zoekt in de sport array de juiste sport en toont alle gegevens van de leerling
        /// </summary>
        /// <param name="ontvSport"></param>
        /// <returns>naam, klas, sport</returns>
        static String ZoekOpSport(byte ontvSport)
        {
            string antwoord = "";

            // Overloop de array
            for (int i = 0; i < _namen.Count(); i++)
            {
                if (_sporten[i] == ontvSport)
                {
                    string sport = "";

                    if (_sporten[i] == 1)
                    {
                        sport = "Zwemmen";
                    }
                    else if (_sporten[i] == 2)
                    {
                        sport = "Fietsen";
                    }
                    else
                    {
                        sport = "Hordelopen";
                    }

                    antwoord += $" Naam: {_namen[i]} Klas: {_klassen[i]} Sport:{_sporten[i]}  \n";
                   
                }
            }

            return antwoord;

        }

        /// <summary>
        /// Zoekt in de klasarray de juiste klas en toont alle gegevens van de leerling
        /// </summary>
        /// <param name="ontvKlas"></param>
        /// <returns>naam, klas , sport </returns>
        static String ZoekOpKlas(string ontvKlas)
        {
            string antwoord = "";

            // Overloop de array
            for (int i = 0; i < _namen.Count(); i++)
            {
                if (_klassen[i] == ontvKlas)
                {
                    string sport = "";

                    if(_sporten[i] == 1)
                    {
                        sport = "Zwemmen";
                    }
                    else if (_sporten[i] == 2)
                    {
                        sport = "Fietsen";
                    }
                    else
                    {
                        sport = "Hordelopen";
                    }

                    antwoord += $"Naam: {_namen[i]} Klas: {_klassen[i]} Sport:{ sport} \n";

                }
            }

            return antwoord;

        }

        static string ToonAlleGegevens()
        {
            string antwoord = "";
            
            for(int i = 0; i< _namen.Count(); i++)
            {
                if (_namen[i] == null || _namen[i] == "")
                {

                }
                else
                {
                    antwoord += $"naam: {_namen[i]} , klas: {_klassen[i]}, sport: {_sporten[i]}\n";
                }

            }

            return antwoord;
        }


        /// <summary>
        /// stuur de array door naar de file en schrijf hem weg
        /// </summary>
        static void SlaGegevensOp ()
        {
            string pad = @"C:\Users\tom.adriaens\Documents\Informatica\Test.txt";
            StreamWriter sw = new StreamWriter(pad);

            for (int i = 0; i < _namen.Count(); i++)
            {
                sw.WriteLine(_namen[i]);
                sw.WriteLine(_klassen[i]);
                sw.WriteLine(_sporten[i]);
            }
            sw.Close();
        }

        static void LoadGegevens()
        {
            string pad = @"C:\Users\tom.adriaens\Documents\Informatica\Test.txt";
            string[] gegevens = File.ReadAllLines(pad);

            for(int i = 0; i <_namen.Count(); i ++)
            {
                int t = i * 3;
                if (gegevens[i]  == "")
                {

                }
                else
                {
                    _namen[i] = gegevens[t];
                    _klassen[i] = gegevens[t + 1];
                    _sporten[i] = byte.Parse(gegevens[t + 2]);
                }
            }

        }

    }
}
