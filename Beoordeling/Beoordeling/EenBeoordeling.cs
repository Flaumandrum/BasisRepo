using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Beoordeling
{
    public class EenBeoordeling
    {
        // Fiels
        string _voornaam = "";
        string _achternaam = "";
        int _score = 0;

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

        public int PropScore
        {
            get { return _score; }
            set { _score = value; }
        }

        // Methods 
        /// <summary>
        /// Geeft de volledigenaam + de score weer
        /// </summary>
        /// <returns></returns>
        public string AlleGegevens()
        {
            string antwoord = "";

            antwoord = $"Naam: {_voornaam} {_achternaam}   Score: {Convert.ToString(_score)}";

            return antwoord;
        }

        /// <summary>
        /// Geeft de volledige naam weer
        /// </summary>
        /// <returns></returns>
        public string VolledigeNaam()
        {
            string antwoord = "";
            antwoord = $"Naam: {_voornaam} {_achternaam}";
            return antwoord;
        }

        // Constructors
        public EenBeoordeling ()
        { }
        public EenBeoordeling( string ontvVn)
        {
            _voornaam = ontvVn;
        }
        public EenBeoordeling(string ontvVn, string ontvAn)
        {
            _voornaam = ontvVn;
            _achternaam = ontvAn;
        }
        public EenBeoordeling(string ontvVn, string ontvAn, int ontvScore)
        {
             _voornaam = ontvVn;
             _achternaam = ontvAn;
             _score = ontvScore;
        }
    }
}
