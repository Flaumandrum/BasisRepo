using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_cards
{
    public class Card
    {
        // Fields 
        private sbyte _waarde = 0;
        private string _suit = "JOKER";

        // Constructors
        public Card() { }

        public Card(sbyte ontvWaarde, string ontvSuit)
        {
            _waarde = ontvWaarde;
            _suit = ontvSuit;
        }

        // Properties
        public sbyte PropWaarde 
        {
            get { return _waarde; }
        }

        public string PropSuit 
        { 
            get { return _suit; }
        }

        // Methods
        public string GetCard()
        {
            return $"{_waarde.ToString()} van {_suit}";
        }


    }
}
