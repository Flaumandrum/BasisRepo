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

        // Methoden
        public string VolledigeNaam ()
        {
            return $"{_voornaam}  {_achternaam}";
        }

        // Constructor
        public Persoon () { }

    }
}
