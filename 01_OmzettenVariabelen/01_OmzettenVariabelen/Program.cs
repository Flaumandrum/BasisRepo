﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OmzettenVariabelen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tom Adriaens
             * 16/09/2022
             * Omzetten Variabelen
             */

            // Velden 
            Int32 _getal1 = 0, _getal2 = 0, _getal3 = 0;

            // Programma

            // Stap 1:  Intro
            Console.WriteLine("Welkom\n\nDruk op enter en geef 3 getallen in.");
            Console.ReadKey();

            //Scherm leegmaken 
            Console.Clear();

            // Stap 2: Vraag getal 1 + opslaan
            Console.Write("Geef getal 1 in: ");
            _getal1 = Int32.Parse( Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            // Stap 3: Vraag getal 2 + opslaan
            Console.Write("Geef getal 2 in: ");
            _getal2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            // Stap 4: Vraag getal 3 + opslaan
            Console.Write("Geef getal 3 in: ");
            _getal3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            // Stap 5: Toon de getallen in omgekeerde volgorde


        }
    }
}
