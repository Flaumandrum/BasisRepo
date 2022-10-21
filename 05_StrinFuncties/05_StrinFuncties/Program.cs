using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_StrinFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tom Adriaens 
             * 11/10/2022
             * Stringfuncties
             */

            //Velden 
            String _woord1 = "";
            String _woord2 = "";
            Int32 sorteren ;
            bool _herhalen = true, _herhalen2 = true;

            //Programma
            //stap 1 : Intro
            Console.WriteLine("Welkom in dit programma over stringFuncties");
            Console.WriteLine("Druk op enter om verder te gaan");
            Console.ReadKey();

            do
            {

                //Scherm leegmaken 
                Console.Clear();

                //Stap 2 Vraag een woord aan de gebruiker
                Console.Write("Geef een woord/zin in (minimum 5 letters)");
                _woord1 = Console.ReadLine();

                if (_woord1.Length >= 5)
                {
                    //Herhalen stoppen
                    _herhalen = false;

                    //Scherm leegmaken 
                    Console.Clear();

                    //aantal letters in een woord of zin
                    Console.WriteLine($"Dit woord bevat {_woord1.Length.ToString()} tekens.");

                    //Alles in hoofdletters of in kleine letters
                    Console.WriteLine($"\n\nDit is het woord in hoodletters: {_woord1.ToUpper()}");

                    Console.WriteLine($"\n\nDit is het woord in kleine letters: {_woord1.ToLower()}");
                    Console.WriteLine("Druk op enter om verder te gaan ");
                    Console.ReadKey();

                    //Scherm leegmaken 
                    Console.Clear();

                    //Eerste 3 tekens van het woord 
                    Console.WriteLine($"Dit zijn de eerste 3 letters van het woord:  {_woord1.Substring(0, 3)} ");

                    //Laatste 4 tekens van het woord
                    Console.WriteLine($"\n\nDit is De laatste 4 letters van het woord: {_woord1.Substring((_woord1.Length - 4), 4)}");

                    Console.WriteLine("Druk op enter om verder te gaan ");
                    Console.ReadKey();

                    //Scherm leegmaken 
                    Console.Clear();

                    //5 spaties voor en achter woord  
                    _woord1 = "     " + _woord1 + "     ";
                    Console.WriteLine($"Dit is het woord met 5 spaties voor en na:  {_woord1}. ");

                    //5 spaties voor het woord verwijderd
                    _woord1 = _woord1.TrimStart();
                    Console.WriteLine($"\n\nDit is het woord met enkel de spaties voor het woord verwijderd: {_woord1}.");

                    //5 spaties na het woord verwijderd
                    _woord1 = _woord1.TrimEnd();
                    Console.WriteLine($"\n\nDit is het woord met de spaties na het woord verwijderd: {_woord1}.");


                    Console.WriteLine("Druk op enter om verder te gaan ");
                    Console.ReadKey();

                    //Scherm leegmaken 
                    Console.Clear();

                    //5 spaties voor en achter woord  
                    _woord1 = "     " + _woord1 + "     ";
                    Console.WriteLine($"Dit is het woord met 5 spaties voor en na:  {_woord1}. ");

                    //5 spaties voor het woord verwijderd
                    _woord1 = _woord1.Trim();
                    Console.WriteLine($"\n\nDit is het woord met  de spaties voor en na het woord verwijderd: {_woord1}.");

                    Console.WriteLine("Druk op enter om verder te gaan ");
                    Console.ReadKey();

                    //Scherm leegmaken 
                    Console.Clear();

                    // Zoek of er een e in het woord zit 
                    if (_woord1.IndexOf("E") != -1 || _woord1.IndexOf("e") != -1)
                    {
                        Console.WriteLine($"Dit is het woord met e of E vervangen door 3:  {_woord1.Replace("e", "3").Replace("E", "3")} ");

                    }
                    else
                    {
                        Console.WriteLine("Geen e of E, dus niet van toepassing.");
                    }
                    Console.WriteLine("Druk op enter om verder te gaan ");
                    Console.ReadKey();

                    //Scherm leegmaken 
                    Console.Clear();
                    do
                    {


                        //Stap 2 Vraag een woord aan de gebruiker
                        Console.Write("Geef een tweede woord/zin in (minimum 5 letters)");
                        _woord2 = Console.ReadLine();

                        if (_woord2.Length >= 5)
                        {
                            _herhalen2 = false;

                            sorteren =  String.Compare(_woord1, _woord2);
                            if (sorteren == 0)
                            {
                                Console.WriteLine("Deze 2 woorden/zinnen zijn gelijk");

                            }
                            else if (sorteren < 0)
                            {
                                Console.WriteLine($"Woord1({_woord1}) komt alfabetisch voor woord2({_woord2})");

                            }
                            else
                            {
                                Console.WriteLine($"Woord2({_woord2}) komt alfabetisch voor woord1({_woord1})");

                            }

                            Console.WriteLine("Druk op enter om verder te gaan ");
                            Console.ReadKey();

                        }
                        else
                        {
                            //Scherm leegmaken 
                            Console.Clear();

                            Console.WriteLine("Dit woord bevat te weining letters (min 5)");
                            Console.WriteLine("Druk op enter om opnieuw te proberen");
                            Console.ReadKey();
                        }
                             

                    } while (_herhalen2);
                }
                else
                {
                    //Scherm leegmaken 
                    Console.Clear();

                    Console.WriteLine("Dit woord bevat te weining letters (min 5)");
                    Console.WriteLine("Druk op enter om opnieuw te proberen");
                    Console.ReadKey();
                }

            } while (_herhalen);

        }
    }
}
