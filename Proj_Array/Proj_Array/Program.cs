using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 18/11/2022
            // Project Array

            // Velden
            String[] _namen = new string[7];
            int _aantal = 0;


            // Programma
            //Vullen Array
            _namen[0] = "Finten";
            _namen[1] = "Erika";
            _namen[2] = "Bob";
            _namen[3] = "Alan";
            _namen[4] = "Steve";
            _namen[5] = "Elon";
            _namen[6] = "SDDF6546dfsdf";

            // Tonen Array
            for (int i = 0 ; i < 7; i++)
            {
                Console.WriteLine(_namen[i]);
                
            }
            Console.WriteLine("\nDruk op enter om verder te gaan.\n\n");
            Console.ReadKey();

           

            foreach(string s in _namen) 
            {
                Console.WriteLine(s);

            }
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            //Scherm leegmaken

            // Laten vullen door de gebruiker
            Console.Write("Hoeveel namen wilt uw opslaan?");
            
            _aantal = int.Parse(Console.ReadLine());

            // Vraag de namen aan de gebruiker
            for(int i = 0 ; i < _namen.Count(); i++)
            {   
                Console.Write($"Geef naam {i+1}:");
                _namen[i] = Console.ReadLine();
                Console.WriteLine();
            }




        }
    }
}
