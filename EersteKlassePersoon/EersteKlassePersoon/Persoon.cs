using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteKlassePersoon
{
    internal class Persoon
    {
        // Velden 
        private string _voornaam = "Jhon";
        private string _achternaam = "Dhoe";
        private DateTime _geboortedag = Convert.ToDateTime("01/01/1920");

        // Properties
        public string PropVoornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string PropAchternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        public DateTime PropGeboortedatum
        {
            get { return _geboortedag; }

        }

        // Methoden
        public string VolledigeNaam()
        {
            return $"{_voornaam}  {_achternaam}";
        }

        public int GetLeeftijd ()
        {
            TimeSpan leeftijd = DateTime.Now - _geboortedag;
            DateTime jaren = new DateTime(leeftijd.Ticks);
            return jaren.Year-1;
        }

        // Constructor
        public Persoon() { }

        public Persoon(string ontvVn, string ontvAn, DateTime ontvGebDatum) 
        {
            _voornaam = ontvVn;
            _achternaam = ontvAn;
            _geboortedag = ontvGebDatum;
            
        }
        
    }
}
