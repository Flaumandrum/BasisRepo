using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using _19Klasses_ProjWekker;

namespace _20_Projec_Wekker
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
            Application.Run(new FrmStart());
        }

        // Velden
        static List<Wekker> _alarmen = new List<Wekker> ();

        // Functie
        static public String GetHuidigeTijd()
        {
            string antwoord = "";

            return antwoord;
        }

        static public void InstellenAlarm(DateTime alarm)
        {
            // eerst een object aanmaken 
           
            // toevoegen aan de list

        }

        static public void AanpassenAlarm(DateTime alarm, Boolean actief, int index)
        {

        }

        /// <summary>
        /// Verwijdert een alarm
        /// </summary>
        /// <param name="index"></param>
        static public void VerwijderenAlarm(int index)
        {
            _alarmen.RemoveAt(index);
        }

        /// <summary>
        /// Genereerd een willekeurige code en stuurt deze door
        /// </summary>
        /// <returns> een willekeurig 4delig getal </returns>
        static public int WillekeurigeCode()
        {
            int antwoord = 0;
            Random rdm = new Random();

            antwoord = rdm.Next(1000, 10000);

            return antwoord;
        }
        
        /// <summary>
        /// Kijkt of de ingegeven code gelijk is aan de getoonde code
        /// </summary>
        /// <param name="oudeCode"></param>
        /// <param name="nieuweCode"></param>
        /// <returns></returns>
        static public Boolean CheckCode(int oudeCode, int nieuweCode)
        {
            bool antwoord = false;

            if(oudeCode == nieuweCode)
            {
                antwoord = true;
            }

            return antwoord;
        }

        static public String ToonAlarmen()
        {
            string antwoord = "";

            return antwoord;
        }

    }
}
