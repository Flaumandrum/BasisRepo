using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Klasses_ProjWekker
{
    public class Wekker
    {
        // fields 
        Boolean _actief = true;
        DateTime _instelling = DateTime.Now;

        // Properties
        public Boolean PropActief
        {
            get { return _actief; }
            set { _actief = value; }
        }

        public DateTime PropInstelling
        { 
            get { return _instelling; }
            set { _instelling = value; }
        }

        // Methods
        /// <summary>
        /// Zeg hoelang het nog duurt eer de wekker zal afgaan
        /// </summary>
        /// <returns></returns>
        public String HoeLangNog()
        {
            String antwoord = "";

            // verminder de datum en het uur van de wekker met de huidige datum en uur
            TimeSpan tussenTijd = _instelling - DateTime.Now;

            // Geef weer hoeveel dagen- uur en minuten je nog hebt 
            // voor het alarm afgaat
            int aantalDag = Convert.ToInt32(Math.Floor(tussenTijd.TotalDays));
            int aantalUur =  Convert.ToInt32(Math.Floor(tussenTijd.TotalHours))- aantalDag*24;
            int aantalMin = Convert.ToInt32(Math.Floor(tussenTijd.TotalMinutes)) - aantalDag * 3600 - aantalUur * 60;
            // int aantalMin = Convert.ToInt32(Math.Floor(tussenTijd.TotalMinutes)) - Convert.ToInt32(Math.Floor(tussenTijd.TotalHours)) *60 

            // Zet het in een mooi antwoord
            antwoord = $"Het alarm gaat af binnen {aantalDag.ToString()} dagen {aantalUur.ToString()}uur en {aantalMin.ToString()} min";

            return antwoord;    
        }

        /// <summary>
        /// Geeft alle gegevens weer van de wekker
        /// </summary>
        /// <returns></returns>
        public String AlleGegevens()
        {
            String antwoord = "";

            antwoord = $"{_instelling.ToShortDateString()}:  {_instelling.ToShortTimeString() } {Environment.NewLine} actief : {_actief.ToString()} {Environment.NewLine} {HoeLangNog()}";

            return antwoord;
        }

        // Constructors
        public Wekker () { }

        public Wekker(DateTime ontvInstelling) 
        {
            _instelling = ontvInstelling;
        }

        public Wekker(Boolean ontvActief)
        {
            _actief = ontvActief;
        }

        public Wekker(DateTime ontvInstelling, Boolean ontvActief)
        {
            _instelling = ontvInstelling;
            _actief = ontvActief;
        }
    }
}
