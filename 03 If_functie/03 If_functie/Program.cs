using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_If_functie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // Project if functie
            // 27/09/2022

            //Velden 
            byte _keuze = 0;

            //Programma
            // Stap 1) intro
            Console.WriteLine("Welkom!\n\nDit programma stelt je een heel belangrijke vraag!");
            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();

            // Scherm leegmaken 
            Console.Clear();

            // Stap 2) Stel de vraag + Toon de keuzes(Pitta, Franse Hamburger, kapsalon, iets anders)
            Console.WriteLine("Dit is de vraag: Wat bestel jij bij pitta Karine?");
            Console.WriteLine("\nHier zijn jouw keuzes:");
            Console.WriteLine("\n   1) Pitta\n   2) Franse Hamburger\n   3) Kapsalon\n   4) Iets anders");
            try
            {

                // Stap 3) Vraag keuze +opslaan
                Console.Write("\n\nGeef het nummer van uw keuze in: ");
                _keuze = byte.Parse(Console.ReadLine());

                // Scherm leegmaken 
                Console.Clear();

                // Stap 4) Toon de juiste tekst
                //  Als 1: U koos Pitta
                if (_keuze == 1)
                {
                    Console.WriteLine("U koos Pitta.");
                }
                //  Als 2: U koos Franse Hamburger
                else if (_keuze == 2)
                {
                    Console.WriteLine("U koos Franse Hamburger.");
                }
                //  Als 3: U koos Kapsalon
                else if (_keuze == 3)
                {
                    Console.WriteLine("U koos Kapsalon.");
                }
                //  Als 4: U koos iets anders
                else if (_keuze == 4)
                {
                    Console.WriteLine("U koos Iets Anders.");
                }
                else 
                {
                    Console.WriteLine("U gaf geen geldige keuze in.");
                }

                Console.WriteLine();
                Console.WriteLine("\nDruk op enter om af te sluiten.");
                Console.ReadKey();


            }
            catch
            {

                // Scherm leegmaken 
                Console.Clear();

                Console.WriteLine("U gaf geen geldig getal in. ");
                Console.WriteLine("\nDruk op enter om af te sluiten.");
                Console.ReadKey();
            }
        }
    }
}
