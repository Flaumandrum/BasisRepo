using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_ProjDobbelsteen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Rollen());
        }

        // Tom Adriens
        // 17/05/2023
        // Project dobbelsteen

        // Velden 
        static Random _dobbelsteen = new Random();
        static List<byte> _resultaten = new List<byte>();

        // Functies
        // Rollen dobbelsteen
        static public void RollenDobbelstenen (byte ontvAantalOgen, byte ontvAantalDobbelstenen)
        {
            _resultaten.Clear();

            for(int i = 0 ; i < ontvAantalDobbelstenen; i++)
            {
                _resultaten.Add( Convert.ToByte(_dobbelsteen.Next(1,ontvAantalOgen+1)));
            }
            
        }


        // Toon de resultaten 
        static public string ToonResultaat()
        {
            string antwoord = "";
            int som = 0;
            int nummer = 1;
            
            foreach(byte b in _resultaten)
            {
                antwoord += $" dobbelsteen {nummer.ToString()}: {b.ToString()}" + Environment.NewLine;
                som += b;
                
                nummer++;
            }

            antwoord += Environment.NewLine + $"______________________________ ";
            antwoord += Environment.NewLine + $"Totaal :   {som.ToString()}";
            return antwoord;

        }
    }
}
