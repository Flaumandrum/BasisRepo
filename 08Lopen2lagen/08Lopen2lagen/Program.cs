using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _08Lopen2lagen
{
    internal class Program
    {
        // Tom Adriaens 
        // 03/02/2023
        // Project lopen 2 lagen

        // Velden
        static String[] _namen = new string[40];

        // GUI
        static void Main(string[] args)
        {
            //lokale variabelen
            byte keuze = 0;

            // Intro
            Console.WriteLine("Welkom in dit programma om lopers toe te voegen.");
            Console.WriteLine("\nDruk op enter om verder te gaan.");

            Console.ReadKey();

            //scherm leegmaken 
            Console.Clear();

            do
            {
                //scherm leegmaken 
                Console.Clear();

                // Toon menu(toevoegen, verwijderen, tonen)

                Console.WriteLine("Maak uw keuze uit onderstaand menu:\n");
                Console.WriteLine("\n   1) Toevoegen loper \n   2) Verwijder een loper\n   3) Toon de lopers\n   4) Afsluiten");
                try
                {

                    // Vraag keuze +opslaan
                    Console.Write("Uw keuze: ");
                    keuze = byte.Parse(Console.ReadLine());

                    //scherm leegmaken 
                    Console.Clear();

                    // Als 1: Toevoegen
                    if (keuze == 1)
                    {

                        //    Check lege plaats +opslaan
                        sbyte ontvPlaats = CheckLegePlaats();

                        //        Of Vraag naam + opslaan
                        if(ontvPlaats != -1)
                        {
                            Console.Write("Geef de naam van deze deelnemer: ");
                            string naam = Console.ReadLine();

                            //scherm leegmaken 
                            Console.Clear();


                            if (naam != "")
                            {
                                Console.WriteLine($"\n\nHet rugnummer van deze deelnemer is: {(ontvPlaats + 1).ToString()}");

                                Toevoegen(naam, ontvPlaats);

                                //begeleiding
                                Console.WriteLine("\nDeze deelnemer werd toegevoegd.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                                Console.ReadKey();
                            }
                            else
                            {
                                //scherm leegmaken 
                                Console.Clear();

                                //Foutmelding
                                Console.WriteLine("U gaf geen naam in.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                                Console.ReadKey();
                            }
                        }
                        //         Of foutmelding
                        else
                        {
                            //Foutmelding
                            Console.WriteLine("Er is geen plaats meer om deelnemers toe te voegen.");
                            Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                            Console.ReadKey();
                        }

                    }
                    // Als 2: verwijderen
                    else if (keuze == 2)
                    {
                        //    Vraag het rugnummer +opslaan
                        Console.Write("Geef het rugnummer van de deelnemer: ");
                        byte rugnummer = byte.Parse(Console.ReadLine());

                        if(rugnummer <=40 && rugnummer >0)
                        {

                            //    Zoek + verwijder + opslaan
                            bool ontvAntwoord =  ZoekEnVerwijder(rugnummer);

                            //scherm leegmaken 
                            Console.Clear();


                            //        Of Verwijderen bevestigen
                            if (ontvAntwoord)
                            {
                                //begeleiden
                                Console.WriteLine("Dit rugnummer is verwijderd.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                                Console.ReadKey();
                            }
                            //        Of foutmelding
                            else
                            {
                                //scherm leegmaken 
                                Console.Clear();


                                //Foutmelding
                                Console.WriteLine("Dit rugnummer is reeds verwijderd.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                                Console.ReadKey();
                            }

                        }
                        else
                        {
                            //scherm leegmaken 
                            Console.Clear();


                            //Foutmelding
                            Console.WriteLine("U gaf geen juist rugnummer in.");
                            Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                            Console.ReadKey();
                        }
                    }

                    // Als 3: Tonen
                    else if (keuze == 3)
                    {
                        //    Toon gegevens
                        Console.WriteLine(ToonAlleGegevens());

                        Console.WriteLine("\n\nDruk op enter om terug te keren naar het hoofdmenu.");

                        Console.ReadKey();
                    }
                    // else 4: Afsluiten
                    else if (keuze == 4)
                    {
                        //scherm leegmaken 
                        Console.Clear();

                        //Foutmelding
                        Console.WriteLine("Tot een volgende keer.");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");

                        Console.ReadKey();
                    }

                    else 
                    {
                        //scherm leegmaken 
                        Console.Clear();

                        //Foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                        Console.ReadKey();
                    }
                }
                catch 
                {
                    //scherm leegmaken 
                    Console.Clear();

                    //Foutmelding
                    Console.WriteLine("U gaf geen juist getal in.");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");

                    Console.ReadKey();
                }
            }
            while (keuze != 4);
        }

        // Functies
        /// <summary>
        /// zoekt een lege plaats in de array
        /// </summary>
        /// <returns>index in arry als sbyte </returns>
        static sbyte CheckLegePlaats()
        {
            // Maak een antwoord variabele om te returnen 
            sbyte antwoord= -1;

            // Overloop de array met een lus
            for(int i = 0; i<_namen.Count(); i++)
            {
                // Kijk of de plaats leeg is 
                if (_namen[i] ==  null)
                {
                    // Sla de lege index op in mijn antwoord
                    antwoord = Convert.ToSByte( i);

                    // stop de loop
                    break;
                }
            }

            // return het antwoord
            return antwoord;
        }

        /// <summary>
        /// voegt een ontvangen naam toe, in de array op een ontvangen plaats
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvPlaats"></param>
        static void Toevoegen(String ontvNaam, int ontvPlaats)
        {
            // Sla de ontvangen naam op in de array op de ontvangen lege index
            _namen[ontvPlaats] = ontvNaam;

        }


        /// <summary>
        /// verwijdert de gegevens in de array op een bepaalde plaats via een ontvangen rugnummer
        /// </summary>
        /// <param name="ontvRugnummer"></param>
        /// <returns> of het verwijderen gelukt is (true) of niet (false)</returns>
        static Boolean ZoekEnVerwijder(byte ontvRugnummer)
        {
            // maak een antwoord om terug te sturen 
            Boolean antwoord = false;
           
            // Kijk of de plaats leeg is 
            if (_namen[(ontvRugnummer-1)] != null)
            {
                _namen[(ontvRugnummer-1)] = null;
                antwoord= true;
            }
           
            // Stuur antwoord terug
            return antwoord;
        }

        /// <summary>
        /// geeft alle ingeschreven lopers weer, met hun rugnummer
        /// </summary>
        /// <returns></returns>
        static String ToonAlleGegevens()
        {
            // maak een antwoord om terug te sturen 
            string antwoord = null;

            // Overloop de array met een lus
            for (int i = 0; i < _namen.Count(); i++)
            {
                // Kijk of de plaats leeg is 
                if (_namen[i] != null)
                {
                    antwoord += $"rugnummer : {(i + 1).ToString()}  naam: {_namen[i]} \n";
                }
            }

            // Stuur antwoord terug
            return antwoord;
        }

    }
}
